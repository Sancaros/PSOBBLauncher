using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using PSOBBLauncher;

namespace ToolUtils
{
    public static class RegUtil
    {
        static readonly IntPtr HKEY_CLASSES_ROOT = new(unchecked((int)0x80000000));
        static readonly IntPtr HKEY_CURRENT_USER = new(unchecked((int)0x80000001));
        static readonly IntPtr HKEY_LOCAL_MACHINE = new(unchecked((int)0x80000002));
        static readonly IntPtr HKEY_USERS = new(unchecked((int)0x80000003));
        static readonly IntPtr HKEY_PERFORMANCE_DATA = new(unchecked((int)0x80000004));
        static readonly IntPtr HKEY_CURRENT_CONFIG = new(unchecked((int)0x80000005));
        static readonly IntPtr HKEY_DYN_DATA = new(unchecked((int)0x80000006));

        // 获取操作Key值句柄 
        [DllImport("Advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int RegOpenKeyEx(IntPtr hKey, string lpSubKey, uint ulOptions, int samDesired, out IntPtr phkResult);

        //创建或打开Key值
        [DllImport("Advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int RegCreateKeyEx(IntPtr hKey, string lpSubKey, int reserved, string type, int dwOptions, int REGSAM, IntPtr lpSecurityAttributes, out IntPtr phkResult,
                                                 out int lpdwDisposition);

        //关闭注册表转向（禁用特定项的注册表反射）
        [DllImport("Advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int RegDisableReflectionKey(IntPtr hKey);

        //使能注册表转向（开启特定项的注册表反射）
        [DllImport("Advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int RegEnableReflectionKey(IntPtr hKey);

        //获取Key值（即：Key值句柄所标志的Key对象的值）
        [DllImport("Advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int RegQueryValueEx(IntPtr hKey, string lpValueName, int lpReserved, out uint lpType, StringBuilder lpData, ref uint lpcbData);

        //设置Key值
        [DllImport("Advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int RegSetValueEx(IntPtr hKey, string lpValueName, uint unReserved, uint unType, byte[] lpData, uint dataCount);

        //关闭Key值
        [DllImport("Advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int RegCloseKey(IntPtr hKey);

        public static IntPtr TransferKeyName(string keyName)
        {
            var ret = keyName switch
            {
                "HKEY_CLASSES_ROOT" => HKEY_CLASSES_ROOT,
                "HKEY_CURRENT_USER" => HKEY_CURRENT_USER,
                "HKEY_LOCAL_MACHINE" => HKEY_LOCAL_MACHINE,
                "HKEY_USERS" => HKEY_USERS,
                "HKEY_PERFORMANCE_DATA" => HKEY_PERFORMANCE_DATA,
                "HKEY_CURRENT_CONFIG" => HKEY_CURRENT_CONFIG,
                "HKEY_DYN_DATA" => HKEY_DYN_DATA,
                _ => HKEY_LOCAL_MACHINE,
            };
            return ret;
        }

        /// <summary>
        /// 设置64位注册表
        /// </summary>
        /// <param name="key"></param>
        /// <param name="subKey"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int Set64BitRegistryKey(string key, string subKey, string name, string value)
        {
            int STANDARD_RIGHTS_ALL = (0x001F0000);
            int KEY_QUERY_VALUE = (0x0001);
            int KEY_SET_VALUE = (0x0002);
            int KEY_CREATE_SUB_KEY = (0x0004);
            int KEY_ENUMERATE_SUB_KEYS = (0x0008);
            int KEY_NOTIFY = (0x0010);
            int KEY_CREATE_LINK = (0x0020);
            int SYNCHRONIZE = (0x00100000);
            int KEY_WOW64_64KEY = (0x0100);
            int REG_OPTION_NON_VOLATILE = (0x00000000);
            int KEY_ALL_ACCESS = (STANDARD_RIGHTS_ALL | KEY_QUERY_VALUE | KEY_SET_VALUE | KEY_CREATE_SUB_KEY | KEY_ENUMERATE_SUB_KEYS
                                 | KEY_NOTIFY | KEY_CREATE_LINK) & (~SYNCHRONIZE);

            int ret;
            try
            {
                //将Windows注册表主键名转化成为不带正负号的整形句柄（与平台是32或者64位有关）
                IntPtr hKey = TransferKeyName(key);

                //声明将要获取Key值的句柄 
                IntPtr pHKey = IntPtr.Zero;

                //获得操作Key值的句柄
                ret = RegCreateKeyEx(hKey, subKey, 0, "", REG_OPTION_NON_VOLATILE, KEY_ALL_ACCESS | KEY_WOW64_64KEY, IntPtr.Zero, out pHKey, out int lpdwDisposition);
                if (ret != 0)
                {
                    WriteLog.Log("err", string.Format("无法注册键值 {0} - {1}: {2}!", key, subKey, ret));
                    return ret;
                }

                //关闭注册表转向（禁止特定项的注册表反射）
                RegDisableReflectionKey(pHKey);

                //设置访问的Key值
                uint REG_SZ = 1;
                byte[] data = Encoding.Unicode.GetBytes(value);

                RegSetValueEx(pHKey, name, 0, REG_SZ, data, (uint)data.Length);

                //打开注册表转向（开启特定项的注册表反射）
                RegEnableReflectionKey(pHKey);

                RegCloseKey(pHKey);
            }
            catch (Exception ex)
            {
                WriteLog.Log("err", ex.ToString());
                return -1;
            }

            return ret;
        }

        public static void SetRegistryKey(string key, string subKey, string name, string value, RegistryValueKind valueKind)
        {
            //WriteLog.Log("err", "SetRegistryKey 开始.");
            if (IntPtr.Size == 8)
            {
                // 写SOFTWARE\Huawei\VirtualDesktopAgent，需要关闭注册表重定向，再写64位路径的注册表
                int ret = RegUtil.Set64BitRegistryKey(key, subKey, name, value);
                if (ret != 0)
                {
                    WriteLog.Log("err", string.Format("无法写入注册表 {0}\\{1}\\{2},return {3}", key, subKey, name, ret));
                }
            }

            try
            {
                Registry.SetValue(key + "\\" + subKey, name, value, valueKind);
            }
            catch (Exception ex)
            {
                WriteLog.Log("err", ex.ToString());
            }

            //WriteLog.Log("err", "SetRegistryKey 退出.");
        }

        public static string GetRegistryValue(string path, string key)
        {
            RegistryKey regkey = null;
            try
            {
                regkey = Registry.CurrentUser.OpenSubKey(path, true);
                if (regkey == null)
                {
                    WriteLog.Log("err", "注册表路径无效:" + path);
                    return null;
                }

                object val = regkey.GetValue(key);
                if (val == null)
                {
                    WriteLog.Log("err", "注册表值无效:" + key);
                    return null;
                }

                return val.ToString();
            }
            catch (Exception ex)
            {
                WriteLog.Log("err", ex.ToString());
                return null;
            }
            finally
            {
                if (regkey != null)
                {
                    regkey.Close();
                }
            }
        }
    }
}