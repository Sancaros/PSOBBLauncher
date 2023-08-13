using System;
using System.Threading;
using System.Reflection;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.Diagnostics;

namespace RegistryUtils
{
    public enum RegChangeNotifyFilter
    {
        Key = 1,//REG_NOTIFY_CHANGE_NAME   =   1   
        Attribute = 2,//REG_NOTIFY_CHANGE_ATTRIBUTES   =   2   
        Value = 4,//REG_NOTIFY_CHANGE_LAST_SET   =   4   
        Security = 8,//REG_NOTIFY_CHANGE_SECURITY   =   8   
    }

    public class RegistryMonitor : IDisposable
    {
        #region   DllImport   
        [DllImport("advapi32.dll")]
        private static extern Int32 RegNotifyChangeKeyValue(IntPtr hKey, bool bWatchSubtree, RegChangeNotifyFilter dwNotifyFilter, IntPtr hEvent, bool fAsynchronous);
        #endregion
        #region   Event   handling   
        public event EventHandler RegChanged;
        public event System.IO.ErrorEventHandler Error;
        #endregion
        #region   Private   member   variables   
        private RegistryKey registryKey;
        private Thread thread;
        private readonly AutoResetEvent eventNotify = new(false);
        private readonly ManualResetEvent eventTerminate = new(false);
        private RegChangeNotifyFilter regFilter = RegChangeNotifyFilter.Key | RegChangeNotifyFilter.Attribute | RegChangeNotifyFilter.Value | RegChangeNotifyFilter.Security;
        private Exception thrownException = null;
        #endregion
        public RegistryMonitor(RegistryKey registryKey)
        {
            this.registryKey = registryKey;
        }
        public RegistryMonitor()
        {
        }
        public void Dispose()
        {
            Stop();
        }

        public RegChangeNotifyFilter RegChangeNotifyFilter
        {
            get { return regFilter; }
            set
            {
                if (IsMonitoring)
                    throw new InvalidOperationException("Monitoring   thread   is   already   running");
                regFilter = value;
            }
        }
        public RegistryKey RegistryKey
        {
            get { return registryKey; }
            set
            {
                if (IsMonitoring)
                    throw new InvalidOperationException("Monitoring   thread   is   already   running");

                registryKey = value;
            }
        }
        public Exception ThrownException
        {
            get { return thrownException; }
        }
        public bool IsMonitoring
        {
            get { return thread != null; }
        }
        public static IntPtr GetRegistryHandle(RegistryKey registryKey)
        {
            Type type = registryKey.GetType();
            FieldInfo fieldInfo = type.GetField("hkey", BindingFlags.Instance | BindingFlags.NonPublic);
            return (IntPtr)fieldInfo.GetValue(registryKey);
        }

        [Obsolete]
        private bool WaitForChange()
        {
            WaitHandle[] waitHandles = new WaitHandle[] { eventNotify, eventTerminate };
            Int32 retValue = RegNotifyChangeKeyValue(GetRegistryHandle(registryKey), true, regFilter, eventNotify.Handle, true);
            if (retValue == 0)
            {
                return WaitHandle.WaitAny(waitHandles) == 0;
            }
            else
            {
                throw new System.ComponentModel.Win32Exception(retValue, "RegNotifyChangeKeyValue");
            }
        }

        [Obsolete]
        public void Start()
        {
            if (!IsMonitoring)
            {
                eventTerminate.Reset();
                thread = new Thread(new ThreadStart(ThreadLoop))
                {
                    IsBackground = true
                };
                thread.Start();
            }
        }
        public void Stop()
        {
            if (IsMonitoring)
            {
                eventTerminate.Set();
                thread.Join();
                thread = null;
            }
        }

        [Obsolete]
        private void ThreadLoop()
        {
            try
            {
                while (!eventTerminate.WaitOne(0, true))
                {
                    if (WaitForChange())
                    {
                        RegChanged?.Invoke(this, EventArgs.Empty);
                    }
                }
            }
            catch (Exception e)
            {
                thrownException = e;

                Error?.Invoke(this, new System.IO.ErrorEventArgs(e));

                thread = null;
            }
        }
    }
}