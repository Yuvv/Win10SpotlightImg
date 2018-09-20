using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Win10SpotlightImg {
    public partial class Win10SpotlightImg: Form {
        private string baseDir;
        private string targetDir;
        private List<String> imgList = new List<string>();
        private int curPos = 0;
        private SQLiteConnection conn;
        private SQLiteCommand cmd;

        private void loadImage() {
            if (imgList.Count == 0) {
                MessageBox.Show("没有更多图片(⊙﹏⊙)！", "注意(⊙﹏⊙)");
                imgContainer.Image = imgContainer.ErrorImage;
                return;
            }
            try {
                imgContainer.Load(Path.Combine(baseDir, imgList[curPos]));
            } catch (Exception) {
                imgContainer.Image = imgContainer.ErrorImage;
            }
        }

        private void nextImage() {
            curPos++;
            if (curPos >= imgList.Count) {
                curPos -= imgList.Count;
            }
            loadImage();
        }

        private void lastImage() {
            curPos--;
            if (curPos < 0) {
                curPos += imgList.Count;
            }
            loadImage();
        }

        private void initDB() {
            conn = new SQLiteConnection("Data Source=img.db");
            conn.Open();
            cmd = new SQLiteCommand(conn);

            cmd.CommandText = "create table if not exists imgs(imgid char(64), loved bool default false, viewed bool default false);";
            cmd.ExecuteNonQuery();

            string basedir = string.Format(@"C:\Users\{0}\AppData\Local\Packages", Environment.UserName);
            if (Directory.Exists(basedir)) {
                string[] dirs = Directory.GetDirectories(basedir, "Microsoft.Windows.ContentDeliveryManager_*");
                if (dirs.Length > 0) {
                    basedir = Path.Combine(dirs[0], @"LocalState\Assets");
                }
            }
            Directory.CreateDirectory(@".\_img");
            try {
                cmd.CommandText = "create table if not exists settings" +
                "(id int primary key, basedir text, targetdir text, win_w int default 1024, win_h int default 576);" +
                "insert into settings (id, basedir, targetdir) values (0, \'" + basedir + "\', \'.\\_img\\\');";
                cmd.ExecuteNonQuery();
            } catch (SQLiteException) {
                // TODO: do nothing?
            }
        }

        private void initSettings() {
            cmd.CommandText = "select basedir, targetdir, win_w, win_h from settings;";
            SQLiteDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows) {
                while (reader.Read()) {
                    baseDir = reader.GetString(0);
                    targetDir = reader.GetString(1);
                    this.Width = reader.GetInt32(2);
                    this.Height = reader.GetInt32(3);
                }
            } else {
                MessageBox.Show("Please set baseDir and targetDir at first!");
            }
            reader.Close();
        }

        private void initImgList() {
            imgList.Clear();
            string[] imgFiles = Directory.GetFiles(baseDir, "*", SearchOption.TopDirectoryOnly);
            foreach (string file in imgFiles) {
                FileInfo fi = new FileInfo(file);
                cmd.CommandText = string.Format("select imgid,loved,viewed from imgs where imgid=\'{0}\'", fi.Name);
                SQLiteDataReader reader = cmd.ExecuteReader();
                if (!reader.HasRows) {
                    reader.Close();
                    cmd.CommandText = string.Format("insert into imgs (imgid) values (\'{0}\')", fi.Name);
                    cmd.ExecuteNonQuery();
                    imgList.Add(fi.Name);
                } else {
                    while (reader.Read()) {
                        if (!(bool)reader["viewed"]) {
                            imgList.Add(fi.Name);
                        }
                    }
                    reader.Close();
                }
            }
        }
        
        public Win10SpotlightImg() {
            InitializeComponent();
        }

        private void Win10SpotlightImg_Load(object sender, EventArgs e) {
            initDB();
            initSettings();
            initImgList();
            loadImage();
        }

        private void Win10SpotlightImg_FormClosing(object sender, FormClosingEventArgs e) {
            conn.Close();
        }

        private void btnLastImg_Click(object sender, EventArgs e) {
            lastImage();
        }

        private void btnNextImg_Click(object sender, EventArgs e) {
            nextImage();
        }

        private void Win10SpotlightImg_KeyUp(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Left) {
                lastImage();
            } else if (e.KeyCode == Keys.Right) {
                nextImage();
            }
        }

        private void btnHeartbreak_Click(object sender, EventArgs e) {
            if (imgList.Count == 0) {
                MessageBox.Show("没有更多图片(⊙﹏⊙)！", "注意(⊙﹏⊙)");
                return;
            }
            cmd.CommandText = string.Format("update imgs set viewed=1 where imgid=\'{0}\'", imgList[curPos]);
            cmd.ExecuteNonQuery();
            imgList.RemoveAt(curPos);
            curPos--;
            nextImage();
        }

        private void btnLove_Click(object sender, EventArgs e) {
            if (imgList.Count == 0) {
                MessageBox.Show("没有更多图片(⊙﹏⊙)！", "注意(⊙﹏⊙)");
                return;
            }
            File.Copy(Path.Combine(baseDir, imgList[curPos]),
                      Path.Combine(targetDir, imgList[curPos] + ".jpg"),
                      true);
            cmd.CommandText = string.Format("update imgs set loved=1,viewed=1 where imgid=\'{0}\'", imgList[curPos]);
            cmd.ExecuteNonQuery();
            imgList.RemoveAt(curPos);
            curPos--;
            nextImage();
        }

        private void btnNextImg_MouseEnter(object sender, EventArgs e) {
            // TODO:
        }

        private void btnNextImg_MouseLeave(object sender, EventArgs e) {
            // TODO:
        }

        private void setSpotlightDirToolStripMenuItem_Click(object sender, EventArgs e) {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.Description = "Set Spotlight Image Folder";
            dlg.RootFolder = Environment.SpecialFolder.UserProfile;
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                baseDir = dlg.SelectedPath;
                cmd.CommandText = string.Format("update settings set basedir=\'{0}\' where id=0;", baseDir);
                cmd.ExecuteNonQuery();

                curPos = 0;
                initImgList();
                loadImage();
            }
        }

        private void setImageDirToolStripMenuItem_Click(object sender, EventArgs e) {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.Description = "Set Target Image Folder";
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                targetDir = dlg.SelectedPath;
                cmd.CommandText = string.Format("update settings set targetdir=\'{0}\' where id=0;", targetDir);
                cmd.ExecuteNonQuery();
            }
        }

        private void imgContainer_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == System.Windows.Forms.MouseButtons.Right) {
                contextMenuStrip1.Show(this, e.X, e.Y);
            }
        }

        private void Win10SpotlightImg_ResizeEnd(object sender, EventArgs e) {
            if (imgList.Count > 0) {
                cmd.CommandText = string.Format("update settings set win_w={0},win_h={1} where id=0;", this.Width, this.Height);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
