using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Windows.Forms;

namespace FineksusInternshipCs
{
    public partial class DownloadForm : Form
    {
        public DownloadForm(bool file, bool winserv, bool mssql, string f, string w, string m)
        {
        
            InitializeComponent();


            if (InstallFile())
            {
                FileDeployResult.Text = "Success";
                WinServDeployResult.Text = "Success";
                MSSQLDeployResult.Text = "Success";

            }
            else
            {

                FileDeployResult.Text = "Failure";
                WinServDeployResult.Text = "Failure";
                MSSQLDeployResult.Text = "Failure";
                

            }

            if (Convert.ToInt32(w)<Convert.ToInt32(m))
            {
                if (InstallService())
                {
                    WinServDeployResult.Text = "Success";
                    MSSQLDeployResult.Text = "Success";

                }
                else
                {
                    WinServDeployResult.Text = "Failure";
                    MSSQLDeployResult.Text = "Failure";
                }
                if (InstallSQL())
                {
                    MSSQLDeployResult.Text = "Success";
                }
                else
                {
                    MSSQLDeployResult.Text = "Failure";
                }
            }
            else
            {
                if (InstallSQL())
                {
                    WinServDeployResult.Text = "Success";
                    MSSQLDeployResult.Text = "Success";

                }
                else
                {
                    WinServDeployResult.Text = "Failure";
                    MSSQLDeployResult.Text = "Failure";
                }
                if (InstallService())
                {
                    WinServDeployResult.Text = "Success";
                }
                else
                {
                    WinServDeployResult.Text = "Failure";
                }
            }


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private bool InstallFile()
        {

            XmlDocument doc = new XmlDocument();
            doc.Load("DeploymentPlan.xml");

            XmlNamespaceManager nsmgr = new XmlNamespaceManager(doc.NameTable);

            string xPathFile = "/DeploymentPlan/Item[@Type='" + "File" + "']/DestinationPath";
            XmlElement xmlNode = (XmlElement)doc.DocumentElement.SelectSingleNode(xPathFile, nsmgr);
            XmlAttribute attr = xmlNode.GetAttributeNode("Location");

            string target = attr.InnerText;

            xPathFile = "/DeploymentPlan/Item[@Type='File']/SourcePath";
            xmlNode = (XmlElement)doc.DocumentElement.SelectSingleNode(xPathFile, nsmgr);
            attr = xmlNode.GetAttributeNode("Location");

            String source = attr.InnerText;
            FileDeploy fd = new FileDeploy(source, target);
            string s = fd.Install();
            if (s == "t")
            {
                return true;
            }
            else
            {
                ErrorBox.Text = s;
                ErrorBox.AppendText(Environment.NewLine);
                return false;
            }
        }
        private bool InstallService()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("DeploymentPlan.xml");
            XmlNamespaceManager nsmgr = new XmlNamespaceManager(doc.NameTable);

            string xPathFile = "/DeploymentPlan/Item[@Type='" + "WindowsService" + "']/SourcePath";
            XmlElement xmlNode = (XmlElement)doc.DocumentElement.SelectSingleNode(xPathFile, nsmgr);
            XmlAttribute loc = xmlNode.GetAttributeNode("Location");

            xPathFile = "/DeploymentPlan/Item[@Type='" + "WindowsService" + "']/Username";
            xmlNode = (XmlElement)doc.DocumentElement.SelectSingleNode(xPathFile, nsmgr);
            string user = xmlNode.InnerText;

            xPathFile = "/DeploymentPlan/Item[@Type='" + "WindowsService" + "']/Password";
            xmlNode = (XmlElement)doc.DocumentElement.SelectSingleNode(xPathFile, nsmgr);
            string pass = xmlNode.InnerText;


            WindowsService ws = new WindowsService(loc.InnerText, user, pass);
            string[] s =  ws.Install();
            if (s[0] == "t")
            {
                return true;
            }
            else
            {
                ErrorBox.AppendText(s[0]);
                ErrorBox.AppendText(Environment.NewLine);
                return false;
            }
            
        }
        private bool InstallSQL()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("DeploymentPlan.xml");
            XmlNamespaceManager nsmgr = new XmlNamespaceManager(doc.NameTable);

            string xPathFile = "/DeploymentPlan/Item[@Type='" + "MSSQL" + "']/SourcePath";
            XmlElement xmlEl = (XmlElement)doc.DocumentElement.SelectSingleNode(xPathFile, nsmgr);
            XmlAttribute loc = xmlEl.GetAttributeNode("Location");

            xPathFile = "/DeploymentPlan/Item[@Type='" + "MSSQL" + "']/Server";
            xmlEl = (XmlElement)doc.DocumentElement.SelectSingleNode(xPathFile, nsmgr);
            string serv = xmlEl.InnerText;

            xPathFile = "/DeploymentPlan/Item[@Type='" + "MSSQL" + "']/Port";
            xmlEl = (XmlElement)doc.DocumentElement.SelectSingleNode(xPathFile, nsmgr);
            int port = Convert.ToInt32(xmlEl.InnerText);

            xPathFile = "/DeploymentPlan/Item[@Type='" + "MSSQL" + "']/Username";
            xmlEl = (XmlElement)doc.DocumentElement.SelectSingleNode(xPathFile, nsmgr);
            string user = xmlEl.InnerText;

            xPathFile = "/DeploymentPlan/Item[@Type='" + "MSSQL" + "']/Password";
            xmlEl = (XmlElement)doc.DocumentElement.SelectSingleNode(xPathFile, nsmgr);
            string pass = xmlEl.InnerText;

            xPathFile = "/DeploymentPlan/Item[@Type='" + "MSSQL" + "']/DBName";
            xmlEl = (XmlElement)doc.DocumentElement.SelectSingleNode(xPathFile, nsmgr);
            string db = xmlEl.InnerText;

            SQLScript sqlScr = new SQLScript(serv,port,user,pass,db,loc.InnerText);
            string s = sqlScr.Install();
            if (s == "t")
            {
                return true;
            }
            else
            {
                ErrorBox.AppendText(s);
                ErrorBox.AppendText(Environment.NewLine);
                return false;
            }
        }
    }
}
