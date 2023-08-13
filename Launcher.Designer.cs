
namespace PSOBBLauncher
{
    partial class 启动器
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(启动器));
            this.启动游戏按钮 = new System.Windows.Forms.Button();
            this.游戏设置按钮 = new System.Windows.Forms.Button();
            this.注册账号按钮 = new System.Windows.Forms.Button();
            this.游戏信息 = new System.Windows.Forms.WebBrowser();
            this.官方网站按钮 = new System.Windows.Forms.Button();
            this.账号存储控件 = new System.Windows.Forms.ComboBox();
            this.LOGO网址 = new System.Windows.Forms.PictureBox();
            this.账号列表按钮 = new System.Windows.Forms.Button();
            this.语音按钮 = new System.Windows.Forms.PictureBox();
            this.文字提示 = new System.Windows.Forms.ToolTip(this.components);
            this.关闭按钮 = new System.Windows.Forms.PictureBox();
            this.网页信息分页 = new PSOBBLauncher.TabControls.TabControlEx();
            this.游戏新闻 = new System.Windows.Forms.TabPage();
            this.网页信息 = new System.Windows.Forms.WebBrowser();
            this.更新内容 = new System.Windows.Forms.TabPage();
            this.网页信息2 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.LOGO网址)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.语音按钮)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.关闭按钮)).BeginInit();
            this.网页信息分页.SuspendLayout();
            this.游戏新闻.SuspendLayout();
            this.更新内容.SuspendLayout();
            this.SuspendLayout();
            // 
            // 启动游戏按钮
            // 
            this.启动游戏按钮.BackColor = System.Drawing.Color.Transparent;
            this.启动游戏按钮.BackgroundImage = global::PSOBBLauncher.Properties.Resources.button_fw;
            this.启动游戏按钮.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.启动游戏按钮.Cursor = System.Windows.Forms.Cursors.Hand;
            this.启动游戏按钮.FlatAppearance.BorderSize = 0;
            this.启动游戏按钮.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.启动游戏按钮.Location = new System.Drawing.Point(552, 174);
            this.启动游戏按钮.Name = "启动游戏按钮";
            this.启动游戏按钮.Size = new System.Drawing.Size(75, 23);
            this.启动游戏按钮.TabIndex = 2;
            this.启动游戏按钮.Text = "启动游戏";
            this.启动游戏按钮.UseVisualStyleBackColor = false;
            this.启动游戏按钮.Click += new System.EventHandler(this.Start_Game);
            // 
            // 游戏设置按钮
            // 
            this.游戏设置按钮.BackColor = System.Drawing.Color.Transparent;
            this.游戏设置按钮.BackgroundImage = global::PSOBBLauncher.Properties.Resources.button_fw;
            this.游戏设置按钮.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.游戏设置按钮.Cursor = System.Windows.Forms.Cursors.Hand;
            this.游戏设置按钮.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.游戏设置按钮.Location = new System.Drawing.Point(633, 174);
            this.游戏设置按钮.Name = "游戏设置按钮";
            this.游戏设置按钮.Size = new System.Drawing.Size(75, 23);
            this.游戏设置按钮.TabIndex = 3;
            this.游戏设置按钮.Text = "游戏设置";
            this.游戏设置按钮.UseVisualStyleBackColor = false;
            this.游戏设置按钮.Click += new System.EventHandler(this.Setting_Game);
            // 
            // 注册账号按钮
            // 
            this.注册账号按钮.BackColor = System.Drawing.Color.Transparent;
            this.注册账号按钮.BackgroundImage = global::PSOBBLauncher.Properties.Resources.button_fw;
            this.注册账号按钮.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.注册账号按钮.Cursor = System.Windows.Forms.Cursors.Hand;
            this.注册账号按钮.FlatAppearance.BorderSize = 0;
            this.注册账号按钮.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.注册账号按钮.Location = new System.Drawing.Point(573, 4);
            this.注册账号按钮.Name = "注册账号按钮";
            this.注册账号按钮.Size = new System.Drawing.Size(79, 30);
            this.注册账号按钮.TabIndex = 4;
            this.注册账号按钮.Text = "注册账号";
            this.注册账号按钮.UseVisualStyleBackColor = false;
            this.注册账号按钮.Click += new System.EventHandler(this.Web_Reg);
            // 
            // 游戏信息
            // 
            this.游戏信息.Location = new System.Drawing.Point(313, 0);
            this.游戏信息.MinimumSize = new System.Drawing.Size(20, 20);
            this.游戏信息.Name = "游戏信息";
            this.游戏信息.ScrollBarsEnabled = false;
            this.游戏信息.Size = new System.Drawing.Size(169, 37);
            this.游戏信息.TabIndex = 6;
            this.游戏信息.Url = new System.Uri("http://phantasystaronline.cn:88/server/game_info.php", System.UriKind.Absolute);
            this.游戏信息.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.Game_Info);
            // 
            // 官方网站按钮
            // 
            this.官方网站按钮.BackColor = System.Drawing.Color.Transparent;
            this.官方网站按钮.BackgroundImage = global::PSOBBLauncher.Properties.Resources.button_fw;
            this.官方网站按钮.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.官方网站按钮.Cursor = System.Windows.Forms.Cursors.Hand;
            this.官方网站按钮.FlatAppearance.BorderSize = 0;
            this.官方网站按钮.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.官方网站按钮.Location = new System.Drawing.Point(488, 4);
            this.官方网站按钮.Name = "官方网站按钮";
            this.官方网站按钮.Size = new System.Drawing.Size(79, 30);
            this.官方网站按钮.TabIndex = 7;
            this.官方网站按钮.Text = "官方网站";
            this.官方网站按钮.UseVisualStyleBackColor = false;
            this.官方网站按钮.Click += new System.EventHandler(this.Web_Site);
            // 
            // 账号存储控件
            // 
            this.账号存储控件.FormattingEnabled = true;
            this.账号存储控件.Location = new System.Drawing.Point(446, 175);
            this.账号存储控件.Name = "账号存储控件";
            this.账号存储控件.Size = new System.Drawing.Size(100, 20);
            this.账号存储控件.TabIndex = 12;
            this.账号存储控件.SelectedIndexChanged += new System.EventHandler(this.账号存储控件_SelectedIndexChanged);
            // 
            // LOGO网址
            // 
            this.LOGO网址.BackColor = System.Drawing.Color.Transparent;
            this.LOGO网址.Location = new System.Drawing.Point(8, 4);
            this.LOGO网址.Name = "LOGO网址";
            this.LOGO网址.Size = new System.Drawing.Size(258, 57);
            this.LOGO网址.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LOGO网址.TabIndex = 30;
            this.LOGO网址.TabStop = false;
            this.LOGO网址.Click += new System.EventHandler(this.图像设置背景图_Click);
            // 
            // 账号列表按钮
            // 
            this.账号列表按钮.BackColor = System.Drawing.Color.Transparent;
            this.账号列表按钮.BackgroundImage = global::PSOBBLauncher.Properties.Resources.button_fw;
            this.账号列表按钮.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.账号列表按钮.Cursor = System.Windows.Forms.Cursors.Hand;
            this.账号列表按钮.FlatAppearance.BorderSize = 0;
            this.账号列表按钮.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.账号列表按钮.Location = new System.Drawing.Point(365, 175);
            this.账号列表按钮.Name = "账号列表按钮";
            this.账号列表按钮.Size = new System.Drawing.Size(75, 23);
            this.账号列表按钮.TabIndex = 31;
            this.账号列表按钮.Text = "账号列表";
            this.账号列表按钮.UseVisualStyleBackColor = false;
            this.账号列表按钮.Click += new System.EventHandler(this.账号列表按钮_Click);
            // 
            // 语音按钮
            // 
            this.语音按钮.BackColor = System.Drawing.Color.Transparent;
            this.语音按钮.Cursor = System.Windows.Forms.Cursors.Hand;
            this.语音按钮.Image = global::PSOBBLauncher.Properties.Resources.voice_fw;
            this.语音按钮.Location = new System.Drawing.Point(668, 93);
            this.语音按钮.Name = "语音按钮";
            this.语音按钮.Size = new System.Drawing.Size(47, 47);
            this.语音按钮.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.语音按钮.TabIndex = 32;
            this.语音按钮.TabStop = false;
            this.语音按钮.Click += new System.EventHandler(this.语音按钮_Click);
            // 
            // 关闭按钮
            // 
            this.关闭按钮.BackColor = System.Drawing.Color.Transparent;
            this.关闭按钮.Cursor = System.Windows.Forms.Cursors.Hand;
            this.关闭按钮.Image = global::PSOBBLauncher.Properties.Resources.close_red_fw;
            this.关闭按钮.Location = new System.Drawing.Point(682, 4);
            this.关闭按钮.Name = "关闭按钮";
            this.关闭按钮.Size = new System.Drawing.Size(30, 30);
            this.关闭按钮.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.关闭按钮.TabIndex = 33;
            this.关闭按钮.TabStop = false;
            this.关闭按钮.Click += new System.EventHandler(this.关闭按钮_Click);
            // 
            // 网页信息分页
            // 
            this.网页信息分页.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.网页信息分页.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(79)))), ((int)(((byte)(125)))));
            this.网页信息分页.BackColor = System.Drawing.Color.Transparent;
            this.网页信息分页.Controls.Add(this.游戏新闻);
            this.网页信息分页.Controls.Add(this.更新内容);
            this.网页信息分页.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.网页信息分页.Location = new System.Drawing.Point(4, 76);
            this.网页信息分页.Multiline = true;
            this.网页信息分页.Name = "网页信息分页";
            this.网页信息分页.SelectedIndex = 0;
            this.网页信息分页.ShowClose = false;
            this.网页信息分页.Size = new System.Drawing.Size(331, 121);
            this.网页信息分页.TabIndex = 8;
            // 
            // 游戏新闻
            // 
            this.游戏新闻.Controls.Add(this.网页信息);
            this.游戏新闻.Location = new System.Drawing.Point(4, 29);
            this.游戏新闻.Name = "游戏新闻";
            this.游戏新闻.Padding = new System.Windows.Forms.Padding(3);
            this.游戏新闻.Size = new System.Drawing.Size(323, 88);
            this.游戏新闻.TabIndex = 0;
            this.游戏新闻.Text = "游戏新闻";
            this.游戏新闻.UseVisualStyleBackColor = true;
            // 
            // 网页信息
            // 
            this.网页信息.AllowWebBrowserDrop = false;
            this.网页信息.Dock = System.Windows.Forms.DockStyle.Fill;
            this.网页信息.IsWebBrowserContextMenuEnabled = false;
            this.网页信息.Location = new System.Drawing.Point(3, 3);
            this.网页信息.MaximumSize = new System.Drawing.Size(317, 82);
            this.网页信息.MinimumSize = new System.Drawing.Size(317, 82);
            this.网页信息.Name = "网页信息";
            this.网页信息.ScrollBarsEnabled = false;
            this.网页信息.Size = new System.Drawing.Size(317, 82);
            this.网页信息.TabIndex = 0;
            this.网页信息.Url = new System.Uri("http://phantasystaronline.cn:88/server/news.php", System.UriKind.Absolute);
            this.网页信息.WebBrowserShortcutsEnabled = false;
            // 
            // 更新内容
            // 
            this.更新内容.Controls.Add(this.网页信息2);
            this.更新内容.Location = new System.Drawing.Point(4, 29);
            this.更新内容.Name = "更新内容";
            this.更新内容.Padding = new System.Windows.Forms.Padding(3);
            this.更新内容.Size = new System.Drawing.Size(323, 88);
            this.更新内容.TabIndex = 1;
            this.更新内容.Text = "更新内容";
            this.更新内容.UseVisualStyleBackColor = true;
            // 
            // 网页信息2
            // 
            this.网页信息2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.网页信息2.Location = new System.Drawing.Point(3, 3);
            this.网页信息2.MinimumSize = new System.Drawing.Size(20, 20);
            this.网页信息2.Name = "网页信息2";
            this.网页信息2.ScrollBarsEnabled = false;
            this.网页信息2.Size = new System.Drawing.Size(317, 82);
            this.网页信息2.TabIndex = 0;
            this.网页信息2.Url = new System.Uri("http://phantasystaronline.cn:88/server/update.php", System.UriKind.Absolute);
            // 
            // 启动器
            // 
            this.AcceptButton = this.启动游戏按钮;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::PSOBBLauncher.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(720, 200);
            this.ControlBox = false;
            this.Controls.Add(this.关闭按钮);
            this.Controls.Add(this.语音按钮);
            this.Controls.Add(this.账号列表按钮);
            this.Controls.Add(this.LOGO网址);
            this.Controls.Add(this.账号存储控件);
            this.Controls.Add(this.网页信息分页);
            this.Controls.Add(this.官方网站按钮);
            this.Controls.Add(this.游戏信息);
            this.Controls.Add(this.注册账号按钮);
            this.Controls.Add(this.游戏设置按钮);
            this.Controls.Add(this.启动游戏按钮);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(720, 200);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(720, 200);
            this.Name = "启动器";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "梦幻之星 蓝色脉冲 中国服务器";
            this.Load += new System.EventHandler(this.启动器_Load);
            this.Resize += new System.EventHandler(this.启动器_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.LOGO网址)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.语音按钮)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.关闭按钮)).EndInit();
            this.网页信息分页.ResumeLayout(false);
            this.游戏新闻.ResumeLayout(false);
            this.更新内容.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button 启动游戏按钮;
        private System.Windows.Forms.Button 游戏设置按钮;
        private System.Windows.Forms.Button 注册账号按钮;
        private System.Windows.Forms.WebBrowser 游戏信息;
        private System.Windows.Forms.Button 官方网站按钮;
        private System.Windows.Forms.TabPage 游戏新闻;
        private System.Windows.Forms.TabPage 更新内容;
        private System.Windows.Forms.WebBrowser 网页信息;
        private System.Windows.Forms.WebBrowser 网页信息2;
        private TabControls.TabControlEx 网页信息分页;
        private System.Windows.Forms.ComboBox 账号存储控件;
        private System.Windows.Forms.PictureBox LOGO网址;
        private System.Windows.Forms.Button 账号列表按钮;
        private System.Windows.Forms.PictureBox 语音按钮;
        private System.Windows.Forms.ToolTip 文字提示;
        private System.Windows.Forms.PictureBox 关闭按钮;
    }
}

