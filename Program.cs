using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PSOBBLauncher
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        private static void Main()
        {
            {
                //获得当前登录的Windows用户标示
                System.Security.Principal.WindowsIdentity identity = System.Security.Principal.WindowsIdentity.GetCurrent();
                System.Security.Principal.WindowsPrincipal principal = new(identity);
                //判断当前登录用户是否为管理员
                if (principal.IsInRole(System.Security.Principal.WindowsBuiltInRole.Administrator))
                {
                    // 修改注册表  
                    //bool benable = RegeditControl.RegLocalMachine.IsPartEnable();
                    //if (benable)
                    {
                        Application.EnableVisualStyles();
                        Application.SetCompatibleTextRenderingDefault(false);

                        Application.Run(new 启动器());
                    }
                }
                else
                {
                    //创建启动对象
                    System.Diagnostics.ProcessStartInfo startInfo = new();
                    startInfo.UseShellExecute = true;
                    startInfo.WorkingDirectory = Environment.CurrentDirectory;
                    startInfo.FileName = Application.ExecutablePath;
                    //设置启动动作,确保以管理员身份运行
                    startInfo.Verb = "runas";
                    try
                    {
                        System.Diagnostics.Process.Start(startInfo);
                    }
                    catch (Exception exp)
                    {
                        System.Windows.Forms.MessageBox.Show(exp.Message);
                        return;
                    }
                    //退出
                    Application.Exit();
                }
            }
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new 启动器());
            //游戏设置 dlg = new 游戏设置();
            //dlg.ShowDialog();

            //if (dlg.ShowDialog() == DialogResult.OK) 
            //{ 
            //    Application.Run(new 启动器());
            //}
        }
    }
}
