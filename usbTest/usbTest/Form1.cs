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
using System.Diagnostics;

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
            RT.AppendText("["+DateTime.Now.ToShortTimeString()+"]"+ msg+"\r\n");
            Console.WriteLine(msg);
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg != CHANGE){return;}
            if (m.WParam.ToInt32() == INSERT)
            {
                log("新设备到达");
                DriveInfo[] ds= DriveInfo.GetDrives();
                foreach (var d in ds)
                {
                    if (d.DriveType == DriveType.Removable)
                    {
                        if (d.IsReady)
                        {
                            if (string.IsNullOrEmpty(d.VolumeLabel)) { d.VolumeLabel = "U盘"; }
                            log($"{d.Name}卷标为[{d.VolumeLabel}]已插入");
                            if (LB.Items.Count == 0)
                            {
                                name = d.Name;
                                if (RemoveD())
                                {
                                    log($"成功卸载{name}");
                                }
                                else
                                {
                                    log($"卸载失败{name}");
                                }
                                name = "";
                            }
                            else
                            {
                                foreach (var s in LB.Items)
                                {
                                    if ( s.ToString() == d.VolumeLabel)
                                    {
                                        name = d.Name;
                                        if (RemoveD())
                                        {
                                            log($"成功卸载{name}");
                                        }
                                        else
                                        {
                                            log($"卸载失败{name}");
                                        }
                                        name = "";
                                    }
                                }
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = true;
        }

        private void BtA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Vin.Text)) { return; }
            LB.Items.Add(Vin.Text);
        }

        private void BtD_Click(object sender, EventArgs e)
        {
            LB.Items.Remove(LB.SelectedItem);
        }

        private async void BtS_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            if (fd.ShowDialog () == DialogResult.OK)
            {
                FileStream fs = File.Create(fd.SelectedPath + "\\log-"+(DateTime.Now.ToShortDateString().Replace("/","."))+"-"+(DateTime.Now.ToShortTimeString().Replace(":","."))+".txt");
                fs.Write(Encoding.Default.GetBytes(RT.Text),0, Encoding.Default.GetBytes(RT.Text).Length);
                Process.Start("notepad.exe", fs.Name);
                fs.Close();
            }
        }
    }
}