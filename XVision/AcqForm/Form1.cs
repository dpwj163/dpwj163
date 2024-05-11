using MvCamCtrl.NET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;

namespace AcqDeviceForm
{
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();            
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            //Form r1 = (Form1)FormatterServices.GetUninitializedObject(typeof(Form1));
            //Form1 r2 = new Form1();
            // CCamera camerahk = new CCamera();
            var isconnected = MV_CC_IsDeviceConnected(IntPtr.Zero);

            Console.WriteLine(isconnected);
        }

        [DllImport("MvCameraControl.dll")]
        public static extern bool MV_CC_IsDeviceConnected(IntPtr handle);
    }
    [Serializable]
    public class MyClass
    {
        public int MyProperty { get; set; }

        public MyClass()
        {
            MyProperty = 10;
        }
    }
}
