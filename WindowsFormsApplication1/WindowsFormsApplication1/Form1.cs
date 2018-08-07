using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
   
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process proc = null;
            try
            {
                string targetDir = string.Format(@"%~dp0");
                proc = new Process();
                proc.StartInfo.WorkingDirectory = targetDir;
                proc.StartInfo.FileName = "6.5_PPC_320x320.bat";
                proc.StartInfo.Arguments = string.Format("10");
                proc.Start();
                proc.WaitForExit();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Occurred :{0},{1}", ex.Message, ex.StackTrace.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process proc = null;
            try
            {
                string targetDir = string.Format(@"%~dp0");
                proc = new Process();
                proc.StartInfo.WorkingDirectory = targetDir;
                proc.StartInfo.FileName = "6.5_PPC_240x320.bat";
                proc.StartInfo.Arguments = string.Format("10");
                proc.Start();
                proc.WaitForExit();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Occurred :{0},{1}", ex.Message, ex.StackTrace.ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process proc = null;
            try
            {
                string targetDir = string.Format(@"%~dp0");
                proc = new Process();
                proc.StartInfo.WorkingDirectory = targetDir;
                proc.StartInfo.FileName = "6.5_PPC_480x640.bat";
                proc.StartInfo.Arguments = string.Format("10");
                proc.Start();
                proc.WaitForExit();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Occurred :{0},{1}", ex.Message, ex.StackTrace.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process proc = null;
            try
            {
                string targetDir = string.Format(@"%~dp0");
                proc = new Process();
                proc.StartInfo.WorkingDirectory = targetDir;
                proc.StartInfo.FileName = "6.5_PPC_480x800.bat";
                proc.StartInfo.Arguments = string.Format("10");
                proc.Start();
                proc.WaitForExit();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Occurred :{0},{1}", ex.Message, ex.StackTrace.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process proc = null;
            try
            {
                string targetDir = string.Format(@"%~dp0");
                proc = new Process();
                proc.StartInfo.WorkingDirectory = targetDir;
                proc.StartInfo.FileName = "6.5_PPC_240x400.bat";
                proc.StartInfo.Arguments = string.Format("10");
                proc.Start();
                proc.WaitForExit();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Occurred :{0},{1}", ex.Message, ex.StackTrace.ToString());
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process proc = null;
            try
            {
                string targetDir = string.Format(@"%~dp0");
                proc = new Process();
                proc.StartInfo.WorkingDirectory = targetDir;
                proc.StartInfo.FileName = "6.5_SP_320x320.bat";
                proc.StartInfo.Arguments = string.Format("10");
                proc.Start();
                proc.WaitForExit();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Occurred :{0},{1}", ex.Message, ex.StackTrace.ToString());
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process proc = null;
            try
            {
                string targetDir = string.Format(@"%~dp0");
                proc = new Process();
                proc.StartInfo.WorkingDirectory = targetDir;
                proc.StartInfo.FileName = "6.5_SP_320x240.bat";
                proc.StartInfo.Arguments = string.Format("10");
                proc.Start();
                proc.WaitForExit();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Occurred :{0},{1}", ex.Message, ex.StackTrace.ToString());
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
    }
   

