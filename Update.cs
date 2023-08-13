using Microsoft.Win32;
using System;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Net;
using System.Windows.Forms;
using ToolUtils;

namespace PSOBBLauncher
{
    public partial class 更新程序 : Form
    {
        readonly string PSOBBRegpath = @"Software\SonicTeam\PSOBB";
        readonly string ACCOUNT_Regkey = "ACCOUNT"; //REG_SZ
        readonly string ACCOUNT_CHECK_Regkey = "ACCOUNT_CHECK"; //REG_DWORD
        readonly string ACCOUNT_CTRL_Regkey = "ACCOUNT_CTRL"; //REG_BINARY
        readonly string ACCOUNT_SEL_Regkey = "ACCOUNT_SEL"; //REG_DWORD
        readonly string ACCOUNTS_Regkey = "ACCOUNTS"; //REG_MULTI_SZ
        readonly string BILLING_SITE_Regkey = "BILLING_SITE";
        readonly string CLIENT_CODE_Regkey = "CLIENT_CODE";
        readonly string CTRLBUF_Regkey = "CTRLBUF";
        readonly string EXT0_Regkey = "EXT0";
        readonly string FOCUS_SOUND_Regkey = "FOCUS_SOUND";
        readonly string FONT_JPN_Regkey = "FONT_JPN";
        readonly string FONT_SEL_Regkey = "FONT_SEL";
        readonly string GRAPHICCTRL_Regkey = "GRAPHICCTRL";
        readonly string HighResHUD_Regkey = "HighResHUD";
        readonly string INSTALL_Regkey = "INSTALL";
        readonly string OldCheck_Regkey = "OldCheck";
        readonly string Password_Regkey = "Password";
        readonly string PASSWORD_CHECK_Regkey = "PASSWORD_CHECK";
        readonly string PASSWORDS_Regkey = "PASSWORDS";
        readonly string Resolution_Regkey = "Resolution";
        readonly string SOUNDCTRL_Regkey = "SOUNDCTRL";
        readonly string UpdateADDRESS_Regkey = "UpdateADDRESS";
        readonly string Volume_BGM_Regkey = "Volume_BGM";
        readonly string Volume_SFX_Regkey = "Volume_SFX";
        readonly string WEBSITE_OFFICIAL_Regkey = "WEBSITE_OFFICIAL";
        readonly string WEBSITE_REG_Regkey = "WEBSITE_REG";
        readonly string WINDOW_MODE_Regkey = "WINDOW_MODE";
        readonly string WORD_WRAP_Regkey = "WORD_WRAP";
        readonly string Website = "http://psobb.sanc.top/";
        readonly string Website_reg = "http://psobb.sanc.top/";
        readonly string Website_update = "http://phantasystaronline.cn:88/update/";

        public int[] updated = new int[256];
        public string[] UpdateFILES;

        public 更新程序()
        {
            InitializeComponent();
            Check_Reg();
        }

        public void Check_Reg()
        {
            if (Registry.CurrentUser.OpenSubKey(PSOBBRegpath, true) == null)
            {
                Registry.CurrentUser.CreateSubKey(PSOBBRegpath);
            }

            if (RegUtil.GetRegistryValue(PSOBBRegpath, ACCOUNT_Regkey) == null)
            {
                Registry.SetValue("HKEY_CURRENT_USER\\" + PSOBBRegpath, ACCOUNT_Regkey, "", RegistryValueKind.String);
            }
            if (RegUtil.GetRegistryValue(PSOBBRegpath, ACCOUNT_CHECK_Regkey) == null)
            {
                Registry.SetValue("HKEY_CURRENT_USER\\" + PSOBBRegpath, ACCOUNT_CHECK_Regkey, "0", RegistryValueKind.DWord);
            }
            if (RegUtil.GetRegistryValue(PSOBBRegpath, ACCOUNT_CTRL_Regkey) == null)
            {
                Registry.SetValue("HKEY_CURRENT_USER\\" + PSOBBRegpath, ACCOUNT_CTRL_Regkey, new byte[] { 0x3D, 0xAA, 0xD0, 0x6E, 0xAE, 0x64, 0xCD, 0x48 }, RegistryValueKind.Binary);
            }
            if (RegUtil.GetRegistryValue(PSOBBRegpath, ACCOUNT_SEL_Regkey) == null)
            {
                Registry.SetValue("HKEY_CURRENT_USER\\" + PSOBBRegpath, ACCOUNT_SEL_Regkey, "0", RegistryValueKind.DWord);
            }
            if (RegUtil.GetRegistryValue(PSOBBRegpath, ACCOUNTS_Regkey) == null)
            {
                Registry.SetValue("HKEY_CURRENT_USER\\" + PSOBBRegpath, ACCOUNTS_Regkey, new string[] { "空", "空", "空", "空", "空", "空", "空", "空", "空", "空" }, RegistryValueKind.MultiString);
            }
            if (RegUtil.GetRegistryValue(PSOBBRegpath, BILLING_SITE_Regkey) == null)
            {
                Registry.SetValue("HKEY_CURRENT_USER\\" + PSOBBRegpath, BILLING_SITE_Regkey, Website, RegistryValueKind.String);
            }
            if (RegUtil.GetRegistryValue(PSOBBRegpath, BILLING_SITE_Regkey) != Website)
            {
                Registry.SetValue("HKEY_CURRENT_USER\\" + PSOBBRegpath, BILLING_SITE_Regkey, Website, RegistryValueKind.String);
            }
            if (RegUtil.GetRegistryValue(PSOBBRegpath, CLIENT_CODE_Regkey) == null)
            {
                Registry.SetValue("HKEY_CURRENT_USER\\" + PSOBBRegpath, CLIENT_CODE_Regkey, "14", RegistryValueKind.DWord);
            }
            if (RegUtil.GetRegistryValue(PSOBBRegpath, CTRLBUF_Regkey) == null)
            {
                Registry.SetValue("HKEY_CURRENT_USER\\" + PSOBBRegpath, CTRLBUF_Regkey, new byte[12], RegistryValueKind.Binary);
            }
            if (RegUtil.GetRegistryValue(PSOBBRegpath, EXT0_Regkey) == null)
            {
                Registry.SetValue("HKEY_CURRENT_USER\\" + PSOBBRegpath, EXT0_Regkey, "2", RegistryValueKind.DWord);
            }
            if (RegUtil.GetRegistryValue(PSOBBRegpath, FOCUS_SOUND_Regkey) == null)
            {
                Registry.SetValue("HKEY_CURRENT_USER\\" + PSOBBRegpath, FOCUS_SOUND_Regkey, "0", RegistryValueKind.DWord);
            }
            if (RegUtil.GetRegistryValue(PSOBBRegpath, FONT_JPN_Regkey) == null)
            {
                Registry.SetValue("HKEY_CURRENT_USER\\" + PSOBBRegpath, FONT_JPN_Regkey, "System", RegistryValueKind.String);
            }
            if (RegUtil.GetRegistryValue(PSOBBRegpath, FONT_SEL_Regkey) == null)
            {
                Registry.SetValue("HKEY_CURRENT_USER\\" + PSOBBRegpath, FONT_SEL_Regkey, "0", RegistryValueKind.DWord);
            }
            if (RegUtil.GetRegistryValue(PSOBBRegpath, GRAPHICCTRL_Regkey) == null)
            {
                Registry.SetValue("HKEY_CURRENT_USER\\" + PSOBBRegpath, GRAPHICCTRL_Regkey, new byte[36], RegistryValueKind.Binary);
            }
            if (RegUtil.GetRegistryValue(PSOBBRegpath, HighResHUD_Regkey) == null)
            {
                Registry.SetValue("HKEY_CURRENT_USER\\" + PSOBBRegpath, HighResHUD_Regkey, "0", RegistryValueKind.DWord);
            }
            if (RegUtil.GetRegistryValue(PSOBBRegpath, INSTALL_Regkey) == null)
            {
                Registry.SetValue("HKEY_CURRENT_USER\\" + PSOBBRegpath, INSTALL_Regkey, "1", RegistryValueKind.DWord);
            }
            if (RegUtil.GetRegistryValue(PSOBBRegpath, OldCheck_Regkey) == null)
            {
                Registry.SetValue("HKEY_CURRENT_USER\\" + PSOBBRegpath, OldCheck_Regkey, "0", RegistryValueKind.DWord);
            }
            if (RegUtil.GetRegistryValue(PSOBBRegpath, Password_Regkey) == null)
            {
                Registry.SetValue("HKEY_CURRENT_USER\\" + PSOBBRegpath, Password_Regkey, new byte[0], RegistryValueKind.Binary);
            }
            if (RegUtil.GetRegistryValue(PSOBBRegpath, PASSWORD_CHECK_Regkey) == null)
            {
                Registry.SetValue("HKEY_CURRENT_USER\\" + PSOBBRegpath, PASSWORD_CHECK_Regkey, "0", RegistryValueKind.DWord);
            }
            if (RegUtil.GetRegistryValue(PSOBBRegpath, PASSWORDS_Regkey) == null)
            {
                Registry.SetValue("HKEY_CURRENT_USER\\" + PSOBBRegpath, PASSWORDS_Regkey, new string[] { "空", "空", "空", "空", "空", "空", "空", "空", "空", "空" }, RegistryValueKind.MultiString);
            }
            if (RegUtil.GetRegistryValue(PSOBBRegpath, Resolution_Regkey) == null)
            {
                Registry.SetValue("HKEY_CURRENT_USER\\" + PSOBBRegpath, Resolution_Regkey, "0", RegistryValueKind.DWord);
            }
            if (RegUtil.GetRegistryValue(PSOBBRegpath, SOUNDCTRL_Regkey) == null)
            {
                Registry.SetValue("HKEY_CURRENT_USER\\" + PSOBBRegpath, SOUNDCTRL_Regkey, new byte[12], RegistryValueKind.Binary);
            }
            if (RegUtil.GetRegistryValue(PSOBBRegpath, UpdateADDRESS_Regkey) == null)
            {
                Registry.SetValue("HKEY_CURRENT_USER\\" + PSOBBRegpath, UpdateADDRESS_Regkey, Website_update, RegistryValueKind.String);
            }
            if (RegUtil.GetRegistryValue(PSOBBRegpath, UpdateADDRESS_Regkey) != Website_update)
            {
                Registry.SetValue("HKEY_CURRENT_USER\\" + PSOBBRegpath, UpdateADDRESS_Regkey, Website_update, RegistryValueKind.String);
            }
            if (RegUtil.GetRegistryValue(PSOBBRegpath, Volume_BGM_Regkey) == null)
            {
                Registry.SetValue("HKEY_CURRENT_USER\\" + PSOBBRegpath, Volume_BGM_Regkey, "0", RegistryValueKind.DWord);
            }
            if (RegUtil.GetRegistryValue(PSOBBRegpath, Volume_SFX_Regkey) == null)
            {
                Registry.SetValue("HKEY_CURRENT_USER\\" + PSOBBRegpath, Volume_SFX_Regkey, "0", RegistryValueKind.DWord);
            }
            if (RegUtil.GetRegistryValue(PSOBBRegpath, WEBSITE_OFFICIAL_Regkey) == null)
            {
                Registry.SetValue("HKEY_CURRENT_USER\\" + PSOBBRegpath, WEBSITE_OFFICIAL_Regkey, Website, RegistryValueKind.String);
            }
            if (RegUtil.GetRegistryValue(PSOBBRegpath, WEBSITE_OFFICIAL_Regkey) != Website)
            {
                Registry.SetValue("HKEY_CURRENT_USER\\" + PSOBBRegpath, WEBSITE_OFFICIAL_Regkey, Website, RegistryValueKind.String);
            }
            if (RegUtil.GetRegistryValue(PSOBBRegpath, WEBSITE_REG_Regkey) == null)
            {
                Registry.SetValue("HKEY_CURRENT_USER\\" + PSOBBRegpath, WEBSITE_REG_Regkey, Website_reg, RegistryValueKind.String);
            }
            if (RegUtil.GetRegistryValue(PSOBBRegpath, WEBSITE_REG_Regkey) != Website_reg)
            {
                Registry.SetValue("HKEY_CURRENT_USER\\" + PSOBBRegpath, WEBSITE_REG_Regkey, Website_reg, RegistryValueKind.String);
            }
            if (RegUtil.GetRegistryValue(PSOBBRegpath, WINDOW_MODE_Regkey) == null)
            {
                Registry.SetValue("HKEY_CURRENT_USER\\" + PSOBBRegpath, WINDOW_MODE_Regkey, "0", RegistryValueKind.DWord);
            }
            if (RegUtil.GetRegistryValue(PSOBBRegpath, WORD_WRAP_Regkey) == null)
            {
                Registry.SetValue("HKEY_CURRENT_USER\\" + PSOBBRegpath, WORD_WRAP_Regkey, "0", RegistryValueKind.DWord);
            }
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
        private void 更新程序_Resize(object sender, EventArgs e)
        {
            SetWindowRegion();
        }

        /// <summary>
        /// 下载文件
        /// </summary>
        /// <param name="URL">服务器文件路径</param>
        /// <param name="LocalPath">本地文件路径</param>
        /// <param name="filename">文件名</param>
        /// <param name="prog">进度条控件</param>
        /// <param name="item">ListView项</param>
        /// <param name="i">count</param>
        public int HttpDownload(string URL, string LocalFile, ProgressBar prog, Label label, int i)
        {
            HttpWebRequest Myrq = (HttpWebRequest)WebRequest.Create(URL);
            HttpWebResponse myrp = (HttpWebResponse)Myrq.GetResponse();
            long totalBytes = myrp.ContentLength;
            if (prog != null)
            {
                prog.Maximum = (int)totalBytes;
            }
            Stream st = myrp.GetResponseStream();
            Stream so = new FileStream(LocalFile, FileMode.Create);
            long totalDownloadedByte = 0;
            byte[] by = new byte[2048];
            int osize = st.Read(by, 0, by.Length);
            while (osize > 0)
            {
                totalDownloadedByte = osize + totalDownloadedByte;
                so.Write(by, 0, osize);
                if (prog != null)
                {
                    prog.Value = (int)totalDownloadedByte;
                }
                osize = st.Read(by, 0, by.Length);

                float percent = (float)totalDownloadedByte / totalBytes * 100;
                if (percent.ToString().Length > 4)
                {
                    label.Text = "当前进度: " + percent.ToString().Substring(0, 5) + "% " + "目标文件: " + LocalFile;
                }
                else
                {
                    label.Text = "当前进度: " + percent.ToString() + "% " + "目标文件: " + LocalFile;
                }
                Application.DoEvents();
            }
            so.Close();
            st.Close();
            string info = LocalFile + " 大小: " + GetFileSize(totalBytes);
            更新文件列表.Items.Remove(info);
            return i;
        }

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
                WriteLog.Log("更新错误", string.Format("更新失败 {0}!", esr.ReadToEnd()));
                MessageBox.Show("无法获取更新文件,程序即将关闭！", "发生错误");
                Application.Exit();
                esr.Close();
                return null;
            }
        }

        private string GetInfo(string URL)
        {
            _ = URL.Substring(URL.LastIndexOf(".") + 1,
            (URL.Length - URL.LastIndexOf(".") - 1));
            // string Results = "类型：" + filetype.ToUpper();
            _ = URL.Substring(URL.LastIndexOf("/") + 1,
            (URL.Length - URL.LastIndexOf("/") - 1));
            string Results;
            long ContentL;
            if (URL.ToLower().StartsWith("http://"))
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);

                request.MaximumAutomaticRedirections = 4;
                request.MaximumResponseHeadersLength = 4;
                request.Credentials = CredentialCache.DefaultCredentials;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                ContentL = response.ContentLength;
                response.Close();

                Results = GetFileSize(ContentL);

            }
            else if (URL.ToLower().StartsWith("ftp://"))
            {

                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(URL);
                request.Method = WebRequestMethods.Ftp.GetFileSize;
                request.UseBinary = true;
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                Stream Fs = response.GetResponseStream();
                ContentL = response.ContentLength;
                Fs.Close();
                response.Close();

                Results = GetFileSize(ContentL);
            }
            else
            {
                Results = "获取文件大小失败";
            }

            return Results;
        }

        /// <summary>
        /// 格式化文件大小
        /// </summary>
        /// <param name="filesize">文件传入大小</param>
        /// <returns></returns>
        private static string GetFileSize(long filesize)
        {
            try
            {
                if (filesize < 0)
                {
                    return "0";
                }
                else if (filesize >= 1024 * 1024 * 1024)  //文件大小大于或等于1024MB    
                {
                    return string.Format("{0:0.00} GB", (double)filesize / (1024 * 1024 * 1024));
                }
                else if (filesize >= 1024 * 1024) //文件大小大于或等于1024KB    
                {
                    return string.Format("{0:0.00} MB", (double)filesize / (1024 * 1024));
                }
                else if (filesize >= 1024) //文件大小大于等于1024bytes    
                {
                    return string.Format("{0:0.00} KB", (double)filesize / 1024);
                }
                else
                {
                    return string.Format("{0:0.00} bytes", filesize);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private int Check_File(string oldfile_info, string newfile_info, int i)
        {
            if (oldfile_info != null)
            {
                HttpWebRequest req;
                req = (HttpWebRequest)WebRequest.Create(new Uri(newfile_info));
                req.Method = WebRequestMethods.Http.Get;
                HttpWebResponse response = (HttpWebResponse)req.GetResponse();
                FileInfo t = new(oldfile_info);
                DateTime oldtime = t.LastWriteTime;
                DateTime NEWtime = response.LastModified;
                //MessageBox.Show(string.Format("{0} : {1}", oldtime, NEWtime));
                response.Close();
                string newfile_byte = GetInfo(newfile_info);
                if (!t.Exists)
                {
                    string info = oldfile_info + " 大小: " + newfile_byte;
                    更新文件列表.Items.Add(info);
                    return i;
                }
                else
                {
                    string oldfile_byte = GetFileSize(t.Length);
                    if (oldfile_byte == newfile_byte && oldtime > NEWtime)
                    {
                        return -1;
                    }
                    else
                    {
                        string info = oldfile_info + " 大小: " + newfile_byte;
                        更新文件列表.Items.Add(info);
                        return i;
                    }
                }
            }
            else
                return -1;
        }

        private void 更新程序_Shown(object sender, EventArgs e)
        {
            string upd_address = RegUtil.GetRegistryValue(PSOBBRegpath, UpdateADDRESS_Regkey);
            更新程序文字.Visible = true;
            更新程序进度条.Visible = true;
            int i = 0;
            for (; i < UpdateFILES.Length; i++)
            {
                if (System.Diagnostics.Process.GetProcessesByName(UpdateFILES[updated[i]]).Length > 0)
                {
                    MessageBox.Show("程序正在运行中，无法进行更新，请关闭后重新运行！");
                    Application.Exit();
                    break;
                }
                else
                {
                    if (updated[i] < i)
                    {
                        break;
                    }
                    HttpDownload(upd_address + UpdateFILES[updated[i]], UpdateFILES[updated[i]], 更新程序进度条, 更新程序文字, updated[i]);
                }
            }
            更新程序文字.Visible = false;
            更新程序进度条.Visible = false;
            更新文件列表.Visible = false;
            更新完成图片.Visible = true;
            MessageBox.Show("更新完成");
            Close();
        }

        private void 更新程序_Load(object sender, EventArgs e)
        {
            更新完成图片.Visible = true;
            更新程序文字.Visible = false;
            更新程序进度条.Visible = false;
            更新文件列表.Visible = false;
            string upd_address = RegUtil.GetRegistryValue(PSOBBRegpath, UpdateADDRESS_Regkey);
            //string[] upd_files = (string[])Registry.CurrentUser.OpenSubKey(PSOBBRegpath, true).GetValue(UpdateFILES_Regkey);
            if (ConvertTxtToDataSet(upd_address + "files.txt") == null)
            {
                Application.Exit();
            }
            else
            {
                UpdateFILES = ConvertTxtToDataSet(upd_address + "files.txt");
                //string[] upd_files = ConvertTxtToDataSet(upd_address + "files.txt");
                //MessageBox.Show(UpdateFILES[0] + UpdateFILES[1] + UpdateFILES[0]);
                bool need_upd = false;
                int i = 0;
                int ch = 0;
                for (; i < UpdateFILES.Length; i++)
                {
                    if (Check_File(UpdateFILES[i], upd_address + UpdateFILES[i], i) != -1)
                    {
                        更新完成图片.Visible = false;
                        更新文件列表.Visible = true;
                        //更新文件列表.Items.Add(UpdateFILES[i]);
                        updated[ch] = i;
                        ch++;
                        need_upd = true;
                    }
                }
                if (!need_upd)
                    Close();
            }
        }
    }
}
