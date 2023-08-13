using System;
using System.Security.Permissions;
using Microsoft.Win32;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using ToolUtils;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Drawing.Drawing2D;
using ConvertTo_;

namespace PSOBBLauncher
{
    public partial class 启动器 : Form
    {
        readonly string APPversion = Application.ProductVersion.ToString();
        readonly string PSOBBRegpath = @"Software\SonicTeam\PSOBB";
        readonly string ACCOUNT_Regkey = "ACCOUNT"; //REG_SZ
        readonly string ACCOUNT_SEL_Regkey = "ACCOUNT_SEL"; //REG_DWORD
        readonly string ACCOUNTS_Regkey = "ACCOUNTS"; //REG_MULTI_SZ
        readonly string Password_Regkey = "Password";
        readonly string PASSWORDS_Regkey = "PASSWORDS";
        readonly string UpdateADDRESS_Regkey = "UpdateADDRESS";
        readonly string WEBSITE_OFFICIAL_Regkey = "WEBSITE_OFFICIAL";
        readonly string WEBSITE_REG_Regkey = "WEBSITE_REG";

        public string[] UpdateAPP;
        public string[] WebAddress;

        /// <summary>
        /// 从txt文件中得到项目名称，再显示到comboBox上
        /// </summary>
        private string[] ConvertTxtToDataSet(string filepath)
        {
            WebClient wc = new();
            try
            {
                Stream str = wc.OpenRead(filepath);
                string ReadLine;
                string[] values = new string[256];
                int i = 0;
                StreamReader reader = new(str, Encoding.GetEncoding("GB2312"));
                while (reader.Peek() >= 0)
                {
                    try
                    {
                        ReadLine = reader.ReadLine();
                        if (ReadLine != "")
                        {
                            values[i] = ReadLine.Replace("\"", "");
                            //values = ReadLine.Split(',');
                            if (values.Length == 0)
                            {
                                MessageBox.Show("数据有误，请重试！");
                                return null;
                            }
                            i++;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                return values;
            }
            catch (WebException exp)
            {
                WebResponse wr = exp.Response;
                StreamReader esr = new(wr.GetResponseStream(), Encoding.Default);
                //log.Error("error", new Exception("发生了一个异常"));
                WriteLog.Log("启动器更新错误", string.Format("更新失败 {0}!", esr.ReadToEnd()));
                MessageBox.Show("无法获取更新文件,程序即将关闭！", "发生错误");
                Application.Exit();
                esr.Close();
                return null;
            }
        }

        public bool Check_APP_Update()
        {
            string upd_address = RegUtil.GetRegistryValue(PSOBBRegpath, UpdateADDRESS_Regkey);
            UpdateAPP = ConvertTxtToDataSet(upd_address + "version.txt");
            if (UpdateAPP == null)
            {
                Application.Exit();
                return false;
            }
            else
                if (UpdateAPP[0] != APPversion)
            {
                DialogResult result = MessageBox.Show("请点击确认前往下载", string.Format("检测到新版本 {0}", APPversion), MessageBoxButtons.OK, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    Process.Start(UpdateAPP[1]);
                    Application.Exit();
                    Close();
                    return true;
                }
            }
            return false;
        }

        /// <summary>  
        /// 执行注册表导入  
        /// </summary>  
        /// <param name="regPath">注册表文件路径</param>  
        public void ExecuteReg(string regPath)
        {
            if (File.Exists(regPath))
            {
                regPath = @"""" + regPath + @"""";
                Process.Start("regedit", string.Format(" /s {0}", regPath));
            }
        }

        private byte[] GetRegistryBytes(string Regpath, string Regkey)
        {
            RegistryKey driverKey = Registry.CurrentUser.OpenSubKey(Regpath);
            byte[] temparray = (byte[])driverKey.GetValue(Regkey);
            return temparray;
        }

        public void Check_Update()
        {
            更新程序 update = new();
            update.FormClosing += 更新程序_FormClosing;//主窗体里订阅子窗体关闭事件
            update.ShowDialog();
        }

        public void Check_Reg()
        {
            string var1 = RegUtil.GetRegistryValue(PSOBBRegpath, ACCOUNT_Regkey);
            string[] var2 = (string[])Registry.CurrentUser.OpenSubKey(PSOBBRegpath, true).GetValue(ACCOUNTS_Regkey);
            if (var2 != null)
            {
                //int account_select_index = int.Parse(RegUtil.GetRegistryValue(PSOBBRegpath, ACCOUNT_SEL_Regkey));
                int i = 0;
                for (; i < var2.Length; i++)
                {
                    if (var2[i] != null)
                    {
                        账号存储控件.Items.Add(var2[i]);
                    }
                }
                账号存储控件.SelectedIndex = int.Parse(RegUtil.GetRegistryValue(PSOBBRegpath, ACCOUNT_SEL_Regkey));
                if (i == var2.Length)
                {
                    //MessageBox.Show(string.Format("键值 {0} == {1}", var1, var2pass[账号存储控件.SelectedIndex]));
                    if (var1 == Convert.ToString(账号存储控件.SelectedItem))
                    {
                        string[] var2pass = (string[])Registry.CurrentUser.OpenSubKey(PSOBBRegpath, true).GetValue(PASSWORDS_Regkey);
                        string pass = BACv.ByteArrayToHexString(GetRegistryBytes(PSOBBRegpath, Password_Regkey));
                        if (pass == string.Empty)
                        {
                            var2pass[账号存储控件.SelectedIndex] = "空";
                        }
                        else
                        {
                            var2pass[账号存储控件.SelectedIndex] = pass;
                        }
                        Registry.SetValue("HKEY_CURRENT_USER\\" + PSOBBRegpath, PASSWORDS_Regkey, var2pass, RegistryValueKind.MultiString);
                    }
                }
            }
        }

        public 启动器()
        {
            if (!Check_APP_Update())
                Check_Update();
        }

        private void 更新程序_FormClosing(object sender, FormClosingEventArgs e)
        {
            InitializeComponent();
            Check_Reg();
            文字提示.SetToolTip(LOGO网址, "梦幻之星 中国服务器");
            文字提示.SetToolTip(启动游戏按钮, "启动梦幻之星");
            文字提示.SetToolTip(语音按钮, "进入语音频道");
            文字提示.SetToolTip(账号列表按钮, "打开账号列表");
            文字提示.SetToolTip(游戏设置按钮, "打开游戏设置");
            文字提示.SetToolTip(官方网站按钮, "进入官网");
            文字提示.SetToolTip(注册账号按钮, "注册游戏账号");
            文字提示.SetToolTip(关闭按钮, "关闭启动器");
        }

        private void 账号清单_FormClosing(object sender, FormClosingEventArgs e)
        {
            string[] var2 = (string[])Registry.CurrentUser.OpenSubKey(PSOBBRegpath, true).GetValue(ACCOUNTS_Regkey);
            账号存储控件.Items.Clear();
            int i = 0;
            for (; i < var2.Length; i++)
            {
                if (var2[i] != null)
                {
                    账号存储控件.Items.Add(var2[i]);
                }
            }
            账号存储控件.SelectedIndex = int.Parse(RegUtil.GetRegistryValue(PSOBBRegpath, ACCOUNT_SEL_Regkey));
            //进行主窗体的更新
            //MessageBox.Show("子窗体已经关闭");
        }

        private void 启动器_Load(object sender, EventArgs e)
        {
            网页信息.Focus();
            网页信息2.Focus();
        }

        private void Start_Game(object sender, EventArgs e)
        {
            Process.Start(@"psobb.exe");
        }

        private void Setting_Game(object sender, EventArgs e)
        {
            using 游戏设置 dlg = new(); //caozuo是窗口类名，确保访问；后面的是构造函数
            dlg.ShowDialog();
        }

        private void Web_Site(object sender, EventArgs e)
        {
            Process.Start(RegUtil.GetRegistryValue(PSOBBRegpath, WEBSITE_OFFICIAL_Regkey));
        }

        private void Web_Reg(object sender, EventArgs e)
        {
            Process.Start(RegUtil.GetRegistryValue(PSOBBRegpath, WEBSITE_REG_Regkey));
        }

        private void Game_Info(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        internal static int WM_NCHITTEST = 0x84;
        internal static IntPtr HTCLIENT = (IntPtr)0x1;
        internal static IntPtr HTCAPTION = (IntPtr)0x2;
        internal static int WM_NCLBUTTONDBLCLK = 0x00A3;
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_NCLBUTTONDBLCLK)
            {
                return;
            }
            if (m.Msg == WM_NCHITTEST)
            {
                base.WndProc(ref m);
                if (m.Result == HTCLIENT)
                {
                    m.HWnd = Handle;
                    m.Result = HTCAPTION;
                }
                return;
            }
            base.WndProc(ref m);
        }

        private void 账号存储控件_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToString(账号存储控件.SelectedItem) == "空")
            {
                RegUtil.SetRegistryKey("HKEY_CURRENT_USER", PSOBBRegpath, ACCOUNT_Regkey, "", RegistryValueKind.String);
            }
            else
            {
                RegUtil.SetRegistryKey("HKEY_CURRENT_USER", PSOBBRegpath, ACCOUNT_Regkey, Convert.ToString(账号存储控件.SelectedItem), RegistryValueKind.String);
            }
            RegUtil.SetRegistryKey("HKEY_CURRENT_USER", PSOBBRegpath, ACCOUNT_SEL_Regkey, Convert.ToString(账号存储控件.SelectedIndex), RegistryValueKind.DWord);
            //byte[] array = GetRegistryBytes(PSOBBRegpath, PASSWORDS_Regkey);
            //string pass = Convert.ToString(array[账号存储控件.SelectedIndex]);
            //Registry.SetValue("HKEY_CURRENT_USER\\" + PSOBBRegpath, Password_Regkey, Convert.ToByte(pass), RegistryValueKind.Binary);
        }

        private void 图像设置背景图_Click(object sender, EventArgs e)
        {
            Process.Start(RegUtil.GetRegistryValue(PSOBBRegpath, WEBSITE_OFFICIAL_Regkey));
        }

        private void 账号列表按钮_Click(object sender, EventArgs e)
        {
            账号清单 frm = new();
            frm.FormClosing += 账号清单_FormClosing;//主窗体里订阅子窗体关闭事件
            frm.ShowDialog();
        }

        /// <summary>
        /// 设置窗体的Region
        /// </summary>
        public void SetWindowRegion()
        {
            GraphicsPath FormPath;
            Rectangle rect = new(0, 0, Width, Height);
            FormPath = GetRoundedRectPath(rect, 10);
            Region = new Region(FormPath);

        }
        /// <summary>
        /// 绘制圆角路径
        /// </summary>
        /// <param name="rect"></param>
        /// <param name="radius"></param>
        /// <returns></returns>
        private GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
        {
            int diameter = radius;
            Rectangle arcRect = new(rect.Location, new Size(diameter, diameter));
            GraphicsPath path = new();

            // 左上角
            path.AddArc(arcRect, 180, 90);

            // 右上角
            arcRect.X = rect.Right - diameter;
            path.AddArc(arcRect, 270, 90);

            // 右下角
            arcRect.Y = rect.Bottom - diameter;
            path.AddArc(arcRect, 0, 90);

            // 左下角
            arcRect.X = rect.Left;
            path.AddArc(arcRect, 90, 90);
            path.CloseFigure();//闭合曲线
            return path;
        }

        /// <summary>
        /// 窗体size发生改变时重新设置Region属性
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 启动器_Resize(object sender, EventArgs e)
        {
            SetWindowRegion();
        }

        private void 语音按钮_Click(object sender, EventArgs e)
        {
            string upd_address = RegUtil.GetRegistryValue(PSOBBRegpath, UpdateADDRESS_Regkey);
            WebAddress = ConvertTxtToDataSet(upd_address + "webaddress.txt");
            Process.Start(WebAddress[0]);
        }

        private void 关闭按钮_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}