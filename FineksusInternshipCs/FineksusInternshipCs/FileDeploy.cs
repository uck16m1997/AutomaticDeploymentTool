using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.AccessControl;
using System.IO;

namespace FineksusInternshipCs
{
    class FileDeploy
    {
        string source;
        string destination;
        public FileDeploy(string s,string d)
        {
            source = s;
            destination = d;
        }
        public string Install()
        {
            string fileName;
            string destFile;
            System.IO.Directory.CreateDirectory(destination);
            if (System.IO.Directory.Exists(source))
            {
                try
                {
                    string[] folders = System.IO.Directory.GetDirectories(source);
                    string foldername;
                    string destDirectory;
                    foreach(string folder in folders)
                    {
                        foldername = System.IO.Path.GetFileName(folder);
                        destDirectory = System.IO.Path.Combine(destination, foldername);
                        System.IO.Directory.CreateDirectory(destDirectory);
          
                        
                        
                        string[] fs = System.IO.Directory.GetFiles(folder);
                        foreach(string f in fs)
                        {
                            fileName = System.IO.Path.GetFileName(f);
                            destFile = System.IO.Path.Combine(destDirectory, fileName);
                            System.IO.File.Copy(f, destFile, true);
                        }
                        if (foldername == "Website")
                        {
                            DirectoryInfo dInfo = new DirectoryInfo(destDirectory);
                            DirectorySecurity dSecurity = dInfo.GetAccessControl();
                            dSecurity.AddAccessRule(new FileSystemAccessRule(@"IUSR", FileSystemRights.FullControl, InheritanceFlags.ObjectInherit | InheritanceFlags.ContainerInherit, PropagationFlags.NoPropagateInherit, AccessControlType.Allow));
                            System.IO.Directory.SetAccessControl(destDirectory, dSecurity);
                        }
                    }


                    string[] files = System.IO.Directory.GetFiles(source);

                    foreach (string s in files)
                    {
                        fileName = System.IO.Path.GetFileName(s);
                        destFile = System.IO.Path.Combine(destination, fileName);
                        System.IO.File.Copy(s, destFile, true);
                    }
                    return "t";
                }
                catch (Exception ex)
                {
                
                    return ex.Message;
                }
            }
            else
            {
                return "Source path couldn't be found";
            }
        }
    }
}
