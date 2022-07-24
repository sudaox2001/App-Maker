using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace ConsoleMakerTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string cscExec = System.Runtime.InteropServices.RuntimeEnvironment.GetRuntimeDirectory() + "csc.exe";
        
        private void Form1_Load(object sender, EventArgs e)
        {
            //if(!File.Exists("cons.cs"))
            //{
            //    MessageBox.Show("Template file does not exist. Compiling has been disabled");
            //    button1.Enabled = false;
            //    button1.Text = "Compile Disabled";
            //}
            //MessageBox.Show(netfwDir);
            //MessageBox.Show(cscExec);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string eConsole = File.ReadAllText("cons.cs");
            if (conW.Checked)
            {
                if (File.Exists("ConsoleApp.exe"))
                {
                    File.Delete("ConsoleApp.exe");
                }
                string eConsole = Properties.Resources.cons;
                string nConsole = eConsole.Replace("______replmw", textBox1.Text);
                nConsole = nConsole.Replace(@"\""", "");
                File.WriteAllText("ConsoleApp.cs", nConsole);
                File.WriteAllText("AssemblyInfo.cs", Properties.Resources.AssemblyInfo);
                //Process proc = Process.Start(cscExec, "ConsoleApp.cs AssemblyInfo.cs");
                Process proc = new Process();
                proc.StartInfo.FileName = cscExec;
                proc.StartInfo.Arguments = "ConsoleApp.cs AssemblyInfo.cs";
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.CreateNoWindow = true;
                proc.Start();
                proc.WaitForExit();
                File.Delete("ConsoleApp.cs");
                File.Delete("AssemblyInfo.cs");
                if (File.Exists("ConsoleApp.exe"))
                {
                    Process proc2 = Process.Start("ConsoleApp.exe");
                    proc2.WaitForExit();
                }
                else
                {
                    MessageBox.Show("Failed to compile");
                }
            }
            if (diaW.Checked)
            {
                if (File.Exists("DialogApp.exe"))
                {
                    File.Delete("DialogApp.exe");
                }
                string eConsole = Properties.Resources.diag;
                string nConsole = eConsole.Replace("______replmw", textBox1.Text);
                File.WriteAllText("DialogApp.cs", nConsole);
                File.WriteAllText("AssemblyInfo.cs", Properties.Resources.AssemblyInfo);
                Process proc = new Process();
                proc.StartInfo.FileName = cscExec;
                proc.StartInfo.Arguments = "DialogApp.cs AssemblyInfo.cs";
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.CreateNoWindow = true;
                proc.Start();
                proc.WaitForExit();
                File.Delete("DialogApp.cs");
                File.Delete("AssemblyInfo.cs");
                if (File.Exists("DialogApp.exe"))
                {
                    Process proc2 = Process.Start("DialogApp.exe");
                    proc2.WaitForExit();
                }
                else
                {
                    MessageBox.Show("Failed to compile");
                }
            }
        }

        private void ee1_Tick(object sender, EventArgs e)
        {
            this.Enabled = false;
            ee2.Enabled = true;
        }

        private void ee2_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int sW = Screen.PrimaryScreen.WorkingArea.Width;
            int sH = Screen.PrimaryScreen.WorkingArea.Height;
            int nWT = rnd.Next(0, sW);
            int nHT = rnd.Next(0, sH);
            this.Location = new Point(sW, sH);
        }
    }
}
