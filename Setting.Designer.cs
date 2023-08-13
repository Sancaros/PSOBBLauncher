
namespace PSOBBLauncher
{
    partial class 游戏设置
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(游戏设置));
            this.高清功能控件 = new System.Windows.Forms.CheckBox();
            this.默认设置 = new System.Windows.Forms.Button();
            this.分辨率控件 = new System.Windows.Forms.ComboBox();
            this.分辨率文字 = new System.Windows.Forms.Label();
            this.窗口模式控件 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.颜色位控件 = new System.Windows.Forms.ComboBox();
            this.保存账号控件 = new System.Windows.Forms.CheckBox();
            this.自动断句控件 = new System.Windows.Forms.CheckBox();
            this.图像设置中配置 = new System.Windows.Forms.CheckBox();
            this.关闭设置 = new System.Windows.Forms.Button();
            this.后台音乐控件 = new System.Windows.Forms.CheckBox();
            this.音量文字 = new System.Windows.Forms.Label();
            this.音调文字 = new System.Windows.Forms.Label();
            this.音量控件 = new System.Windows.Forms.TrackBar();
            this.音调控件 = new System.Windows.Forms.TrackBar();
            this.同步刷新控件 = new System.Windows.Forms.CheckBox();
            this.图像设置高配置 = new System.Windows.Forms.CheckBox();
            this.图像设置低配置 = new System.Windows.Forms.CheckBox();
            this.声音开关控件 = new System.Windows.Forms.CheckBox();
            this.字体控件 = new System.Windows.Forms.ComboBox();
            this.字体文字 = new System.Windows.Forms.Label();
            this.背景音乐控件 = new System.Windows.Forms.CheckBox();
            this.音效开关控件 = new System.Windows.Forms.CheckBox();
            this.自定义图像按钮 = new System.Windows.Forms.Button();
            this.图像设置背景图 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.音量控件)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.音调控件)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.图像设置背景图)).BeginInit();
            this.SuspendLayout();
            // 
            // 高清功能控件
            // 
            this.高清功能控件.AutoSize = true;
            this.高清功能控件.Location = new System.Drawing.Point(156, 32);
            this.高清功能控件.Name = "高清功能控件";
            this.高清功能控件.Size = new System.Drawing.Size(72, 16);
            this.高清功能控件.TabIndex = 1;
            this.高清功能控件.Text = "高清功能";
            this.高清功能控件.UseVisualStyleBackColor = true;
            this.高清功能控件.CheckedChanged += new System.EventHandler(this.高清功能_CheckedChanged);
            // 
            // 默认设置
            // 
            this.默认设置.Location = new System.Drawing.Point(332, 141);
            this.默认设置.Name = "默认设置";
            this.默认设置.Size = new System.Drawing.Size(75, 23);
            this.默认设置.TabIndex = 4;
            this.默认设置.Text = "默认";
            this.默认设置.UseVisualStyleBackColor = true;
            this.默认设置.Click += new System.EventHandler(this.默认设置_Click);
            // 
            // 分辨率控件
            // 
            this.分辨率控件.FormattingEnabled = true;
            this.分辨率控件.Items.AddRange(new object[] {
            "640x480",
            "800x600",
            "1024x768",
            "1280x960",
            "1280x1024",
            "1280x720",
            "1366x768",
            "1600x900",
            "1920x1080"});
            this.分辨率控件.Location = new System.Drawing.Point(60, 10);
            this.分辨率控件.Name = "分辨率控件";
            this.分辨率控件.Size = new System.Drawing.Size(78, 20);
            this.分辨率控件.TabIndex = 5;
            this.分辨率控件.SelectedIndexChanged += new System.EventHandler(this.分辨率控件_SelectedIndexChanged);
            // 
            // 分辨率文字
            // 
            this.分辨率文字.AutoSize = true;
            this.分辨率文字.Location = new System.Drawing.Point(13, 13);
            this.分辨率文字.Name = "分辨率文字";
            this.分辨率文字.Size = new System.Drawing.Size(41, 12);
            this.分辨率文字.TabIndex = 6;
            this.分辨率文字.Text = "分辨率";
            // 
            // 窗口模式控件
            // 
            this.窗口模式控件.AutoSize = true;
            this.窗口模式控件.Location = new System.Drawing.Point(156, 9);
            this.窗口模式控件.Name = "窗口模式控件";
            this.窗口模式控件.Size = new System.Drawing.Size(72, 16);
            this.窗口模式控件.TabIndex = 7;
            this.窗口模式控件.Text = "窗口模式";
            this.窗口模式控件.UseVisualStyleBackColor = true;
            this.窗口模式控件.CheckedChanged += new System.EventHandler(this.窗口模式控件_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "颜色位";
            // 
            // 颜色位控件
            // 
            this.颜色位控件.DisplayMember = "Graphics";
            this.颜色位控件.FormattingEnabled = true;
            this.颜色位控件.Items.AddRange(new object[] {
            "16位",
            "32位"});
            this.颜色位控件.Location = new System.Drawing.Point(60, 43);
            this.颜色位控件.Name = "颜色位控件";
            this.颜色位控件.Size = new System.Drawing.Size(78, 20);
            this.颜色位控件.TabIndex = 10;
            this.颜色位控件.ValueMember = "Graphics";
            this.颜色位控件.SelectedIndexChanged += new System.EventHandler(this.颜色位控件_SelectedIndexChanged);
            // 
            // 保存账号控件
            // 
            this.保存账号控件.AutoSize = true;
            this.保存账号控件.Location = new System.Drawing.Point(156, 146);
            this.保存账号控件.Name = "保存账号控件";
            this.保存账号控件.Size = new System.Drawing.Size(72, 16);
            this.保存账号控件.TabIndex = 11;
            this.保存账号控件.Text = "保存账号";
            this.保存账号控件.UseVisualStyleBackColor = true;
            this.保存账号控件.CheckedChanged += new System.EventHandler(this.保存账号控件_CheckedChanged);
            // 
            // 自动断句控件
            // 
            this.自动断句控件.AutoSize = true;
            this.自动断句控件.Location = new System.Drawing.Point(15, 127);
            this.自动断句控件.Name = "自动断句控件";
            this.自动断句控件.Size = new System.Drawing.Size(72, 16);
            this.自动断句控件.TabIndex = 12;
            this.自动断句控件.Text = "自动断句";
            this.自动断句控件.UseVisualStyleBackColor = true;
            this.自动断句控件.CheckedChanged += new System.EventHandler(this.自动断句控件_CheckedChanged);
            // 
            // 图像设置中配置
            // 
            this.图像设置中配置.AutoSize = true;
            this.图像设置中配置.Location = new System.Drawing.Point(83, 76);
            this.图像设置中配置.Name = "图像设置中配置";
            this.图像设置中配置.Size = new System.Drawing.Size(60, 16);
            this.图像设置中配置.TabIndex = 13;
            this.图像设置中配置.Text = "中配置";
            this.图像设置中配置.UseVisualStyleBackColor = true;
            this.图像设置中配置.CheckedChanged += new System.EventHandler(this.图像设置中配置_CheckedChanged);
            // 
            // 关闭设置
            // 
            this.关闭设置.Location = new System.Drawing.Point(417, 141);
            this.关闭设置.Name = "关闭设置";
            this.关闭设置.Size = new System.Drawing.Size(75, 23);
            this.关闭设置.TabIndex = 3;
            this.关闭设置.Text = "关闭";
            this.关闭设置.UseVisualStyleBackColor = true;
            this.关闭设置.Click += new System.EventHandler(this.关闭设置_Click);
            // 
            // 后台音乐控件
            // 
            this.后台音乐控件.AutoSize = true;
            this.后台音乐控件.Location = new System.Drawing.Point(270, 72);
            this.后台音乐控件.Name = "后台音乐控件";
            this.后台音乐控件.Size = new System.Drawing.Size(72, 16);
            this.后台音乐控件.TabIndex = 14;
            this.后台音乐控件.Text = "后台音乐";
            this.后台音乐控件.UseVisualStyleBackColor = true;
            this.后台音乐控件.CheckedChanged += new System.EventHandler(this.背景音乐控件_CheckedChanged);
            // 
            // 音量文字
            // 
            this.音量文字.AutoSize = true;
            this.音量文字.Location = new System.Drawing.Point(268, 13);
            this.音量文字.Name = "音量文字";
            this.音量文字.Size = new System.Drawing.Size(29, 12);
            this.音量文字.TabIndex = 15;
            this.音量文字.Text = "音量";
            // 
            // 音调文字
            // 
            this.音调文字.AutoSize = true;
            this.音调文字.Location = new System.Drawing.Point(268, 46);
            this.音调文字.Name = "音调文字";
            this.音调文字.Size = new System.Drawing.Size(29, 12);
            this.音调文字.TabIndex = 16;
            this.音调文字.Text = "音调";
            // 
            // 音量控件
            // 
            this.音量控件.Location = new System.Drawing.Point(303, 10);
            this.音量控件.Name = "音量控件";
            this.音量控件.Size = new System.Drawing.Size(104, 45);
            this.音量控件.TabIndex = 17;
            this.音量控件.Scroll += new System.EventHandler(this.音量控件_Scroll);
            // 
            // 音调控件
            // 
            this.音调控件.Location = new System.Drawing.Point(303, 43);
            this.音调控件.Name = "音调控件";
            this.音调控件.Size = new System.Drawing.Size(104, 45);
            this.音调控件.TabIndex = 18;
            this.音调控件.Scroll += new System.EventHandler(this.音调控件_Scroll);
            // 
            // 同步刷新控件
            // 
            this.同步刷新控件.AutoSize = true;
            this.同步刷新控件.Location = new System.Drawing.Point(156, 54);
            this.同步刷新控件.Name = "同步刷新控件";
            this.同步刷新控件.Size = new System.Drawing.Size(72, 16);
            this.同步刷新控件.TabIndex = 19;
            this.同步刷新控件.Text = "同步刷新";
            this.同步刷新控件.UseVisualStyleBackColor = true;
            this.同步刷新控件.CheckedChanged += new System.EventHandler(this.同步刷新控件_CheckedChanged);
            // 
            // 图像设置高配置
            // 
            this.图像设置高配置.AutoSize = true;
            this.图像设置高配置.Location = new System.Drawing.Point(15, 76);
            this.图像设置高配置.Name = "图像设置高配置";
            this.图像设置高配置.Size = new System.Drawing.Size(60, 16);
            this.图像设置高配置.TabIndex = 20;
            this.图像设置高配置.Text = "高配置";
            this.图像设置高配置.UseVisualStyleBackColor = true;
            this.图像设置高配置.CheckedChanged += new System.EventHandler(this.图像设置高配置_CheckedChanged);
            // 
            // 图像设置低配置
            // 
            this.图像设置低配置.AutoSize = true;
            this.图像设置低配置.Location = new System.Drawing.Point(156, 76);
            this.图像设置低配置.Name = "图像设置低配置";
            this.图像设置低配置.Size = new System.Drawing.Size(60, 16);
            this.图像设置低配置.TabIndex = 21;
            this.图像设置低配置.Text = "低配置";
            this.图像设置低配置.UseVisualStyleBackColor = true;
            this.图像设置低配置.CheckedChanged += new System.EventHandler(this.图像设置低配置_CheckedChanged);
            // 
            // 声音开关控件
            // 
            this.声音开关控件.AutoSize = true;
            this.声音开关控件.Location = new System.Drawing.Point(420, 10);
            this.声音开关控件.Name = "声音开关控件";
            this.声音开关控件.Size = new System.Drawing.Size(72, 16);
            this.声音开关控件.TabIndex = 22;
            this.声音开关控件.Text = "声音开关";
            this.声音开关控件.UseVisualStyleBackColor = true;
            this.声音开关控件.CheckedChanged += new System.EventHandler(this.声音开关控件_CheckedChanged);
            // 
            // 字体控件
            // 
            this.字体控件.BackColor = System.Drawing.SystemColors.Control;
            this.字体控件.FormattingEnabled = true;
            this.字体控件.Items.AddRange(new object[] {
            "System"});
            this.字体控件.Location = new System.Drawing.Point(48, 144);
            this.字体控件.Name = "字体控件";
            this.字体控件.Size = new System.Drawing.Size(78, 20);
            this.字体控件.TabIndex = 23;
            this.字体控件.SelectedIndexChanged += new System.EventHandler(this.字体控件_SelectedIndexChanged);
            // 
            // 字体文字
            // 
            this.字体文字.AutoSize = true;
            this.字体文字.Location = new System.Drawing.Point(13, 147);
            this.字体文字.Name = "字体文字";
            this.字体文字.Size = new System.Drawing.Size(29, 12);
            this.字体文字.TabIndex = 24;
            this.字体文字.Text = "字体";
            // 
            // 背景音乐控件
            // 
            this.背景音乐控件.AutoSize = true;
            this.背景音乐控件.Location = new System.Drawing.Point(420, 32);
            this.背景音乐控件.Name = "背景音乐控件";
            this.背景音乐控件.Size = new System.Drawing.Size(72, 16);
            this.背景音乐控件.TabIndex = 26;
            this.背景音乐控件.Text = "背景音乐";
            this.背景音乐控件.UseVisualStyleBackColor = true;
            this.背景音乐控件.CheckedChanged += new System.EventHandler(this.背景音乐控件_CheckedChanged_1);
            // 
            // 音效开关控件
            // 
            this.音效开关控件.AutoSize = true;
            this.音效开关控件.Location = new System.Drawing.Point(420, 54);
            this.音效开关控件.Name = "音效开关控件";
            this.音效开关控件.Size = new System.Drawing.Size(72, 16);
            this.音效开关控件.TabIndex = 27;
            this.音效开关控件.Text = "音效开关";
            this.音效开关控件.UseVisualStyleBackColor = true;
            this.音效开关控件.CheckedChanged += new System.EventHandler(this.音效开关控件_CheckedChanged);
            // 
            // 自定义图像按钮
            // 
            this.自定义图像按钮.Location = new System.Drawing.Point(15, 98);
            this.自定义图像按钮.Name = "自定义图像按钮";
            this.自定义图像按钮.Size = new System.Drawing.Size(75, 23);
            this.自定义图像按钮.TabIndex = 28;
            this.自定义图像按钮.Text = "自定义图像";
            this.自定义图像按钮.UseVisualStyleBackColor = true;
            this.自定义图像按钮.Click += new System.EventHandler(this.自定义图像按钮_Click);
            // 
            // 图像设置背景图
            // 
            this.图像设置背景图.BackColor = System.Drawing.Color.Transparent;
            this.图像设置背景图.Image = global::PSOBBLauncher.Properties.Resources.navbg_fw;
            this.图像设置背景图.Location = new System.Drawing.Point(419, 72);
            this.图像设置背景图.Name = "图像设置背景图";
            this.图像设置背景图.Size = new System.Drawing.Size(69, 65);
            this.图像设置背景图.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.图像设置背景图.TabIndex = 29;
            this.图像设置背景图.TabStop = false;
            this.图像设置背景图.Click += new System.EventHandler(this.图像设置背景图_Click);
            // 
            // 游戏设置
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 170);
            this.ControlBox = false;
            this.Controls.Add(this.自定义图像按钮);
            this.Controls.Add(this.后台音乐控件);
            this.Controls.Add(this.音效开关控件);
            this.Controls.Add(this.背景音乐控件);
            this.Controls.Add(this.保存账号控件);
            this.Controls.Add(this.字体文字);
            this.Controls.Add(this.字体控件);
            this.Controls.Add(this.声音开关控件);
            this.Controls.Add(this.图像设置低配置);
            this.Controls.Add(this.图像设置高配置);
            this.Controls.Add(this.同步刷新控件);
            this.Controls.Add(this.音调控件);
            this.Controls.Add(this.音量控件);
            this.Controls.Add(this.音调文字);
            this.Controls.Add(this.音量文字);
            this.Controls.Add(this.图像设置中配置);
            this.Controls.Add(this.自动断句控件);
            this.Controls.Add(this.颜色位控件);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.窗口模式控件);
            this.Controls.Add(this.分辨率文字);
            this.Controls.Add(this.分辨率控件);
            this.Controls.Add(this.默认设置);
            this.Controls.Add(this.关闭设置);
            this.Controls.Add(this.高清功能控件);
            this.Controls.Add(this.图像设置背景图);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "游戏设置";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "游戏设置";
            ((System.ComponentModel.ISupportInitialize)(this.音量控件)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.音调控件)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.图像设置背景图)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox 高清功能控件;
        private System.Windows.Forms.Button 默认设置;
        private System.Windows.Forms.Label 分辨率文字;
        private System.Windows.Forms.CheckBox 窗口模式控件;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox 颜色位控件;
        private System.Windows.Forms.CheckBox 保存账号控件;
        private System.Windows.Forms.CheckBox 自动断句控件;
        private System.Windows.Forms.CheckBox 图像设置中配置;
        public System.Windows.Forms.ComboBox 分辨率控件;
        private System.Windows.Forms.Button 关闭设置;
        private System.Windows.Forms.CheckBox 后台音乐控件;
        private System.Windows.Forms.Label 音量文字;
        private System.Windows.Forms.Label 音调文字;
        private System.Windows.Forms.TrackBar 音量控件;
        private System.Windows.Forms.TrackBar 音调控件;
        private System.Windows.Forms.CheckBox 同步刷新控件;
        private System.Windows.Forms.CheckBox 图像设置高配置;
        private System.Windows.Forms.CheckBox 图像设置低配置;
        private System.Windows.Forms.CheckBox 声音开关控件;
        private System.Windows.Forms.ComboBox 字体控件;
        private System.Windows.Forms.Label 字体文字;
        private System.Windows.Forms.CheckBox 背景音乐控件;
        private System.Windows.Forms.CheckBox 音效开关控件;
        private System.Windows.Forms.Button 自定义图像按钮;
        private System.Windows.Forms.PictureBox 图像设置背景图;
    }
}