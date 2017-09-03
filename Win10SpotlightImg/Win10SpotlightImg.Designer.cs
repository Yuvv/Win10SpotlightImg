namespace Win10SpotlightImg {
    partial class Win10SpotlightImg {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.imgContainer = new System.Windows.Forms.PictureBox();
            this.btnLastImg = new System.Windows.Forms.Button();
            this.btnNextImg = new System.Windows.Forms.Button();
            this.btnLove = new System.Windows.Forms.Button();
            this.btnHeartbreak = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.setSpotlightDirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setImageDirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.imgContainer)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgContainer
            // 
            this.imgContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgContainer.Location = new System.Drawing.Point(6, 7);
            this.imgContainer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.imgContainer.Name = "imgContainer";
            this.imgContainer.Size = new System.Drawing.Size(1338, 715);
            this.imgContainer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgContainer.TabIndex = 0;
            this.imgContainer.TabStop = false;
            this.imgContainer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.imgContainer_MouseClick);
            // 
            // btnLastImg
            // 
            this.btnLastImg.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnLastImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.btnLastImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLastImg.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLastImg.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnLastImg.Location = new System.Drawing.Point(9, 305);
            this.btnLastImg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLastImg.Name = "btnLastImg";
            this.btnLastImg.Size = new System.Drawing.Size(36, 36);
            this.btnLastImg.TabIndex = 999;
            this.btnLastImg.TabStop = false;
            this.btnLastImg.Text = "←";
            this.toolTip1.SetToolTip(this.btnLastImg, "上一张");
            this.btnLastImg.UseVisualStyleBackColor = false;
            this.btnLastImg.Click += new System.EventHandler(this.btnLastImg_Click);
            // 
            // btnNextImg
            // 
            this.btnNextImg.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnNextImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.btnNextImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextImg.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNextImg.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnNextImg.Location = new System.Drawing.Point(1285, 305);
            this.btnNextImg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNextImg.Name = "btnNextImg";
            this.btnNextImg.Size = new System.Drawing.Size(36, 36);
            this.btnNextImg.TabIndex = 999;
            this.btnNextImg.TabStop = false;
            this.btnNextImg.Text = "→";
            this.toolTip1.SetToolTip(this.btnNextImg, "下一张");
            this.btnNextImg.UseVisualStyleBackColor = false;
            this.btnNextImg.Click += new System.EventHandler(this.btnNextImg_Click);
            this.btnNextImg.MouseEnter += new System.EventHandler(this.btnNextImg_MouseEnter);
            this.btnNextImg.MouseLeave += new System.EventHandler(this.btnNextImg_MouseLeave);
            // 
            // btnLove
            // 
            this.btnLove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.btnLove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLove.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLove.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnLove.Location = new System.Drawing.Point(1245, 51);
            this.btnLove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLove.Name = "btnLove";
            this.btnLove.Size = new System.Drawing.Size(24, 24);
            this.btnLove.TabIndex = 999;
            this.btnLove.TabStop = false;
            this.btnLove.Text = "❤";
            this.toolTip1.SetToolTip(this.btnLove, "喜欢");
            this.btnLove.UseVisualStyleBackColor = false;
            this.btnLove.Click += new System.EventHandler(this.btnLove_Click);
            // 
            // btnHeartbreak
            // 
            this.btnHeartbreak.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHeartbreak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.btnHeartbreak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHeartbreak.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnHeartbreak.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnHeartbreak.Location = new System.Drawing.Point(1285, 51);
            this.btnHeartbreak.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHeartbreak.Name = "btnHeartbreak";
            this.btnHeartbreak.Size = new System.Drawing.Size(24, 24);
            this.btnHeartbreak.TabIndex = 999;
            this.btnHeartbreak.TabStop = false;
            this.btnHeartbreak.Text = "💔";
            this.toolTip1.SetToolTip(this.btnHeartbreak, "心碎");
            this.btnHeartbreak.UseVisualStyleBackColor = false;
            this.btnHeartbreak.Click += new System.EventHandler(this.btnHeartbreak_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.toolTip1.ForeColor = System.Drawing.SystemColors.Info;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setSpotlightDirToolStripMenuItem,
            this.setImageDirToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(147, 48);
            // 
            // setSpotlightDirToolStripMenuItem
            // 
            this.setSpotlightDirToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.setSpotlightDirToolStripMenuItem.Name = "setSpotlightDirToolStripMenuItem";
            this.setSpotlightDirToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.setSpotlightDirToolStripMenuItem.Text = "Set Spotlight Dir";
            this.setSpotlightDirToolStripMenuItem.Click += new System.EventHandler(this.setSpotlightDirToolStripMenuItem_Click);
            // 
            // setImageDirToolStripMenuItem
            // 
            this.setImageDirToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.setImageDirToolStripMenuItem.Name = "setImageDirToolStripMenuItem";
            this.setImageDirToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.setImageDirToolStripMenuItem.Text = "Set Image Dir";
            this.setImageDirToolStripMenuItem.Click += new System.EventHandler(this.setImageDirToolStripMenuItem_Click);
            // 
            // Win10SpotlightImg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.btnHeartbreak);
            this.Controls.Add(this.btnLove);
            this.Controls.Add(this.btnNextImg);
            this.Controls.Add(this.btnLastImg);
            this.Controls.Add(this.imgContainer);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Win10SpotlightImg";
            this.Padding = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Text = "Win10SpotlightImg";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Win10SpotlightImg_FormClosing);
            this.Load += new System.EventHandler(this.Win10SpotlightImg_Load);
            this.ResizeEnd += new System.EventHandler(this.Win10SpotlightImg_ResizeEnd);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Win10SpotlightImg_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.imgContainer)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgContainer;
        private System.Windows.Forms.Button btnLastImg;
        private System.Windows.Forms.Button btnNextImg;
        private System.Windows.Forms.Button btnLove;
        private System.Windows.Forms.Button btnHeartbreak;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem setSpotlightDirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setImageDirToolStripMenuItem;
    }
}

