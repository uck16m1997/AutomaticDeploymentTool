using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FineksusInternshipCs
{
    class SQLScript
    {
        string server;
        int port;
        string username;
        string password;
        string source;
        string dbname;
        public SQLScript(string s, int p, string u,string pw , string d,string src)
        {
            source = src;
            server = s;
            port = p;
            username = u;
            password = pw;
            dbname = d;
        }
        public string Install()
        {
            try
            {
                string sqlConnectionString = @"Integrated Security=SSPI;Server=localhost;database=master";
                string script = File.ReadAllText(@""+source);
                SqlConnection conn = new SqlConnection(sqlConnectionString);
                IEnumerable<string> commandStrings = Regex.Split(script, @"^\s*GO\s*$", RegexOptions.Multiline | RegexOptions.IgnoreCase);
                conn.Open();
                foreach (string command in commandStrings)
                {
                    if (command.Trim() != "")
                    {
                        using (var sqlCom = new SqlCommand(command, conn))
                        {
                            sqlCom.ExecuteNonQuery();
                        }
                    }
                }
                conn.Close();

                string s = "t";
                
                return s;
            }
            catch (Exception ex)
            {
                string s = ex.Message;
                return s;
          
            }


  
        }
    }
}
