using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FineksusInternshipCs
{
    public partial class SelectionForm : Form
    {
        public SelectionForm()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DownloadForm frm2 = new DownloadForm(FileDeployCheck.Checked, WinServDeployCheck.Checked, MSSQLDeployCheck.Checked, FileDeployOrder.Text, WinServDeployOrder.Text, MSSQLDeployOrder.Text);
            this.Hide();
            frm2.ShowDialog();
            this.Close();
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!FileDeployCheck.Checked)
            {
                FileDeployOrder.Text = "";

                if (WinServDeployCheck.Checked && WinServDeployOrder.Text != "1")
                {
                    if (WinServDeployOrder.Text == "2" && MSSQLDeployOrder.Text != "1")
                    {
                        WinServDeployOrder.Text = "1";
                    }
                    else
                    {
                        WinServDeployOrder.Text = "2";
                    }
                }
                if (MSSQLDeployCheck.Checked && MSSQLDeployOrder.Text != "1")
                {
                    if (MSSQLDeployOrder.Text == "2" && FileDeployOrder.Text != "1")
                    {
                        MSSQLDeployOrder.Text = "1";
                    }
                    else
                    {
                        MSSQLDeployOrder.Text = "2";
                    }
                }

            }
            else
            {
                int i = 1;
                if (WinServDeployCheck.Checked) { i++; }

                if (MSSQLDeployCheck.Checked) { i++; }
                
                FileDeployOrder.Text = ""+i;
            }
        }

        private void WinServDeployCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (!WinServDeployCheck.Checked)
            {
                WinServDeployOrder.Text = "";

                if (FileDeployCheck.Checked && FileDeployOrder.Text != "1")
                {
                    if (FileDeployOrder.Text == "2" && MSSQLDeployOrder.Text != "1")
                    {
                        FileDeployOrder.Text = "1";
                    }
                    else
                    {
                        FileDeployOrder.Text = "2";
                    }
                }
                if (MSSQLDeployCheck.Checked && MSSQLDeployOrder.Text != "1")
                {
                    if (MSSQLDeployOrder.Text == "2" && FileDeployOrder.Text != "1")
                    {
                        MSSQLDeployOrder.Text = "1";
                    }
                    else
                    {
                        MSSQLDeployOrder.Text = "2";
                    }
                }
            }
            else
            {
                int i = 1;


                if (FileDeployCheck.Checked) { i++; }

                if (MSSQLDeployCheck.Checked) { i++; }

                WinServDeployOrder.Text = "" + i;
            }
        }

        private void MSSQLDeployCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (!MSSQLDeployCheck.Checked)
            {
                MSSQLDeployOrder.Text = "";
                if (FileDeployCheck.Checked && FileDeployOrder.Text != "1") {
                    if (FileDeployOrder.Text == "2" && WinServDeployOrder.Text != "1")
                    {
                        FileDeployOrder.Text = "1";
                    }
                    else
                    {
                        FileDeployOrder.Text = "2";
                    }       
                }
                if (WinServDeployCheck.Checked && WinServDeployOrder.Text != "1"){
                   if(WinServDeployOrder.Text =="2" && FileDeployOrder.Text != "1")
                    {
                        WinServDeployOrder.Text = "1";
                    }
                    else
                    {
                        WinServDeployOrder.Text = "2";
                    }
                }
            }
            else
            {
                int i = 1;
                if (FileDeployCheck.Checked) { i++; }
                
                if (WinServDeployCheck.Checked) { i++; }
               
                MSSQLDeployOrder.Text = "" + i;
            }
        }

        private void FileDeployOrder_TextChanged(object sender, EventArgs e)
        {
            if(FileDeployOrder.Text == ""){
                FileDeployCheck.Checked = false;
            }
            else if(FileDeployOrder.Text!="1" && FileDeployOrder.Text!="2" && FileDeployOrder.Text != "3")
            {
                FileDeployOrder.Text = "";
                FileDeployCheck.Checked = false;

            }
            else
            {
                FileDeployCheck.Checked = true;
            }
        }

        private void WinServDeployOrder_TextChanged(object sender, EventArgs e)
        {
            if (WinServDeployOrder.Text == "")
            {
                WinServDeployCheck.Checked = false;
            }
            else if ( WinServDeployOrder.Text != "1" && WinServDeployOrder.Text != "2" && WinServDeployOrder.Text != "3")
            {
                WinServDeployOrder.Text = "";
                WinServDeployCheck.Checked = false;
            }
            else
            {
                WinServDeployCheck.Checked = true;
            }
        }

        private void MSSQLDeployOrder_TextChanged(object sender, EventArgs e)
        {
            if(MSSQLDeployOrder.Text == "")
            {
                MSSQLDeployCheck.Checked = false;
            }
            else if (MSSQLDeployOrder.Text != "1" && MSSQLDeployOrder.Text != "2" && MSSQLDeployOrder.Text != "3")
            {
                MSSQLDeployOrder.Text = "";
                MSSQLDeployCheck.Checked = false;
            }
            else
            {
                MSSQLDeployCheck.Checked = true;
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
