using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using ToolUtils;

namespace PSOBBLauncher
{
    public partial class 图像设置窗体 : Form
    {
        readonly string PSOBBRegpath = @"Software\SonicTeam\PSOBB";
        readonly string GRAPHICCTRL_Regkey = "GRAPHICCTRL";
        //readonly string WEBSITE_OFFICIAL_Regkey = "WEBSITE_OFFICIAL";

        private byte[] GetRegistryBytes(string Regpath, string Regkey)
        {
            RegistryKey driverKey = Registry.CurrentUser.OpenSubKey(Regpath);
            byte[] temparray = (byte[])driverKey.GetValue(Regkey);
            return temparray;
        }

        public 图像设置窗体()
        {
            InitializeComponent(); 
            //byte[] array = new byte[36];
            //array[0] = 0x00; // 高中低配置选项 自定义的话 是0x03 自定义高中低都会取消选项
            //array[4] = 0x01; // 高精度图像处理
            //array[8] = 0x02; // 影子参数 0 1 2 三个档位
            //array[12] = 0x01; // 敌人模型参数 0 1
            //array[16] = 0x02; // 地形参数 0 1 2 三个档位
            //array[20] = 0x02; // 视距 0 1 2三个档位
            //array[24] = 0x01; // 0 顶点雾 1 点状雾 2 雾状模拟
            //array[28] = 0x00; // 低精度贴图
            //array[32] = 0x00; // 0 1 2 跳帧
            //array[34] = 0xFF; //开启可变帧率
            //array[35] = 0xFF;
            byte[] array = GetRegistryBytes(PSOBBRegpath, GRAPHICCTRL_Regkey);
            if (array[4] == 0x00)
                高精度图像处理控件.Checked = false;
            else
                高精度图像处理控件.Checked = true;

            影子图像设置控件.Value = Convert.ToInt32(array[8]);
            敌人图像设置控件.Value = Convert.ToInt32(array[12]);
            地形图像设置控件.Value = Convert.ToInt32(array[16]);
            视距图像设置控件.Value = Convert.ToInt32(array[20]);
            雾化效果设置控件.SelectedIndex = Convert.ToInt32(array[24]);

            if (array[28] == 0x00)
                低精度贴图控件.Checked = false;
            else
                低精度贴图控件.Checked = true;

            自动跳帧控件.SelectedIndex = Convert.ToInt32(array[32]);

            if (array[34] == 0x00 && array[35] == 0x00)
                可变帧率控件.Checked = false;
            else
                可变帧率控件.Checked = true;

        }

        private void 高精度图像处理控件_CheckedChanged(object sender, EventArgs e)
        {
            byte[] array = GetRegistryBytes(PSOBBRegpath, GRAPHICCTRL_Regkey);
            if (高精度图像处理控件.Checked == true)
            {
                array[0] = 0x03;
                array[4] = 0x01;
            }
            else
                array[4] = 0x00;
            Registry.SetValue("HKEY_CURRENT_USER\\" + PSOBBRegpath, GRAPHICCTRL_Regkey, array, RegistryValueKind.Binary);
        }

        private void 影子图像设置控件_Scroll(object sender, EventArgs e)
        {
            byte[] array = GetRegistryBytes(PSOBBRegpath, GRAPHICCTRL_Regkey);
            array[0] = 0x03;
            array[8] = Convert.ToByte(影子图像设置控件.Value);
            Registry.SetValue("HKEY_CURRENT_USER\\" + PSOBBRegpath, GRAPHICCTRL_Regkey, array, RegistryValueKind.Binary);
        }

        private void 敌人图像设置控件_Scroll(object sender, EventArgs e)
        {
            byte[] array = GetRegistryBytes(PSOBBRegpath, GRAPHICCTRL_Regkey);
            array[0] = 0x03;
            array[12] = Convert.ToByte(敌人图像设置控件.Value);
            Registry.SetValue("HKEY_CURRENT_USER\\" + PSOBBRegpath, GRAPHICCTRL_Regkey, array, RegistryValueKind.Binary);
        }

        private void 地形图像设置控件_Scroll(object sender, EventArgs e)
        {
            byte[] array = GetRegistryBytes(PSOBBRegpath, GRAPHICCTRL_Regkey);
            array[0] = 0x03;
            array[16] = Convert.ToByte(地形图像设置控件.Value);
            Registry.SetValue("HKEY_CURRENT_USER\\" + PSOBBRegpath, GRAPHICCTRL_Regkey, array, RegistryValueKind.Binary);
        }

        private void 视距图像设置控件_Scroll(object sender, EventArgs e)
        {
            byte[] array = GetRegistryBytes(PSOBBRegpath, GRAPHICCTRL_Regkey);
            array[0] = 0x03;
            array[20] = Convert.ToByte(视距图像设置控件.Value);
            Registry.SetValue("HKEY_CURRENT_USER\\" + PSOBBRegpath, GRAPHICCTRL_Regkey, array, RegistryValueKind.Binary);
        }

        private void 雾化效果设置控件_SelectedIndexChanged(object sender, EventArgs e)
        {
            byte[] array = GetRegistryBytes(PSOBBRegpath, GRAPHICCTRL_Regkey);
            array[0] = 0x03;
            array[24] = Convert.ToByte(雾化效果设置控件.SelectedIndex);
            Registry.SetValue("HKEY_CURRENT_USER\\" + PSOBBRegpath, GRAPHICCTRL_Regkey, array, RegistryValueKind.Binary);
        }

        private void 低精度贴图控件_CheckedChanged(object sender, EventArgs e)
        {
            byte[] array = GetRegistryBytes(PSOBBRegpath, GRAPHICCTRL_Regkey);
            if (低精度贴图控件.Checked == true)
            {
                array[0] = 0x03;
                array[28] = 0x01;
            }
            else
                array[28] = 0x00;
            Registry.SetValue("HKEY_CURRENT_USER\\" + PSOBBRegpath, GRAPHICCTRL_Regkey, array, RegistryValueKind.Binary);
        }

        private void 自动跳帧控件_SelectedIndexChanged(object sender, EventArgs e)
        {
            byte[] array = GetRegistryBytes(PSOBBRegpath, GRAPHICCTRL_Regkey);
            array[0] = 0x03;
            array[32] = Convert.ToByte(自动跳帧控件.SelectedIndex);
            Registry.SetValue("HKEY_CURRENT_USER\\" + PSOBBRegpath, GRAPHICCTRL_Regkey, array, RegistryValueKind.Binary);
        }

        private void 可变帧率控件_CheckedChanged(object sender, EventArgs e)
        {
            byte[] array = GetRegistryBytes(PSOBBRegpath, GRAPHICCTRL_Regkey);
            if (可变帧率控件.Checked == true)
            {
                array[0] = 0x03;
                array[34] = 0xFF;
                array[35] = 0xFF;
            }
            else
            {
                array[34] = 0x00;
                array[35] = 0x00;
            }
            Registry.SetValue("HKEY_CURRENT_USER\\" + PSOBBRegpath, GRAPHICCTRL_Regkey, array, RegistryValueKind.Binary);
        }

        private void 图像设置窗体_Load(object sender, EventArgs e)
        {

        }

        private void 关闭设置_Click(object sender, EventArgs e)
        {
            Close();
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

        private void 图像设置背景图_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start(RegUtil.GetRegistryValue(PSOBBRegpath, WEBSITE_OFFICIAL_Regkey));
            System.Diagnostics.Process.Start("http://www.phantasystaronline.cn:88/");
        }
    }
}
