using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;

namespace FineksusInternshipCs
{
    public partial class WebDeployer : Form
    {
        Website ws;
        public WebDeployer()
        {
            InitializeComponent();
            XmlDocument doc = new XmlDocument();
            doc.Load("DeploymentPlan.xml");

            XmlNamespaceManager nsmgr = new XmlNamespaceManager(doc.NameTable);

            string xPathFile = "/DeploymentPlan/Item[@Type='" + "Website" + "']/SourcePath";
            XmlElement xmlEl = (XmlElement)doc.DocumentElement.SelectSingleNode(xPathFile, nsmgr);
            XmlAttribute attr = xmlEl.GetAttributeNode("Location");

            xmlEl = (XmlElement)xmlEl.NextSibling;
            string name = xmlEl.InnerText;

            xmlEl = (XmlElement)xmlEl.NextSibling;
            string pass = xmlEl.InnerText;

            ws = new Website(attr.InnerText, name, pass);
            SetState();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ws.StartSite();
            SetState();
            
        }

        private void SetState()
        {
            if (ws.IsRunning()) {
                StateText.Text = "Running";
            }
            else
            {
                StateText.Text = "Stopped";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ws.StopSite();
            SetState();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ws.Remove();
            ws.CreateAppPool();
            ws.CreateSite();
            SetState();
        }
    }
}
