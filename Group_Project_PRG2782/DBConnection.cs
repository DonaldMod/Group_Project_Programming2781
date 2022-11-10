using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Project_PRG2782
{
    class DBConnection
    {
        //Data Source
        private string filePath;
        
        private string strcon()
        {
            string path = Environment.CurrentDirectory;
            string newpath = Path.GetFullPath(Path.Combine(path, @"..\..\Resources\Database\BCStudents.mdf"));
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + newpath + @";Integrated Security=True;Connect Timeout=30";
        }

        //SQL connection object

        private SqlConnection sqlConn;

        public DBConnection()
        {
            sqlConn = new SqlConnection(this.strcon());
        }

        public DBConnection(string fileP)
        {
            this.filePath = fileP;
            sqlConn = new SqlConnection(this.strcon());
        }

        public DataTable executeSQLCommand(string sqlCommand)
        {
            DataTable dtTable = new DataTable();

            try
            {
                //open sql connection
                this.sqlConn.Open();
                // SQLAdapter
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand, this.sqlConn);
                dataAdapter.Fill(dtTable);
                this.sqlConn.Close();
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                dtTable = null;
                throw;
            }
            return dtTable;
            
        }
    }
}
