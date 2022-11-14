using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Group_Project_PRG2782
{
    internal class LoginDataHandler
    {
        private string username, password;

        string loginDetailsPath;
        string path = Environment.CurrentDirectory;
        string[] ImportInfo;

        internal static List<LoginDataHandler> ImportList = new List<LoginDataHandler>();
        
        StreamWriter sw;
        StreamReader sr;

        public LoginDataHandler()
        {
        }

        public LoginDataHandler(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        public void DirectoryFinder()
        {
                loginDetailsPath = Path.GetFullPath( $@"{path}\..\..\Login Details.txt");
                
            
        }

        public void CreatingAccDetails()
        {
            DirectoryFinder();

            if (File.Exists(loginDetailsPath))
            {
                using (sw = new StreamWriter(loginDetailsPath, true))
                {
                    sw.WriteLine($@"{username},{password}");

                    MessageBox.Show("New user created successfully!!");
                }
            }
            else
            {
                MessageBox.Show("File does not exist!");
            }
        }

        public void ReadingPassWords()
        {
            DirectoryFinder();

            using (sr = new StreamReader(loginDetailsPath))
            {
                string line = sr.ReadLine();

                while (line != null)
                {
                    ImportInfo = line.Split(',');
                    ImportList.Add(new LoginDataHandler(ImportInfo[0], ImportInfo[1]));
                    line = sr.ReadLine();
                }
            }
        }
    }
}
