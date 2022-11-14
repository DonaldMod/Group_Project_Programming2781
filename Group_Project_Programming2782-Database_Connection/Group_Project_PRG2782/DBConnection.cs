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
    class DBConnection
    {
        //Data source

        private string strcon()
        {
            string path = Environment.CurrentDirectory;
            string newpath = Path.GetFullPath(Path.Combine(path, @"..\..\Resources\Database\BCStudentsDB.mdf"));
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + newpath + @";Integrated Security=True;Connect Timeout=30";
        }
        //SQL connection object
        public SqlConnection Sqlcon;

        public DBConnection()
        {
            Sqlcon = new SqlConnection(this.strcon());
        }

        public DataTable executeSqlCommand(string sqlCommand)
        {
            DataTable dtTable = new DataTable();
            try
            {
                //open sql connection
                //this.Sqlcon.Open();
                //create sqlAdapter
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand, this.Sqlcon);
                dataAdapter.Fill(dtTable);
                //this.Sqlcon.Close();
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

        SqlDataAdapter moduleAdapter = new SqlDataAdapter();
        
        public void ModuleCreation(string code, string name, string desc, string link)
        {
            try
            {
                DataSet ds = new DataSet();

                moduleAdapter = new SqlDataAdapter($@"INSERT INTO [Modules]([Code],[ModuleName],[Description],[Resources])
VALUES ('{code}', '{name}', '{desc}', '{link}')", Sqlcon);

                moduleAdapter.Fill(ds, "Modules");

                MessageBox.Show("Module successfully created!");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        public DataSet ModuleRead()
        {
                DataSet ds = new DataSet();
            try
            {
                moduleAdapter = new SqlDataAdapter($@"SELECT *
FROM Modules", Sqlcon);
                moduleAdapter.Fill(ds, "Modules");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            return ds;
        }

        public void ModuleUpdate(string code, string name, string desc, string link)
        {
            try
            {
                DataSet ds = new DataSet();

                moduleAdapter = new SqlDataAdapter($@"UPDATE [Modules]
SET [ModuleName] = '{name}',[Description] = '{desc}',[Resources] = '{link}'
WHERE [Code] = '{code}'", Sqlcon);

                moduleAdapter.Fill(ds, "Modules");

                MessageBox.Show("Module successfully UPDATED!");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        public void ModuleDelete(string code)
        {
            try
            {
                DataSet ds = new DataSet();

                moduleAdapter = new SqlDataAdapter($@"DELETE FROM [Modules]
WHERE [Code] = '{code}'", Sqlcon);
                moduleAdapter.Fill(ds, "Modules");

                MessageBox.Show("Module successfully DELETED from Database!");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        public DataSet ModuleSearch(string code)
        {
                DataSet ds = new DataSet();
            try
            {

                moduleAdapter = new SqlDataAdapter($@"SELECT *
FROM [Modules]
WHERE [Code] = '{code}'", Sqlcon);
                moduleAdapter.Fill(ds, "Modules");

                MessageBox.Show("Module found successfully!");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            return ds;
        }
    }
}



