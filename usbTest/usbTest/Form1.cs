using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace usbTest
{
    public partial class Form1 : Form
    {
        
        private string name = "";

        public const int CE = 0x2d4808;
        public Form1()
        {
            InitializeComponent();
        }

        private void log(string msg)
        {
            RT.AppendText(msg+"\r\n");
            Console.WriteLine(msg);
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg != CHANGE){return;}
            if (m.WParam.ToInt32() == INSERT)
            {
                log("d");
                DriveInfo[] ds= DriveInfo.GetDrives();
                foreach (var d in ds)
                {
                    if (d.DriveType == DriveType.Removable)
                    {
                        if (d.IsReady)
                        {
                            log($"{d.Name}卷标为{d.VolumeLabel}已插入");
                            name = d.Name;
                            if (RemoveD())
                            {
                                log("s");
                            }
                            else
                            {
                                log("n");
                            }
                        }
                    }
                }
            }
        }

        [DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true, CharSet = CharSet.Auto)]
        private static extern bool DeviceIoControl(
            IntPtr handle,
            uint ControlCode,
            IntPtr inbuffer,
            uint inbufsize,
            IntPtr outbuffer,
            uint otbufsize,
            out uint returnbyte,
            IntPtr overlapped
        );

        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        private static extern IntPtr CreateFile(
            string lpFileName,
            uint dwDesiredAccess,
            uint dwShareMode,
            IntPtr SecurityAttributes,
            uint dwCreationDisposition,
            uint dwFlagsAndAttributes,
            IntPtr hTemplateFile
        );

        private bool RemoveD()
        {
            string n = @"\\.\" + name[0]+":";
            IntPtr h = CreateFile(n, Convert.ToUInt32(ACC_READ | ACC_WRITE), FS_READ | FS_WRITE, IntPtr.Zero, 0x3,0, IntPtr.Zero);
            uint a;
            return DeviceIoControl(h,CE,IntPtr.Zero,0,IntPtr.Zero,0,out a,IntPtr.Zero);
        }
    }
}