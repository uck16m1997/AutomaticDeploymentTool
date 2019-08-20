using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Windows.Forms;

namespace FineksusInternshipCs
{
    public partial class StarterForm : Form
    {
        public StarterForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SelectionForm sform = new SelectionForm();
            this.Hide();
            sform.ShowDialog();
            this.Show();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeploymentPlan dPlan = new DeploymentPlan();
            this.Hide();
            dPlan.ShowDialog();
            this.Show();

            
        }



        private void button3_Click_1(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("DeploymentPlan.xml");
            XmlNamespaceManager nsmgr = new XmlNamespaceManager(doc.NameTable);
            string xPathFile = "/DeploymentPlan/Item[@Type='" + "Website" + "']/SourcePath";
            XmlElement xmlEl = (XmlElement)doc.DocumentElement.SelectSingleNode(xPathFile, nsmgr);
            XmlAttribute attr = xmlEl.GetAttributeNode("Location");


            if (Directory.Exists(attr.InnerText))
            {
                WebDeployer wd = new WebDeployer();
                this.Hide();
                wd.ShowDialog();
                this.Show();
            }
            else
            {
                string message = "You need to install the files first";
                MessageBox.Show(message);
            }
        }

        private void Logo_Click(object sender, EventArgs e)
        {

        }
    }
}
