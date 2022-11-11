using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Project_PRG2782
{
    internal class DBConnection
    {
        //Data source
        private string filePath;

        private string strcon()
        {
            string path = Environment.CurrentDirectory;
            string newpath = Path.GetFullPath(Path.Combine(path, @"..\..\BCStudents.mdf"));
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + newpath + @";Integrated Security=True;Connect Timeout=30";
        }
        //SQL connection object
        private SqlConnection Sqlcon;

        public DBConnection()
        {
            Sqlcon = new SqlConnection(this.strcon());
        }

        public DBConnection(string fileP)
        {
            this.filePath = fileP;
            fileP = extractDBLocation(fileP);
            Sqlcon = new SqlConnection(this.strcon());
        }

        string extractDBLocation(string fileP)
        {
            int iLength = fileP.Length;

            if (fileP.EndsWith(@"bin\Debug"))
            {
                fileP = fileP.Substring(0, iLength - 9);
                iLength = fileP.Length;
                fileP = fileP.Insert(iLength, @"BCStudents.mdf");
            }
            else
            {
                iLength = fileP.Length;
                fileP = fileP.Insert(iLength, @"BCStudents.mdf");
            }

            return fileP;
        }

        public DataTable executeSqlCommand(string sqlCommand)
        {
            DataTable dtTable = new DataTable();
            try
            {
                //open sql connection
                this.Sqlcon.Open();
                //create sqlAdapter
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand, this.Sqlcon);
                dataAdapter.Fill(dtTable);
                this.Sqlcon.Close();
            }
            catch (Exception error)
            {
                Console.Write(error.ToString());
                dtTable = null;
            }
            return dtTable;
        }
    }
}
