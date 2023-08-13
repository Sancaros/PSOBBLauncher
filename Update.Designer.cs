
namespace PSOBBLauncher
{
    partial class 更新程序
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(更新程序));
            this.更新程序进度条 = new System.Windows.Forms.ProgressBar();
            this.更新程序文字 = new System.Windows.Forms.Label();
            this.更新完成图片 = new System.Windows.Forms.PictureBox();
            this.更新文件列表 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.更新完成图片)).BeginInit();
            this.SuspendLayout();
            // 
            // 更新程序进度条
            // 
            this.更新程序进度条.BackColor = System.Drawing.SystemColors.Control;
            this.更新程序进度条.Location = new System.Drawing.Point(12, 96);
            this.更新程序进度条.Name = "更新程序进度条";
            this.更新程序进度条.Size = new System.Drawing.Size(255, 23);
            this.更新程序进度条.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.更新程序进度条.TabIndex = 0;
            // 
            // 更新程序文字
            // 
            this.更新程序文字.AutoSize = true;
            this.更新程序文字.BackColor = System.Drawing.Color.Transparent;
            this.更新程序文字.Location = new System.Drawing.Point(12, 81);
            this.更新程序文字.Name = "更新程序文字";
            this.更新程序文字.Size = new System.Drawing.Size(0, 12);
            this.更新程序文字.TabIndex = 2;
            // 
            // 更新完成图片
            // 
            this.更新完成图片.BackColor = System.Drawing.Color.Transparent;
            this.更新完成图片.Image = global::PSOBBLauncher.Properties.Resources.bg2_fw;
            this.更新完成图片.Location = new System.Drawing.Point(27, 12);
            this.更新完成图片.Name = "更新完成图片";
            this.更新完成图片.Size = new System.Drawing.Size(106, 107);
            this.更新完成图片.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.更新完成图片.TabIndex = 4;
            this.更新完成图片.TabStop = false;
            // 
            // 更新文件列表
            // 
            this.更新文件列表.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.更新文件列表.FormattingEnabled = true;
            this.更新文件列表.ItemHeight = 12;
            this.更新文件列表.Location = new System.Drawing.Point(12, 12);
            this.更新文件列表.Name = "更新文件列表";
            this.更新文件列表.Size = new System.Drawing.Size(242, 64);
            this.更新文件列表.TabIndex = 5;
            // 
            // 更新程序
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PSOBBLauncher.Properties.Resources.pso_20050221_800_061;
            this.ClientSize = new System.Drawing.Size(484, 131);
            this.ControlBox = false;
            this.Controls.Add(this.更新文件列表);
            this.Controls.Add(this.更新完成图片);
            this.Controls.Add(this.更新程序文字);
            this.Controls.Add(this.更新程序进度条);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "更新程序";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "梦幻之星中国 服务器 更新程序";
            this.Load += new System.EventHandler(this.更新程序_Load);
            this.Shown += new System.EventHandler(this.更新程序_Shown);
            this.Resize += new System.EventHandler(this.更新程序_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.更新完成图片)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar 更新程序进度条;
        private System.Windows.Forms.Label 更新程序文字;
        private System.Windows.Forms.PictureBox 更新完成图片;
        private System.Windows.Forms.ListBox 更新文件列表;
    }
}