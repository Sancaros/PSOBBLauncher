using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.CompilerServices;

namespace PSOBBLauncher
{
    public class WriteLog
    {
        /// <summary>
        /// 写入信息到文本文件
        /// </summary>
        /// <param name="FilePath">文件路径</param>
        /// <param name="Message">写入消息</param>
        [MethodImpl(MethodImplOptions.Synchronized)]
        public static void Log(string FilePath, string Message)
        {
            //如果文件不存在，则创建
            //注意：日志文件一天一个
            string DirectoryName = "启动器日志\\" +  FilePath + "\\";
            string FilePathName = DirectoryName + DateTime.Today.ToString("yyyyMMdd") + ".txt";
            string MessageString = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "  " + Message;
            try
            {
                if (!Directory.Exists(DirectoryName))
                {
                    Directory.CreateDirectory(DirectoryName);
                }
                if (!File.Exists(FilePathName))
                {
                    using FileStream fs = File.Create(FilePathName);
                    byte[] info = new UTF8Encoding(true).GetBytes(MessageString + "\r\n");
                    fs.Write(info, 0, info.Length);
                }
                else
                {
                    using StreamWriter _MyStream = new(FilePathName, true);
                    _MyStream.WriteLine(MessageString);
                    //_MyStream.WriteLine("------------------------");
                }
            }
            catch
            {
            }
        }
    }
}
