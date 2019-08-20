using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Web.Administration;
using Microsoft.Web.Management;
using System.Threading.Tasks;


namespace FineksusInternshipCs
{
    class Website
    {
        ServerManager server;
        string source;
        string Username;
        string Password;
        ApplicationPool myAppPool = null;
        public Website(string s,string u, string p)
        {
            server = new ServerManager();
            source = s;
            Username = u;
            Password = p;
           
            CreateAppPool();
            CreateSite();
          

        }
        public bool IsRunning()
        {
            try
            {
                Site site = server.Sites.FirstOrDefault(s => s.Name == "Default Web Site");
                string state = site.State.ToString();
                if (state == "Started")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }


            
        }
        public void StopSite()
        {
            if (server.Sites != null && server.Sites.Count > 0)
            {

                if (server.Sites.FirstOrDefault(s => s.Name == "Default Web Site") != null)
                {

                    server.ApplicationPools.FirstOrDefault(prop => prop.Name == "MyApplicationPool").Stop();
                    server.Sites.FirstOrDefault(s => s.Name == "Default Web Site").Stop();


                }
            }
        }
    
        public void StartSite()
        {
            if (server.Sites != null && server.Sites.Count > 0)
            {
                
                if (server.Sites.FirstOrDefault(s => s.Name == "Default Web Site") != null)
                {

                    
                    server.ApplicationPools.FirstOrDefault(prop => prop.Name == "MyApplicationPool").Start();
                    server.Sites.FirstOrDefault(s => s.Name == "Default Web Site").Start();

       
                }
            }
        }
        public void Remove()
        {
            
            Site siteToRemove = server.Sites["Default Web Site"];

            server.Sites.Remove(siteToRemove);
            server.ApplicationPools.Remove(server.ApplicationPools.FirstOrDefault(p => p.Name == "MyApplicationPool"));

            server.CommitChanges();
        }
        public void CreateSite() {
            if (server.Sites != null && server.Sites.Count > 0)
            {

                SiteCollection sc = server.Sites;

                //we will first check to make sure that the site isn't already there
                if (server.Sites.FirstOrDefault(s => s.Name == "Default Web Site") == null)
                {
                    //we will just pick an arbitrary location for the site
                    string path = @source;

                    //we must specify the Binding information
                    string ip = "*";
                    string port = "81";
                    string hostName = "*";

                    string bindingInfo = string.Format(@"{0}:{1}:{2}", ip, port, hostName);

                    //add the new Site to the Sites collection
                    Site site = server.Sites.Add("Default Web Site", "http", bindingInfo, path);
    
                    //set the ApplicationPool for the new Site
                    site.ApplicationDefaults.ApplicationPoolName = myAppPool.Name;

                    //save the new Site!
                    server.CommitChanges();
                }
            }
            if (server.Sites.FirstOrDefault(s => s.Name == "Default Web Site") != null)
            {
                Site defaultSite = server.Sites["Default Web Site"];
                if (defaultSite.Applications.FirstOrDefault(a => a.Path == "/website") == null)
                {
                    defaultSite.Applications.Add("/website", @source);
                    server.CommitChanges();
                }
            }

        }
        public void CreateAppPool()
        {
            if (server.ApplicationPools != null && server.ApplicationPools.Count > 0)
            {
                if (server.ApplicationPools.FirstOrDefault(p => p.Name == "MyApplicationPool") != null)
                {
                    //if we find the pool already there, we will get a referecne to it for update
                    myAppPool = server.ApplicationPools.FirstOrDefault(p => p.Name == "MyApplicationPool");
                }
                else
                {
                    //if the pool is not already there we will create it
                    myAppPool = server.ApplicationPools.Add("MyApplicationPool");
                }
            }
            else
            {
                //if the pool is not already there we will create it
                myAppPool = server.ApplicationPools.Add("MyApplicationPool");
            }

            if (myAppPool != null)
            {
                //for this sample, we will set the pool to run under the NetworkService identity
                myAppPool.ProcessModel.IdentityType = ProcessModelIdentityType.LocalService;
                myAppPool.ProcessModel.UserName = Username;
                myAppPool.ProcessModel.Password = Password;

                //we set the runtime version
                myAppPool.ManagedRuntimeVersion = "v4.0";

                //we save our new ApplicationPool!
                server.CommitChanges();
            }
        }
    }
}
