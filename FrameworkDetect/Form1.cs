using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Campari.Software;

namespace FrameworkDetect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                bool fx10Installed = FrameworkVersionDetection.IsInstalled(FrameworkVersion.Fx10);
                bool fx11Installed = FrameworkVersionDetection.IsInstalled(FrameworkVersion.Fx11);
                bool fx20Installed = FrameworkVersionDetection.IsInstalled(FrameworkVersion.Fx20);
                bool fx30Installed = FrameworkVersionDetection.IsInstalled(FrameworkVersion.Fx30);
                bool fx35Installed = FrameworkVersionDetection.IsInstalled(FrameworkVersion.Fx35);
                bool fx40Installed = FrameworkVersionDetection.IsInstalled(FrameworkVersion.Fx40);
                bool fx45Installed = FrameworkVersionDetection.IsInstalled(FrameworkVersion.Fx45);

                treeView1.Nodes.Add(string.Format("{0} ({1})", Environment.MachineName, Environment.OSVersion.VersionString));
                TreeNode tn;

                tn = new TreeNode();
                tn.ForeColor = Color.Green;
                tn.Name = "System";
                tn.Text = "System";
                tn.Nodes.Add("ProductName: " + FrameworkVersionDetection.GetSystemInfo(SystemInfoType.ProductName));
                tn.Nodes.Add("Processor: " + FrameworkVersionDetection.GetSystemInfo(SystemInfoType.CPU));
                tn.Nodes.Add("Installed memory(RAM): " + FrameworkVersionDetection.GetSystemInfo(SystemInfoType.Memory));
                tn.Nodes.Add("System type");
                
                treeView1.Nodes[0].Nodes.Add(tn);

                if (fx10Installed)
                {
                    tn = new TreeNode();
                    tn.ForeColor = Color.Green;
                    tn.Name = ".NET Framework 1.0";
                    tn.Text = ".NET Framework 1.0";
                    tn.Nodes.Add("Exact Version: " + FrameworkVersionDetection.GetExactVersion(FrameworkVersion.Fx10));
                    tn.Nodes.Add("Service Pack: " + FrameworkVersionDetection.GetServicePackLevel(FrameworkVersion.Fx10));
                    treeView1.Nodes[0].Nodes.Add(tn);
                }
                else
                {
                    tn = new TreeNode();
                    tn.ForeColor = Color.Red;
                    tn.Name = ".NET Framework 1.0";
                    tn.Text = ".NET Framework 1.0";
                    treeView1.Nodes[0].Nodes.Add(tn);
                }

                if (fx11Installed)
                {
                    tn = new TreeNode();
                    tn.ForeColor = Color.Green;
                    tn.Name = ".NET Framework 1.1";
                    tn.Text = ".NET Framework 1.1";
                    tn.Nodes.Add("Exact Version: " + FrameworkVersionDetection.GetExactVersion(FrameworkVersion.Fx11));
                    tn.Nodes.Add("Service Pack: " + FrameworkVersionDetection.GetServicePackLevel(FrameworkVersion.Fx11));
                    treeView1.Nodes[0].Nodes.Add(tn);
                }
                else
                {
                    tn = new TreeNode();
                    tn.ForeColor = Color.Red;
                    tn.Name = ".NET Framework 1.1";
                    tn.Text = ".NET Framework 1.1";
                    treeView1.Nodes[0].Nodes.Add(tn);
                }

                if (fx20Installed)
                {
                    tn = new TreeNode();
                    tn.ForeColor = Color.Green;
                    tn.Name = ".NET Framework 2.0";
                    tn.Text = ".NET Framework 2.0";
                    tn.Nodes.Add("Exact Version: " + FrameworkVersionDetection.GetExactVersion(FrameworkVersion.Fx20));
                    tn.Nodes.Add("Service Pack: " + FrameworkVersionDetection.GetServicePackLevel(FrameworkVersion.Fx20));
                    treeView1.Nodes[0].Nodes.Add(tn);
                }
                else
                {
                    tn = new TreeNode();
                    tn.ForeColor = Color.Red;
                    tn.Name = ".NET Framework 2.0";
                    tn.Text = ".NET Framework 2.0";
                    treeView1.Nodes[0].Nodes.Add(tn);
                }

                if (fx30Installed)
                {
                    tn = new TreeNode();
                    tn.ForeColor = Color.Green;
                    tn.Name = ".NET Framework 3.0";
                    tn.Text = ".NET Framework 3.0";
                    tn.Nodes.Add("Exact Version: " + FrameworkVersionDetection.GetExactVersion(FrameworkVersion.Fx30));
                    tn.Nodes.Add("Service Pack: " + FrameworkVersionDetection.GetServicePackLevel(FrameworkVersion.Fx30));
                    treeView1.Nodes[0].Nodes.Add(tn);
                }
                else
                {
                    tn = new TreeNode();
                    tn.ForeColor = Color.Red;
                    tn.Name = ".NET Framework 3.0";
                    tn.Text = ".NET Framework 3.0";
                    treeView1.Nodes[0].Nodes.Add(tn);
                }

                if (fx35Installed)
                {
                    tn = new TreeNode();
                    tn.ForeColor = Color.Green;
                    tn.Name = ".NET Framework 3.5";
                    tn.Text = ".NET Framework 3.5";
                    tn.Nodes.Add("Exact Version: " + FrameworkVersionDetection.GetExactVersion(FrameworkVersion.Fx35));
                    tn.Nodes.Add("Service Pack: " + FrameworkVersionDetection.GetServicePackLevel(FrameworkVersion.Fx35));
                    treeView1.Nodes[0].Nodes.Add(tn);
                }
                else
                {
                    tn = new TreeNode();
                    tn.ForeColor = Color.Red;
                    tn.Name = ".NET Framework 3.5";
                    tn.Text = ".NET Framework 3.5";
                    treeView1.Nodes[0].Nodes.Add(tn);
                }

                if (fx40Installed)
                {
                    tn = new TreeNode();
                    tn.ForeColor = Color.Green;
                    tn.Name = ".NET Framework 4.0";
                    tn.Text = ".NET Framework 4.0";
                    tn.Nodes.Add("Exact Version: " + FrameworkVersionDetection.GetExactVersion(FrameworkVersion.Fx40));
                    tn.Nodes.Add("Service Pack: " + FrameworkVersionDetection.GetServicePackLevel(FrameworkVersion.Fx40));
                    treeView1.Nodes[0].Nodes.Add(tn);
                }
                else
                {
                    tn = new TreeNode();
                    tn.ForeColor = Color.Red;
                    tn.Name = ".NET Framework 4.0";
                    tn.Text = ".NET Framework 4.0";
                    treeView1.Nodes[0].Nodes.Add(tn);
                }

                if (fx45Installed)
                {
                    tn = new TreeNode();
                    tn.ForeColor = Color.Green;
                    tn.Name = ".NET Framework 4.5 or later";
                    tn.Text = ".NET Framework 4.5 or later";
                    tn.Nodes.Add("Exact Version: " + FrameworkVersionDetection.GetExactVersion(FrameworkVersion.Fx45));
                    tn.Nodes.Add("Service Pack: " + FrameworkVersionDetection.GetServicePackLevel(FrameworkVersion.Fx45));
                    treeView1.Nodes[0].Nodes.Add(tn);
                }
                else
                {
                    tn = new TreeNode();
                    tn.ForeColor = Color.Red;
                    tn.Name = ".NET Framework 4.5 or later";
                    tn.Text = ".NET Framework 4.5 or later";
                    treeView1.Nodes[0].Nodes.Add(tn);
                }


                bool fx30PlusWCFInstalled = FrameworkVersionDetection.IsInstalled(WindowsFoundationLibrary.WCF);
                bool fx30PlusWPFInstalled = FrameworkVersionDetection.IsInstalled(WindowsFoundationLibrary.WPF);
                bool fx30PlusWFInstalled = FrameworkVersionDetection.IsInstalled(WindowsFoundationLibrary.WF);
                bool fx30PlusCardSpacesInstalled = FrameworkVersionDetection.IsInstalled(WindowsFoundationLibrary.CardSpace);


                if (fx30PlusWCFInstalled)
                {
                    tn = new TreeNode();
                    tn.ForeColor = Color.Green;
                    tn.Name = "WCF";
                    tn.Text = "WCF";
                    tn.Nodes.Add("Exact Version: " + FrameworkVersionDetection.GetExactVersion(WindowsFoundationLibrary.WCF));
                    treeView1.Nodes[0].Nodes.Add(tn);
                }

                if (fx30PlusWPFInstalled)
                {
                    tn = new TreeNode();
                    tn.ForeColor = Color.Green;
                    tn.Name = "WPF";
                    tn.Text = "WPF";
                    tn.Nodes.Add("Exact Version: " + FrameworkVersionDetection.GetExactVersion(WindowsFoundationLibrary.WPF));
                    treeView1.Nodes[0].Nodes.Add(tn);
                }

                if (fx30PlusWFInstalled)
                {
                    tn = new TreeNode();
                    tn.ForeColor = Color.Green;
                    tn.Name = "WF";
                    tn.Text = "WF";
                    tn.Nodes.Add("Exact Version: " + FrameworkVersionDetection.GetExactVersion(WindowsFoundationLibrary.WF));
                    treeView1.Nodes[0].Nodes.Add(tn);
                }

                if (fx30PlusCardSpacesInstalled)
                {
                    tn = new TreeNode();
                    tn.ForeColor = Color.Green;
                    tn.Name = "Card Space";
                    tn.Text = "Card Space";
                    tn.Nodes.Add("Exact Version: " + FrameworkVersionDetection.GetExactVersion(WindowsFoundationLibrary.CardSpace));
                    treeView1.Nodes[0].Nodes.Add(tn);
                }

                treeView1.Nodes[0].Expand();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
