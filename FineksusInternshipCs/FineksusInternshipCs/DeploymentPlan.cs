using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace FineksusInternshipCs
{
    public partial class DeploymentPlan : Form
    {
        public DeploymentPlan()
        {
            InitializeComponent();
            SetTexts();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("DeploymentPlan.xml");
            XmlNamespaceManager nsmgr = new XmlNamespaceManager(doc.NameTable);
            string xPathFile = "/DeploymentPlan/Item[@Type='" + "File" + "']/DestinationPath";
            XmlElement xmlEl = (XmlElement)doc.DocumentElement.SelectSingleNode(xPathFile, nsmgr);
            xmlEl.SetAttribute("Location", DestinationPathText.Text);


            xPathFile = "/DeploymentPlan/Item[@Type='" + "WindowsService" + "']/SourcePath";
            xmlEl = (XmlElement)doc.DocumentElement.SelectSingleNode(xPathFile, nsmgr);
            xmlEl.SetAttribute("Location", DestinationPathText.Text + "\\WinServ\\PayGateTestService.exe");

            xPathFile = "/DeploymentPlan/Item[@Type='" + "MSSQL" + "']/SourcePath";
            xmlEl = (XmlElement)doc.DocumentElement.SelectSingleNode(xPathFile, nsmgr);
            xmlEl.SetAttribute("Location", DestinationPathText.Text + "\\SQL\\testService.sql");

            xPathFile = "/DeploymentPlan/Item[@Type='" + "Website" + "']/SourcePath";
            xmlEl = (XmlElement)doc.DocumentElement.SelectSingleNode(xPathFile, nsmgr);
            xmlEl.SetAttribute("Location", DestinationPathText.Text + "\\Website");

            xPathFile = "/DeploymentPlan/Item[@Type='" + "WindowsService" + "']/Username";
            xmlEl = (XmlElement)doc.DocumentElement.SelectSingleNode(xPathFile, nsmgr);
            xmlEl.InnerText = WSUserText.Text;

            xmlEl = (XmlElement) xmlEl.NextSibling;

            if (WSPassEncrypt.Checked)
            {
                SHA256 hash = SHA256.Create();
                byte[] hashed = hash.ComputeHash(Encoding.UTF8.GetBytes(WSPassText.Text));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashed.Length; i++)
                {
                    builder.Append(hashed[i].ToString("x2"));
                }
                 xmlEl.InnerText = builder.ToString();
                xmlEl.SetAttribute("Encrypted", "True");
            }
            else
            {
                xmlEl.InnerText = WSPassText.Text;
                xmlEl.SetAttribute("Encrypted", "False");
            }
            

            xPathFile = "/DeploymentPlan/Item[@Type='" + "MSSQL" + "']/Server";
            xmlEl = (XmlElement)doc.DocumentElement.SelectSingleNode(xPathFile, nsmgr);
            xmlEl.InnerText = MSSQLServerText.Text;

            xmlEl = (XmlElement)xmlEl.NextSibling;
            xmlEl.InnerText = MSSQLPortText.Text;

            xmlEl = (XmlElement)xmlEl.NextSibling;
            xmlEl.InnerText = MSSQLUserText.Text;

            xmlEl = (XmlElement)xmlEl.NextSibling;
            if (MSSQLPassEncrypted.Checked)
            {
                SHA256 hash = SHA256.Create();
                byte[] hashed = hash.ComputeHash(Encoding.UTF8.GetBytes(MSSQLPassText.Text));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashed.Length; i++)
                {
                    builder.Append(hashed[i].ToString("x2"));
                }
                xmlEl.InnerText = builder.ToString();
                xmlEl.SetAttribute("Encrypted", "True");
            }
            else
            {
                xmlEl.InnerText = MSSQLPassText.Text;
                xmlEl.SetAttribute("Encrypted", "False");
            }
            

            xmlEl = (XmlElement)xmlEl.NextSibling;
            xmlEl.InnerText = MSSQLDBNameText.Text;

            doc.Save("DeploymentPlan.xml");
            this.Close();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("DeploymentPlan.xml");

            XmlNamespaceManager nsmgr = new XmlNamespaceManager(doc.NameTable);

            string xPathFile = "/DeploymentPlan/Item[@Type='" + "File" + "']/SourcePath";
            XmlElement xmlEl = (XmlElement)doc.DocumentElement.SelectSingleNode(xPathFile, nsmgr);
            XmlAttribute attr = xmlEl.GetAttributeNode("Location");

            string source = attr.InnerText;
            string destFile = "DeploymentPlan.xml";
            source = System.IO.Path.Combine(source, destFile);
            System.IO.File.Copy(source, destFile, true);
            SetTexts();
        }
        private void SetTexts()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("DeploymentPlan.xml");

            XmlNamespaceManager nsmgr = new XmlNamespaceManager(doc.NameTable);

            string xPathFile = "/DeploymentPlan/Item[@Type='" + "File" + "']/DestinationPath";
            XmlElement xmlEl = (XmlElement)doc.DocumentElement.SelectSingleNode(xPathFile, nsmgr);
            XmlAttribute attr = xmlEl.GetAttributeNode("Location");

            DestinationPathText.Text = attr.InnerText;

            xPathFile = "/DeploymentPlan/Item[@Type='" + "WindowsService" + "']/Username";
            XmlNode xmlNode = doc.DocumentElement.SelectSingleNode(xPathFile, nsmgr);
            WSUserText.Text = xmlNode.InnerText;

            xmlNode = xmlNode.NextSibling;
            xmlEl = (XmlElement)xmlNode;
            if (xmlEl.GetAttribute("Encrypted") == "True")
            {
                WSPassEncrypt.Checked = true;       
            }
            else {
                WSPassEncrypt.Checked = false;
                WSPassText.UseSystemPasswordChar = true;
            }
            WSPassText.Text = xmlNode.InnerText;

            xPathFile = "/DeploymentPlan/Item[@Type='" + "MSSQL" + "']/Server";
            xmlNode = doc.DocumentElement.SelectSingleNode(xPathFile, nsmgr);
            MSSQLServerText.Text = xmlNode.InnerText;

            xmlNode = xmlNode.NextSibling;
            MSSQLPortText.Text = xmlNode.InnerText;
            xmlNode = xmlNode.NextSibling;
            MSSQLUserText.Text = xmlNode.InnerText;
            xmlNode = xmlNode.NextSibling;
            xmlEl = (XmlElement)xmlNode;
            if (xmlEl.GetAttribute("Encrypted") == "True")
            {
                MSSQLPassEncrypted.Checked = true;
            }
            else {
                MSSQLPassEncrypted.Checked = false;
                MSSQLPassText.UseSystemPasswordChar = true;
            }
            MSSQLPassText.Text = xmlNode.InnerText;
            xmlNode = xmlNode.NextSibling;
            MSSQLDBNameText.Text = xmlNode.InnerText;
            
        }

        private void WSPassEncrypt_CheckedChanged(object sender, EventArgs e)
        {
            if(WSPassEncrypt.Checked) { WSPassText.UseSystemPasswordChar = true; }
            else { WSPassText.UseSystemPasswordChar = true; WSPassText.Text = ""; }
            
        }

        private void MSSQLPassEncrpyted_CheckedChanged(object sender, EventArgs e)
        {
            if (MSSQLPassEncrypted.Checked) { MSSQLPassText.UseSystemPasswordChar = true; }
            else { MSSQLPassText.UseSystemPasswordChar = true; MSSQLPassText.Text = ""; }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }


    }
}
