using System;
using Microsoft.Win32;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToolUtils;
using PSOBBLauncher;

namespace PSOBBLauncher
{
    public partial class 账号清单 : Form
    {
        readonly string PSOBBRegpath = @"Software\SonicTeam\PSOBB";
        readonly string ACCOUNT_Regkey = "ACCOUNT";
        readonly string ACCOUNTS_Regkey = "ACCOUNTS";
        readonly string ACCOUNT_SEL_Regkey = "ACCOUNT_SEL";
        //readonly string Password_Regkey = "Password";
        readonly string PASSWORDS_Regkey = "PASSWORDS";
        public int account_change = 0;

        public 账号清单()
        {
            InitializeComponent();
            string[] var2 = (string[])Registry.CurrentUser.OpenSubKey(PSOBBRegpath, true).GetValue(ACCOUNTS_Regkey);
            if (var2 != null)
            {
                int i = 0;
                for (; i < var2.Length; i++)
                {
                    if (var2[i] != null)
                    {
                        账号列表控件.Items.Add(var2[i]);
                        account_change = 1;
                    }
                }
                account_change = 0;
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

        private void 账号清单关闭按钮_Click(object sender, EventArgs e)
        {
            Close();
        }

        public string selected;
        public int selected_index;

        private void 账号列表控件_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected = Convert.ToString(账号列表控件.SelectedItem);
            selected_index = 账号列表控件.SelectedIndex;
            RegUtil.SetRegistryKey("HKEY_CURRENT_USER", PSOBBRegpath, ACCOUNT_Regkey, selected, RegistryValueKind.String);
        }

        private void 账号清单删除按钮_Click(object sender, EventArgs e)
        {
            string var1 = (string)RegUtil.GetRegistryValue(PSOBBRegpath, ACCOUNT_Regkey);
            if (selected == var1)
            {
                int ind = 账号列表控件.SelectedIndex;
                账号列表控件.Items.Remove(var1);
                账号列表控件.Items.Insert(ind, "空");
                string[] var2 = (string[])Registry.CurrentUser.OpenSubKey(PSOBBRegpath, true).GetValue(ACCOUNTS_Regkey);
                var2[ind] = "空";
                Registry.SetValue("HKEY_CURRENT_USER\\" + PSOBBRegpath, ACCOUNTS_Regkey, var2, RegistryValueKind.MultiString);
            }
        }

        private void 账号清单添加按钮_Click(object sender, EventArgs e)
        {
            string var1 = 账号清单账号.Text;
            string[] var2 = (string[])Registry.CurrentUser.OpenSubKey(PSOBBRegpath, true).GetValue(ACCOUNTS_Regkey);
            
            int i = 0;
            int i2 = 0;
            int c = 0;
            for (; i < 10; i++)
            {
                if (var2[i] == var1)
                {
                    MessageBox.Show(string.Format("账号已存在, 所在位置 {0}", i));
                    break;
                }
                else
                {
                    c = 1;
                }
            }
            if (c == 1)
            {
                for (; i2 < var2.Length; i2++)
                {
                    if (var2[i2] == "空")
                    {
                        break;
                    }
                }
                if (i2 < 10)
                {
                    var2[i2] = var1;
                    Registry.SetValue("HKEY_CURRENT_USER\\" + PSOBBRegpath, ACCOUNTS_Regkey, var2, RegistryValueKind.MultiString);
                    账号列表控件.Items.RemoveAt(i2);
                    账号列表控件.Items.Insert(i2, var1);
                }
                else
                {
                    MessageBox.Show("已达测试版10个账号上限！");
                }
            }
        }

        private void 账号清单_Load(object sender, EventArgs e)
        {

        }

        private void 账号列表清空按钮_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定清空所有账号吗？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int all1 = 账号列表控件.Items.Count;
                //int all2 = 账号列表控件.Items.Count;
                账号列表控件.Items.Clear();
                int i = 0;
                for (; i < all1; i++)
                {
                    账号列表控件.Items.Add("空");
                }
                Registry.SetValue("HKEY_CURRENT_USER\\" + PSOBBRegpath, ACCOUNTS_Regkey, new string[] { "空", "空", "空", "空", "空", "空", "空", "空", "空", "空" }, RegistryValueKind.MultiString);
                Registry.SetValue("HKEY_CURRENT_USER\\" + PSOBBRegpath, ACCOUNT_Regkey, "", RegistryValueKind.String);
                Registry.SetValue("HKEY_CURRENT_USER\\" + PSOBBRegpath, PASSWORDS_Regkey, new string[] { "空", "空", "空", "空", "空", "空", "空", "空", "空", "空" }, RegistryValueKind.MultiString);
                //Registry.SetValue("HKEY_CURRENT_USER\\" + PSOBBRegpath, Password_Regkey, 0x00, RegistryValueKind.Binary);
                Registry.SetValue("HKEY_CURRENT_USER\\" + PSOBBRegpath, ACCOUNT_SEL_Regkey, 0, RegistryValueKind.DWord);
            }
            else
            {
                return;
            }

        }
    }
}
