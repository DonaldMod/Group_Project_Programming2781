using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Group_Project_PRG2782
{
    class DataHandler
    {
        SqlConnection Sqlcon;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        SqlDataReader reader;
        public BindingSource bs = new BindingSource();

        public string strcon()
        {
            string path = Environment.CurrentDirectory;
            string newpath = Path.GetFullPath(Path.Combine(path, @"..\..\Resources\Database\BCStudentsDB.mdf"));
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + newpath + @";Integrated Security=True;Connect Timeout=30";
        }
        //SQL connection object
        
        public DataHandler()
        {
            this.Sqlcon= new SqlConnection(this.strcon());
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
                this.Sqlcon.Open();
                if (Sqlcon.State == System.Data.ConnectionState.Open )
                {
                    MessageBox.Show("The connection is open");
                }
                else
                {
                    MessageBox.Show("Connection was not established");
                }
                
            }
            catch (Exception y)
            {
                MessageBox.Show(y.Message);
            }
            finally { Sqlcon.Close(); }
        }
        public void SelectModule()
        {

            string sqlstring = @"Select * from Modules";
            this.Sqlcon.Open();
            using (cmd = new SqlCommand(sqlstring, this.Sqlcon))
            {
                reader = cmd.ExecuteReader();
                bs.DataSource = reader;
            }
            this.Sqlcon.Close();

        }

        public void UpdateStudents(int ID, string fname, string lname, byte[] image, DateTime DOB, string Gender, int phone, string Address, string Modules)
        {
            
            using (Sqlcon)
            {
                try
                {
                    cmd = new SqlCommand("spInsertStudents", this.Sqlcon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", ID);
                    cmd.Parameters.AddWithValue("@FirstName", fname);
                    cmd.Parameters.AddWithValue("@LastName", lname);
                    cmd.Parameters.AddWithValue("@Image", image);
                    cmd.Parameters.AddWithValue("@DOB", DOB);
                    cmd.Parameters.AddWithValue("@Gender", Gender);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Address", Address);
                    cmd.Parameters.AddWithValue("@MODULES", Modules);
                    this.Sqlcon.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception t)
                {
                    MessageBox.Show(t.Message);

                }
                finally
                {
                    this.Sqlcon.Close();
                }

            }
        }
        public DataTable DisplayStudents()
        {
            adapter = new SqlDataAdapter("spDisplayStudents", this.Sqlcon);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

    }
}



