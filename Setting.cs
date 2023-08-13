using System;
using Microsoft.Win32;
using System.Drawing;
using System.Windows.Forms;
using ToolUtils;
using ConvertTo_;

namespace PSOBBLauncher
{
    public partial class 游戏设置 : Form
    {
        private byte[] GetRegistryBytes(string Regpath, string Regkey)
        {
            RegistryKey tempKey = Registry.CurrentUser.OpenSubKey(Regpath);
            byte[] temparray = (byte[])tempKey.GetValue(Regkey);
            return temparray;
        }

        //                   16/32
        //CTRLBUF 03 00 00 00 01 00 00 00 
        //      垂直同步
        //        01 00 00 00
        readonly string PSOBBRegpath = @"Software\SonicTeam\PSOBB";
        readonly string ACCOUNT_CHECK_Regkey = "ACCOUNT_CHECK";
        readonly string WINDOW_MODE_Regkey = "WINDOW_MODE";
        readonly string HighResHUD_Regkey = "HighResHUD";
        readonly string Resolution_Regkey = "Resolution";
        readonly string FOCUS_SOUND_Regkey = "FOCUS_SOUND";
        readonly string Volume_BGM_Regkey = "Volume_BGM";
        readonly string Volume_SFX_Regkey = "Volume_SFX";
        readonly string CTRLBUF_Regkey = "CTRLBUF";
        readonly string WORD_WRAP_Regkey = "WORD_WRAP";
        readonly string FONT_JPN_Regkey = "FONT_JPN";
        readonly string FONT_SEL_Regkey = "FONT_SEL";
        readonly string SOUNDCTRL_Regkey = "SOUNDCTRL";
        readonly string GRAPHICCTRL_Regkey = "GRAPHICCTRL";
        //private int Graphics_High_check = 0;
        //private int Graphics_Mid_check = 0;
        //private int Graphics_Low_check = 0;

        public 游戏设置()
        {
            InitializeComponent();
            byte[] array = GetRegistryBytes(PSOBBRegpath, GRAPHICCTRL_Regkey);
            switch(array[0])
            {
                case 0x00:
                    图像设置高配置.Checked = true;
                    图像设置中配置.Checked = false;
                    图像设置低配置.Checked = false;
                    break;
                case 0x01:
                    图像设置高配置.Checked = false;
                    图像设置中配置.Checked = true;
                    图像设置低配置.Checked = false;
                    break;
                case 0x02:
                    图像设置高配置.Checked = false;
                    图像设置中配置.Checked = false;
                    图像设置低配置.Checked = true;
                    break;

            }

            string font = RegUtil.GetRegistryValue(PSOBBRegpath, FONT_JPN_Regkey);
            if (font == "System")
            {
                font = "系统字体";
            }
            字体控件.Items.Add(font);
            System.Drawing.Text.InstalledFontCollection objFont = new();
            foreach (FontFamily i in objFont.Families)
            {
                字体控件.Items.Add(i.Name.ToString());
            }

            if (!字体控件.Items.Contains("系统字体"))
            {
                字体控件.Items.Add("系统字体");
            }

            int font_selectindex = int.Parse(RegUtil.GetRegistryValue(PSOBBRegpath, FONT_SEL_Regkey));
            if (font_selectindex >= 字体控件.Items.Count)
            {
                font_selectindex = 字体控件.Items.Count - 1;
            }
            //MessageBox.Show(string.Format("{0}", 字体控件.Items.Count));
            //if (font == 字体控件.SelectedText)
            //{
            //    font_selectindex = 
            //}
            字体控件.SelectedIndex = font_selectindex;

            array = GetRegistryBytes(PSOBBRegpath, CTRLBUF_Regkey);

            if (array[4] == 0)
            {
                颜色位控件.SelectedIndex = 0;
            }
            else
            {
                颜色位控件.SelectedIndex = 1;
            };

            if (array[8] == 0)
            {
                同步刷新控件.Checked = false;
            }
            else
            {
                同步刷新控件.Checked = true;
            };

            array = GetRegistryBytes(PSOBBRegpath, SOUNDCTRL_Regkey);

            if (array[0] == 0)
            {
                声音开关控件.Checked = false;
            }
            else
            {
                声音开关控件.Checked = true;
            };

            if (array[4] == 0 || array[0] == 0)
            {
                背景音乐控件.Checked = false;
            }
            else
            {
                if (array[0] >= 1)
                {
                    背景音乐控件.Checked = true;
                }
            };

            if (array[8] == 0 || array[0] == 0)
            {
                音效开关控件.Checked = false;
            }
            else
            {
                if (array[0] >= 1)
                {
                    音效开关控件.Checked = true;
                }
            };

            int Resolution_index = int.Parse(RegUtil.GetRegistryValue(PSOBBRegpath, Resolution_Regkey));
            if (Resolution_index > 8 || Resolution_index < 0)
            {
                分辨率控件.SelectedIndex = 0;
                RegUtil.SetRegistryKey("HKEY_CURRENT_USER", PSOBBRegpath, Resolution_Regkey, "0", RegistryValueKind.DWord);
                MessageBox.Show("分辨率值错误,已自动重置为默认值.");
            }
            else
                分辨率控件.SelectedIndex = Resolution_index;

            音量控件.Value = int.Parse(RegUtil.GetRegistryValue(PSOBBRegpath, Volume_BGM_Regkey));

            音调控件.Value = int.Parse(RegUtil.GetRegistryValue(PSOBBRegpath, Volume_SFX_Regkey));

            if (RegUtil.GetRegistryValue(PSOBBRegpath, WORD_WRAP_Regkey) == "1")
            {
                自动断句控件.Checked = true;
            }
            else
            {
                自动断句控件.Checked = false;
            }

            if (RegUtil.GetRegistryValue(PSOBBRegpath, FOCUS_SOUND_Regkey) == "1")
            {
                后台音乐控件.Checked = true;
            }
            else
            {
                后台音乐控件.Checked = false;
            }

            if (RegUtil.GetRegistryValue(PSOBBRegpath, ACCOUNT_CHECK_Regkey) == "1")
            {
                保存账号控件.Checked = true;
            }
            else
            {
                保存账号控件.Checked = false;
            }

            if (RegUtil.GetRegistryValue(PSOBBRegpath, WINDOW_MODE_Regkey) == "1")
            {
                窗口模式控件.Checked = true;
            }
            else
            {
                窗口模式控件.Checked = false;
            }

            if (RegUtil.GetRegistryValue(PSOBBRegpath, HighResHUD_Regkey) == "1")
            {
                高清功能控件.Checked = true;
            }
            else
            {
                高清功能控件.Checked = false;
            }
        }

        private void 默认设置_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定恢复默认吗？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                RegUtil.SetRegistryKey("HKEY_CURRENT_USER", PSOBBRegpath, FOCUS_SOUND_Regkey, "0", RegistryValueKind.DWord);
                后台音乐控件.Checked = false;
                RegUtil.SetRegistryKey("HKEY_CURRENT_USER", PSOBBRegpath, ACCOUNT_CHECK_Regkey, "0", RegistryValueKind.DWord);
                保存账号控件.Checked = false;
                RegUtil.SetRegistryKey("HKEY_CURRENT_USER", PSOBBRegpath, WINDOW_MODE_Regkey, "0", RegistryValueKind.DWord);
                窗口模式控件.Checked = false;
                RegUtil.SetRegistryKey("HKEY_CURRENT_USER", PSOBBRegpath, HighResHUD_Regkey, "0", RegistryValueKind.DWord);
                高清功能控件.Checked = false;
                RegUtil.SetRegistryKey("HKEY_CURRENT_USER", PSOBBRegpath, Resolution_Regkey, "0", RegistryValueKind.DWord);
                分辨率控件.SelectedIndex = 0;
                RegUtil.SetRegistryKey("HKEY_CURRENT_USER", PSOBBRegpath, Volume_BGM_Regkey, "5", RegistryValueKind.DWord);
                音量控件.Value = 5;
                RegUtil.SetRegistryKey("HKEY_CURRENT_USER", PSOBBRegpath, Volume_SFX_Regkey, "5", RegistryValueKind.DWord);
                音调控件.Value = 5;
                Registry.SetValue("HKEY_CURRENT_USER\\" + PSOBBRegpath, CTRLBUF_Regkey, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, }, RegistryValueKind.Binary);
                同步刷新控件.Checked = false;
                颜色位控件.SelectedIndex = 0;
                RegUtil.SetRegistryKey("HKEY_CURRENT_USER", PSOBBRegpath, WORD_WRAP_Regkey, "0", RegistryValueKind.DWord);
                自动断句控件.Checked = false;



            }
            else { 
                return; 
            }
        }

        private void 声音开关控件_CheckedChanged(object sender, EventArgs e)
        {

            byte[] array = GetRegistryBytes(PSOBBRegpath, SOUNDCTRL_Regkey);
            if (声音开关控件.Checked == true)
            {
                    array[0] = 0x01;
                    array[4] = 0x01;
                    array[8] = 0x01;
                    音效开关控件.Checked = true;
                    背景音乐控件.Checked = true;
            }
            else
            {
                array[0] = 0x00;
                array[4] = 0x00;
                array[8] = 0x00;
                背景音乐控件.Checked = false;
                音效开关控件.Checked = false;
            }
            Registry.SetValue("HKEY_CURRENT_USER\\" + PSOBBRegpath, SOUNDCTRL_Regkey, array, RegistryValueKind.Binary);
        }

        private void 背景音乐控件_CheckedChanged_1(object sender, EventArgs e)
        {

            byte[] array = GetRegistryBytes(PSOBBRegpath, SOUNDCTRL_Regkey);
            if (背景音乐控件.Checked == true)
            {
                array[4] = 0x01;
                if (array[8] == 0x00)
                {
                    array[0] = 0x02;
                    声音开关控件.Checked = true;
                    音效开关控件.Checked = false;
                }
                else
                {
                    array[0] = 0x01;
                    声音开关控件.Checked = true;
                }
            }
            else
            {
                array[0] = 0x02;
                array[4] = 0x00;
                if (array[8] == 0x00)
                {
                    array[0] = 0x00;
                    声音开关控件.Checked = false;
                }
            }
            Registry.SetValue("HKEY_CURRENT_USER\\" + PSOBBRegpath, SOUNDCTRL_Regkey, array, RegistryValueKind.Binary);
        }

        private void 音效开关控件_CheckedChanged(object sender, EventArgs e)
        {

            byte[] array = GetRegistryBytes(PSOBBRegpath, SOUNDCTRL_Regkey);
            if (音效开关控件.Checked == true)
            {
                array[8] = 0x01;
                if (array[4] == 0x00)
                {
                    array[0] = 0x02;
                    声音开关控件.Checked = true;
                    背景音乐控件.Checked = false;
                }
                else
                {
                    array[0] = 0x01;
                    声音开关控件.Checked = true;
                }
            }
            else
            {
                array[0] = 0x02;
                array[8] = 0x00;
                if (array[4] == 0x00)
                {
                    array[0] = 0x00;
                    声音开关控件.Checked = false;
                }
            }
            Registry.SetValue("HKEY_CURRENT_USER\\" + PSOBBRegpath, SOUNDCTRL_Regkey, array, RegistryValueKind.Binary);
        }

        private void 字体控件_SelectedIndexChanged(object sender, EventArgs e)
        {
            string font = Convert.ToString(字体控件.SelectedItem);
            if (font == "系统字体")
            {
                font = "System";
            }
            RegUtil.SetRegistryKey("HKEY_CURRENT_USER", PSOBBRegpath, FONT_JPN_Regkey, font, RegistryValueKind.String);
            RegUtil.SetRegistryKey("HKEY_CURRENT_USER", PSOBBRegpath, FONT_SEL_Regkey, Convert.ToString(字体控件.SelectedIndex), RegistryValueKind.DWord);
        }

        private void 同步刷新控件_CheckedChanged(object sender, EventArgs e)
        {
            byte[] array = GetRegistryBytes(PSOBBRegpath, CTRLBUF_Regkey);
            if (同步刷新控件.Checked == true)
            {
                array[8] = 0x01;
            }
            else
            {
                array[8] = 0x00;
            }
            Registry.SetValue("HKEY_CURRENT_USER\\" + PSOBBRegpath, CTRLBUF_Regkey, array, RegistryValueKind.Binary);
        }

        private void 自动断句控件_CheckedChanged(object sender, EventArgs e)
        {
            if (自动断句控件.Checked)
            {
                RegUtil.SetRegistryKey("HKEY_CURRENT_USER", PSOBBRegpath, WORD_WRAP_Regkey, "1", RegistryValueKind.DWord);
            }
            else
            {
                RegUtil.SetRegistryKey("HKEY_CURRENT_USER", PSOBBRegpath, WORD_WRAP_Regkey, "0", RegistryValueKind.DWord);
            }
        }

        private void 音量控件_Scroll(object sender, EventArgs e)
        {
            RegUtil.SetRegistryKey("HKEY_CURRENT_USER", PSOBBRegpath, Volume_BGM_Regkey, Convert.ToString(音量控件.Value), RegistryValueKind.DWord);
        }

        private void 音调控件_Scroll(object sender, EventArgs e)
        {
            RegUtil.SetRegistryKey("HKEY_CURRENT_USER", PSOBBRegpath, Volume_SFX_Regkey, Convert.ToString(音调控件.Value), RegistryValueKind.DWord);
        }

        private void 背景音乐控件_CheckedChanged(object sender, EventArgs e)
        {
            if (后台音乐控件.Checked)
            {
                RegUtil.SetRegistryKey("HKEY_CURRENT_USER", PSOBBRegpath, FOCUS_SOUND_Regkey, "1", RegistryValueKind.DWord);
            }
            else
            {
                RegUtil.SetRegistryKey("HKEY_CURRENT_USER", PSOBBRegpath, FOCUS_SOUND_Regkey, "0", RegistryValueKind.DWord);
            }
        }

        private void 颜色位控件_SelectedIndexChanged(object sender, EventArgs e)
        {
            byte[] array = GetRegistryBytes(PSOBBRegpath, CTRLBUF_Regkey);
            if (颜色位控件.SelectedIndex == 1)
            {
                array[4] = 0x01;
            }
            else
            {
                array[4] = 0x00;
            }
            Registry.SetValue("HKEY_CURRENT_USER\\" + PSOBBRegpath, CTRLBUF_Regkey, array, RegistryValueKind.Binary);
        }

        private void 分辨率控件_SelectedIndexChanged(object sender, EventArgs e)
        {
            RegUtil.SetRegistryKey("HKEY_CURRENT_USER", PSOBBRegpath, Resolution_Regkey, Convert.ToString(分辨率控件.SelectedIndex), RegistryValueKind.DWord);
            byte[] array = GetRegistryBytes(PSOBBRegpath, CTRLBUF_Regkey);
            array[0] = Convert.ToByte(分辨率控件.SelectedIndex);
            Registry.SetValue("HKEY_CURRENT_USER\\" + PSOBBRegpath, CTRLBUF_Regkey, array, RegistryValueKind.Binary);
        }

        private void 保存账号控件_CheckedChanged(object sender, EventArgs e)
        {
            if (保存账号控件.Checked)
            {
                RegUtil.SetRegistryKey("HKEY_CURRENT_USER", PSOBBRegpath, ACCOUNT_CHECK_Regkey, "1", RegistryValueKind.DWord);
            }
            else
            {
                RegUtil.SetRegistryKey("HKEY_CURRENT_USER", PSOBBRegpath, ACCOUNT_CHECK_Regkey, "0", RegistryValueKind.DWord);
            }
        }

        private void 窗口模式控件_CheckedChanged(object sender, EventArgs e)
        {
            if (窗口模式控件.Checked)
            {
                RegUtil.SetRegistryKey("HKEY_CURRENT_USER", PSOBBRegpath, WINDOW_MODE_Regkey, "1", RegistryValueKind.DWord);
            }
            else
            {
                RegUtil.SetRegistryKey("HKEY_CURRENT_USER", PSOBBRegpath, WINDOW_MODE_Regkey, "0", RegistryValueKind.DWord);
            }
        }

        private void 高清功能_CheckedChanged(object sender, EventArgs e)
        {
            if (高清功能控件.Checked)
            {
                RegUtil.SetRegistryKey("HKEY_CURRENT_USER", PSOBBRegpath, HighResHUD_Regkey, "1", RegistryValueKind.DWord);
            }
            else
            {
                RegUtil.SetRegistryKey("HKEY_CURRENT_USER", PSOBBRegpath, HighResHUD_Regkey, "0", RegistryValueKind.DWord);
            }
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
                    m.HWnd = this.Handle;
                    m.Result = HTCAPTION;
                }
                return;
            }
            base.WndProc(ref m);
        }

        private void 关闭设置_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void 自定义图像按钮_Click(object sender, EventArgs e)
        {
            using 图像设置窗体 dlg = new(); //caozuo是窗口类名，确保访问；后面的是构造函数
            dlg.ShowDialog();
        }

        private void 图像设置高配置_CheckedChanged(object sender, EventArgs e)
        {
            // 0                       4                        8                      12
            //0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x02, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 
            // 16                      20                       24                     28
            //0x02, 0x00, 0x00, 0x00, 0x02, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
            // 32
            //0x00, 0x00, 0x00, 0x00
            //byte[] array = new byte[36];
            if (图像设置高配置.Checked)
            {
                图像设置中配置.Checked = false;
                图像设置低配置.Checked = false;
                //byte[] array = BACv.GetRegistryBytes(PSOBBRegpath, GRAPHICCTRL_Regkey);
                byte[] array = new byte[36];
                array[0] = 0x00; // 高中低配置选项 自定义的话 是0x03 自定义高中低都会取消选项
                array[4] = 0x01; // 高精度图像处理
                array[8] = 0x02; // 影子参数 0 1 2 三个档位
                array[12] = 0x01; // 敌人模型参数 0 1
                array[16] = 0x02; // 地形参数 0 1 2 三个档位
                array[20] = 0x02; // 视距 0 1 2三个档位
                array[24] = 0x01; // 0 顶点雾 1 点状雾 2 雾状模拟
                array[28] = 0x00; // 低精度贴图
                array[32] = 0x00; // 0 1 2 跳帧
                //array[34] = 0xFF; //开启可变帧率
                //array[35] = 0xFF;
                Registry.SetValue("HKEY_CURRENT_USER\\" + PSOBBRegpath, GRAPHICCTRL_Regkey, array, RegistryValueKind.Binary);
                //Graphics_High_check = 1;
                //Graphics_Mid_check = 0;
                //Graphics_Low_check = 0;
            }
        }

        private void 图像设置中配置_CheckedChanged(object sender, EventArgs e)
        {
            if (图像设置中配置.Checked)
            {
                图像设置高配置.Checked = false;
                图像设置低配置.Checked = false;
                //byte[] array = BACv.GetRegistryBytes(PSOBBRegpath, GRAPHICCTRL_Regkey);
                byte[] array = new byte[36];
                array[0] = 0x01;
                array[4] = 0x00;
                array[8] = 0x00;
                array[12] = 0x00;
                array[16] = 0x01;
                array[20] = 0x01;
                array[24] = 0x01;
                array[28] = 0x00;
                array[32] = 0x00;
                Registry.SetValue("HKEY_CURRENT_USER\\" + PSOBBRegpath, GRAPHICCTRL_Regkey, array, RegistryValueKind.Binary);
            }
        }

        private void 图像设置低配置_CheckedChanged(object sender, EventArgs e)
        {
            if (图像设置低配置.Checked)
            {
                图像设置高配置.Checked = false;
                图像设置中配置.Checked = false;
                byte[] array = new byte[36];
                array[0] = 0x02;
                array[4] = 0x00;
                array[8] = 0x00;
                array[12] = 0x00;
                array[16] = 0x00;
                array[20] = 0x00;
                array[24] = 0x01;
                array[28] = 0x00;
                array[32] = 0x01;
                Registry.SetValue("HKEY_CURRENT_USER\\" + PSOBBRegpath, GRAPHICCTRL_Regkey, array, RegistryValueKind.Binary);
            }
        }

        private void 图像设置背景图_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.phantasystaronline.cn:88/");
        }
    }
}
