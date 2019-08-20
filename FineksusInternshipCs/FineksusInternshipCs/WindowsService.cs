using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Collections;
using System.Configuration.Install;
using System.Reflection;

namespace FineksusInternshipCs
{

    public class WindowsService

    {
        string source;
        string username;
        string password;

        public WindowsService(string s, string u, string p)
        {

            source = s;
            username = u;
            password = p;
        }

        public string[] Install()
        {
            string[] s = new string[] { source };
            try
            {
                ManagedInstallerClass.InstallHelper(s);
                s[0] = "t";
                return s;
            }
            catch (Exception ex)
            {
                s[0] = ex.Message;
                return s;
            }


        }
        public string[] UnInstall()
        {
            string[] s = new string[] { "/u", source };
            try
            {
                ManagedInstallerClass.InstallHelper(s);
                s[0] = "t";
                return s;
            }
            catch (Exception ex)
            {
                s[0] = ex.Message;
                return s;
            }
        }


    }


}
