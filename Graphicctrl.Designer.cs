
namespace PSOBBLauncher
{
    partial class 图像设置窗体
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(图像设置窗体));
            this.关闭图像设置按钮 = new System.Windows.Forms.Button();
            this.自动跳帧控件 = new System.Windows.Forms.ComboBox();
            this.自动跳帧文字 = new System.Windows.Forms.Label();
            this.高精度图像处理控件 = new System.Windows.Forms.CheckBox();
            this.低精度贴图控件 = new System.Windows.Forms.CheckBox();
            this.可变帧率控件 = new System.Windows.Forms.CheckBox();
            this.影子图像设置控件 = new System.Windows.Forms.TrackBar();
            this.敌人图像设置控件 = new System.Windows.Forms.TrackBar();
            this.地形图像设置控件 = new System.Windows.Forms.TrackBar();
            this.视距图像设置控件 = new System.Windows.Forms.TrackBar();
            this.可视距离文字 = new System.Windows.Forms.Label();
            this.影子文字 = new System.Windows.Forms.Label();
            this.敌人文字 = new System.Windows.Forms.Label();
            this.地形文字 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.雾化效果设置控件 = new System.Windows.Forms.ComboBox();
            this.图像设置背景图 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.影子图像设置控件)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.敌人图像设置控件)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.地形图像设置控件)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.视距图像设置控件)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.图像设置背景图)).BeginInit();
            this.SuspendLayout();
            // 
            // 关闭图像设置按钮
            // 
            this.关闭图像设置按钮.Location = new System.Drawing.Point(381, 140);
            this.关闭图像设置按钮.Name = "关闭图像设置按钮";
            this.关闭图像设置按钮.Size = new System.Drawing.Size(75, 23);
            this.关闭图像设置按钮.TabIndex = 4;
            this.关闭图像设置按钮.Text = "关闭";
            this.关闭图像设置按钮.UseVisualStyleBackColor = true;
            this.关闭图像设置按钮.Click += new System.EventHandler(this.关闭设置_Click);
            // 
            // 自动跳帧控件
            // 
            this.自动跳帧控件.FormattingEnabled = true;
            this.自动跳帧控件.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.自动跳帧控件.Location = new System.Drawing.Point(71, 12);
            this.自动跳帧控件.Name = "自动跳帧控件";
            this.自动跳帧控件.Size = new System.Drawing.Size(80, 20);
            this.自动跳帧控件.TabIndex = 6;
            this.自动跳帧控件.SelectedIndexChanged += new System.EventHandler(this.自动跳帧控件_SelectedIndexChanged);
            // 
            // 自动跳帧文字
            // 
            this.自动跳帧文字.AutoSize = true;
            this.自动跳帧文字.Location = new System.Drawing.Point(12, 15);
            this.自动跳帧文字.Name = "自动跳帧文字";
            this.自动跳帧文字.Size = new System.Drawing.Size(53, 12);
            this.自动跳帧文字.TabIndex = 7;
            this.自动跳帧文字.Text = "自动跳帧";
            // 
            // 高精度图像处理控件
            // 
            this.高精度图像处理控件.AutoSize = true;
            this.高精度图像处理控件.Location = new System.Drawing.Point(14, 82);
            this.高精度图像处理控件.Name = "高精度图像处理控件";
            this.高精度图像处理控件.Size = new System.Drawing.Size(108, 16);
            this.高精度图像处理控件.TabIndex = 8;
            this.高精度图像处理控件.Text = "高精度图像处理";
            this.高精度图像处理控件.UseVisualStyleBackColor = true;
            this.高精度图像处理控件.CheckedChanged += new System.EventHandler(this.高精度图像处理控件_CheckedChanged);
            // 
            // 低精度贴图控件
            // 
            this.低精度贴图控件.AutoSize = true;
            this.低精度贴图控件.Location = new System.Drawing.Point(14, 60);
            this.低精度贴图控件.Name = "低精度贴图控件";
            this.低精度贴图控件.Size = new System.Drawing.Size(84, 16);
            this.低精度贴图控件.TabIndex = 9;
            this.低精度贴图控件.Text = "低精度贴图";
            this.低精度贴图控件.UseVisualStyleBackColor = true;
            this.低精度贴图控件.CheckedChanged += new System.EventHandler(this.低精度贴图控件_CheckedChanged);
            // 
            // 可变帧率控件
            // 
            this.可变帧率控件.AutoSize = true;
            this.可变帧率控件.Location = new System.Drawing.Point(14, 38);
            this.可变帧率控件.Name = "可变帧率控件";
            this.可变帧率控件.Size = new System.Drawing.Size(72, 16);
            this.可变帧率控件.TabIndex = 10;
            this.可变帧率控件.Text = "可变帧率";
            this.可变帧率控件.UseVisualStyleBackColor = true;
            this.可变帧率控件.CheckedChanged += new System.EventHandler(this.可变帧率控件_CheckedChanged);
            // 
            // 影子图像设置控件
            // 
            this.影子图像设置控件.LargeChange = 1;
            this.影子图像设置控件.Location = new System.Drawing.Point(220, 15);
            this.影子图像设置控件.Maximum = 2;
            this.影子图像设置控件.Name = "影子图像设置控件";
            this.影子图像设置控件.Size = new System.Drawing.Size(104, 45);
            this.影子图像设置控件.TabIndex = 11;
            this.影子图像设置控件.Scroll += new System.EventHandler(this.影子图像设置控件_Scroll);
            // 
            // 敌人图像设置控件
            // 
            this.敌人图像设置控件.LargeChange = 1;
            this.敌人图像设置控件.Location = new System.Drawing.Point(220, 62);
            this.敌人图像设置控件.Maximum = 1;
            this.敌人图像设置控件.Name = "敌人图像设置控件";
            this.敌人图像设置控件.Size = new System.Drawing.Size(104, 45);
            this.敌人图像设置控件.TabIndex = 12;
            this.敌人图像设置控件.Scroll += new System.EventHandler(this.敌人图像设置控件_Scroll);
            // 
            // 地形图像设置控件
            // 
            this.地形图像设置控件.LargeChange = 1;
            this.地形图像设置控件.Location = new System.Drawing.Point(220, 113);
            this.地形图像设置控件.Maximum = 2;
            this.地形图像设置控件.Name = "地形图像设置控件";
            this.地形图像设置控件.Size = new System.Drawing.Size(104, 45);
            this.地形图像设置控件.TabIndex = 13;
            this.地形图像设置控件.Scroll += new System.EventHandler(this.地形图像设置控件_Scroll);
            // 
            // 视距图像设置控件
            // 
            this.视距图像设置控件.LargeChange = 1;
            this.视距图像设置控件.Location = new System.Drawing.Point(71, 104);
            this.视距图像设置控件.Maximum = 2;
            this.视距图像设置控件.Name = "视距图像设置控件";
            this.视距图像设置控件.Size = new System.Drawing.Size(80, 45);
            this.视距图像设置控件.TabIndex = 14;
            this.视距图像设置控件.Scroll += new System.EventHandler(this.视距图像设置控件_Scroll);
            // 
            // 可视距离文字
            // 
            this.可视距离文字.AutoSize = true;
            this.可视距离文字.Location = new System.Drawing.Point(12, 113);
            this.可视距离文字.Name = "可视距离文字";
            this.可视距离文字.Size = new System.Drawing.Size(53, 12);
            this.可视距离文字.TabIndex = 15;
            this.可视距离文字.Text = "可视距离";
            // 
            // 影子文字
            // 
            this.影子文字.AutoSize = true;
            this.影子文字.Location = new System.Drawing.Point(185, 20);
            this.影子文字.Name = "影子文字";
            this.影子文字.Size = new System.Drawing.Size(29, 12);
            this.影子文字.TabIndex = 16;
            this.影子文字.Text = "影子";
            // 
            // 敌人文字
            // 
            this.敌人文字.AutoSize = true;
            this.敌人文字.Location = new System.Drawing.Point(185, 64);
            this.敌人文字.Name = "敌人文字";
            this.敌人文字.Size = new System.Drawing.Size(29, 12);
            this.敌人文字.TabIndex = 17;
            this.敌人文字.Text = "敌人";
            // 
            // 地形文字
            // 
            this.地形文字.AutoSize = true;
            this.地形文字.Location = new System.Drawing.Point(185, 117);
            this.地形文字.Name = "地形文字";
            this.地形文字.Size = new System.Drawing.Size(29, 12);
            this.地形文字.TabIndex = 18;
            this.地形文字.Text = "地形";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 19;
            this.label4.Text = "雾化效果";
            // 
            // 雾化效果设置控件
            // 
            this.雾化效果设置控件.FormattingEnabled = true;
            this.雾化效果设置控件.Items.AddRange(new object[] {
            "顶点雾",
            "点状雾",
            "雾状模拟"});
            this.雾化效果设置控件.Location = new System.Drawing.Point(71, 137);
            this.雾化效果设置控件.Name = "雾化效果设置控件";
            this.雾化效果设置控件.Size = new System.Drawing.Size(80, 20);
            this.雾化效果设置控件.TabIndex = 20;
            this.雾化效果设置控件.SelectedIndexChanged += new System.EventHandler(this.雾化效果设置控件_SelectedIndexChanged);
            // 
            // 图像设置背景图
            // 
            this.图像设置背景图.Image = global::PSOBBLauncher.Properties.Resources.bg2_fw;
            this.图像设置背景图.Location = new System.Drawing.Point(357, 9);
            this.图像设置背景图.Name = "图像设置背景图";
            this.图像设置背景图.Size = new System.Drawing.Size(121, 120);
            this.图像设置背景图.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.图像设置背景图.TabIndex = 21;
            this.图像设置背景图.TabStop = false;
            this.图像设置背景图.Click += new System.EventHandler(this.图像设置背景图_Click);
            // 
            // 图像设置窗体
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(500, 170);
            this.ControlBox = false;
            this.Controls.Add(this.图像设置背景图);
            this.Controls.Add(this.雾化效果设置控件);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.地形文字);
            this.Controls.Add(this.敌人文字);
            this.Controls.Add(this.影子文字);
            this.Controls.Add(this.可视距离文字);
            this.Controls.Add(this.视距图像设置控件);
            this.Controls.Add(this.地形图像设置控件);
            this.Controls.Add(this.敌人图像设置控件);
            this.Controls.Add(this.影子图像设置控件);
            this.Controls.Add(this.可变帧率控件);
            this.Controls.Add(this.低精度贴图控件);
            this.Controls.Add(this.高精度图像处理控件);
            this.Controls.Add(this.自动跳帧文字);
            this.Controls.Add(this.自动跳帧控件);
            this.Controls.Add(this.关闭图像设置按钮);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "图像设置窗体";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "图像设置";
            this.Load += new System.EventHandler(this.图像设置窗体_Load);
            ((System.ComponentModel.ISupportInitialize)(this.影子图像设置控件)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.敌人图像设置控件)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.地形图像设置控件)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.视距图像设置控件)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.图像设置背景图)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button 关闭图像设置按钮;
        private System.Windows.Forms.ComboBox 自动跳帧控件;
        private System.Windows.Forms.Label 自动跳帧文字;
        private System.Windows.Forms.CheckBox 高精度图像处理控件;
        private System.Windows.Forms.CheckBox 低精度贴图控件;
        private System.Windows.Forms.CheckBox 可变帧率控件;
        private System.Windows.Forms.TrackBar 影子图像设置控件;
        private System.Windows.Forms.TrackBar 敌人图像设置控件;
        private System.Windows.Forms.TrackBar 地形图像设置控件;
        private System.Windows.Forms.TrackBar 视距图像设置控件;
        private System.Windows.Forms.Label 可视距离文字;
        private System.Windows.Forms.Label 影子文字;
        private System.Windows.Forms.Label 敌人文字;
        private System.Windows.Forms.Label 地形文字;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox 雾化效果设置控件;
        private System.Windows.Forms.PictureBox 图像设置背景图;
    }
}