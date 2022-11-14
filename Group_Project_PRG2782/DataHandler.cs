using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_Project_PRG2782
{
    class DataHandler
    {
        public SqlConnection Sqlcon;
        public string sqlString;
        SqlCommand cmd;
        SqlDataReader reader;

        private string strcon()
        {
            string path = Environment.CurrentDirectory;
            string newpath = Path.GetFullPath(Path.Combine(path, @"..\..\Resources\Database\BCStudentsDB.mdf"));
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + newpath + @";Integrated Security=True;Connect Timeout=30";
        }
        //SQL connection object
        
        public DataHandler()
        {
            Sqlcon = new SqlConnection(this.strcon());
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
        public void TestConnection()
        {
            try
            {
                Sqlcon.Open();
                if (Sqlcon.State == System.Data.ConnectionState.Open )
                {
                    MessageBox.Show("The connection is open");
                }
                else
                {
                    MessageBox.Show("Connection was not established");
                }
                Sqlcon.Close();
            }
            catch (Exception y)
            {
                MessageBox.Show(y.Message);
            }
        }
        public void GetStudentsTable()
        {
            
        }
    }
}



