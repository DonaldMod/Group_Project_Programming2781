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
        SqlDataReader reader;
        public BindingSource bs = new BindingSource();
        public string strcon()
        {
            
            string newpath = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory
, @"..\..\Resources\Database\BCStudentsDB.mdf"));
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + newpath + @";Integrated Security=True;Connect Timeout=30";
        }
        //SQL connection object
        
        public DataHandler()
        {
            this.Sqlcon= new SqlConnection(this.strcon());
        }
        //Student Methods
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

        public void InsertStudents(int ID, string fname, string lname, byte[] image, DateTime DOB, string Gender, int phone, string Address, string Modules)
        {
            try
            {
                using (Sqlcon = new SqlConnection(strcon()))
                {
                    SqlCommand cmnd = new SqlCommand("spDeleteStudent", this.Sqlcon);
                    cmnd.CommandType = CommandType.StoredProcedure;
                    cmnd.Parameters.AddWithValue("@ID", ID);
                    cmnd.Parameters.AddWithValue("@FirstName", fname);
                    cmnd.Parameters.AddWithValue("@LastName", lname);
                    cmnd.Parameters.AddWithValue("@Image", image);
                    cmnd.Parameters.AddWithValue("@DOB", DOB);
                    cmnd.Parameters.AddWithValue("@Gender", Gender);
                    cmnd.Parameters.AddWithValue("@Phone", phone);
                    cmnd.Parameters.AddWithValue("@Address", Address);
                    cmnd.Parameters.AddWithValue("@MODULES", Modules);
                    Sqlcon.Open();
                    cmnd.ExecuteNonQuery();
                    Sqlcon.Close();

                    MessageBox.Show("Student has been Added");

                }
            }
            catch (Exception t)
            {

                MessageBox.Show(t.Message);
            }
            
        }

        public DataTable DisplayStudents()
        {
            using (Sqlcon = new SqlConnection(strcon()))
            {
                SqlCommand cmnd = new SqlCommand("spDisplayStudents", Sqlcon);
                cmnd.CommandType = CommandType.StoredProcedure;

                Sqlcon.Open();
                DataTable dt = new DataTable();
                using (reader = cmnd.ExecuteReader())
                {
                    dt.Load(reader);
                    return dt;
                }

                
                
            }
        }

        public DataTable searchStudent(int id)
        {
            using (Sqlcon = new SqlConnection(strcon()))
            {

                SqlCommand cmnd = new SqlCommand("spSelectStudentID", this.Sqlcon);
                cmnd.CommandType = CommandType.StoredProcedure;


                cmnd.Parameters.AddWithValue("@Id", id);

                Sqlcon.Open();
                DataTable dt = new DataTable();

                using (SqlDataReader dr = cmnd.ExecuteReader())
                {
                    dt.Load(dr);
                    return dt;
                }


            }

        }

        public void deleteStudent(int id)
        {
            try
            {
                using (Sqlcon = new SqlConnection(this.strcon()))
                {
                    SqlCommand cmnd = new SqlCommand("spDeleteStudent", this.Sqlcon);
                    cmnd.CommandType = CommandType.StoredProcedure;
                    cmnd.Parameters.AddWithValue("@ID",id);


                    Sqlcon.Open();
                    cmnd.ExecuteNonQuery();
                    Sqlcon.Close(); ;

                }
            }
            catch (Exception t)
            {
                MessageBox.Show(t.Message);
            }
            
        }

        public void UpdateStudents(int ID, string fname, string lname, DateTime DOB, string Gender, int phone, string Address, string Modules)
        {
            
            try
            {
                using (Sqlcon = new SqlConnection(this.strcon()))
                {
                    SqlCommand cmnd = new SqlCommand("spDeleteStudent", this.Sqlcon);
                    cmnd.CommandType = CommandType.StoredProcedure;
                    cmnd.Parameters.AddWithValue("@ID", ID);
                    cmnd.Parameters.AddWithValue("@FirstName", fname);
                    cmnd.Parameters.AddWithValue("@LastName", lname);
                    cmnd.Parameters.AddWithValue("@DOB", DOB);
                    cmnd.Parameters.AddWithValue("@Gender", Gender);
                    cmnd.Parameters.AddWithValue("@Phone", phone);
                    cmnd.Parameters.AddWithValue("@Address", Address);
                    cmnd.Parameters.AddWithValue("@MODULES", Modules);
                    Sqlcon.Open();
                    cmnd.ExecuteNonQuery();
                    Sqlcon.Close();

                }
            }
            catch (Exception t)
            {

                MessageBox.Show(t.Message);
            }
        }
        //Module Methods
        public DataTable DisplayModule()
        {

            using (Sqlcon = new SqlConnection(strcon()))
            {
                SqlCommand cmnd = new SqlCommand("spDisplayModules", this.Sqlcon);
                cmnd.CommandType = CommandType.StoredProcedure;

                Sqlcon.Open();
                DataTable dt = new DataTable();
                using (reader = cmnd.ExecuteReader())
                {
                    dt.Load(reader);
                    return dt;
                }



            }

        }

        public void InsertModule(string code, string name, string Description, string resources)
        {
            try
            {
                using (Sqlcon = new SqlConnection(this.strcon()))
                {
                    SqlCommand cmnd = new SqlCommand("spInserModule", this.Sqlcon);
                    cmnd.CommandType = CommandType.StoredProcedure;
                    cmnd.Parameters.AddWithValue("@ModuleName", name);
                    cmnd.Parameters.AddWithValue("@Description", Description);
                    cmnd.Parameters.AddWithValue("@Resources", resources);
                    cmnd.Parameters.AddWithValue("@Code", code);

                    Sqlcon.Open();
                    cmnd.ExecuteNonQuery();
                    Sqlcon.Close();
                }
            }
            catch (Exception t)
            {

                MessageBox.Show(t.Message);
            }
        }

        public void UpdateModule(string code, string name, string Description, string resources)
        {
            try
            {
                using (Sqlcon = new SqlConnection(this.strcon()))
                {
                    SqlCommand cmnd = new SqlCommand("spUpdateModule", this.Sqlcon);
                    cmnd.CommandType = CommandType.StoredProcedure;
                    cmnd.Parameters.AddWithValue("@Code", code);
                    cmnd.Parameters.AddWithValue("@ModuleName", name);
                    cmnd.Parameters.AddWithValue("@Description", Description);
                    cmnd.Parameters.AddWithValue("@Resources", resources);

                    Sqlcon.Open();
                    cmnd.ExecuteNonQuery();
                    Sqlcon.Close();
                }
            }
            catch (Exception t)
            {

                MessageBox.Show(t.Message);
            }
        }

        public void DeleteModule(string code)
        {
            try
            {
                using (Sqlcon = new SqlConnection(this.strcon()))
                {
                    SqlCommand cmnd = new SqlCommand("spDeleteModule", this.Sqlcon);
                    cmnd.CommandType = CommandType.StoredProcedure;
                    cmnd.Parameters.AddWithValue("@Code", code);
                    

                    Sqlcon.Open();
                    cmnd.ExecuteNonQuery();
                    Sqlcon.Close();
                }
            }
            catch (Exception t)
            {

                MessageBox.Show(t.Message);
            }
        }

        public DataTable SelectModule(string code)
        {
            using (Sqlcon = new SqlConnection(strcon()))
            {
                SqlCommand cmnd = new SqlCommand("spSelectModule", Sqlcon);
                cmnd.CommandType = CommandType.StoredProcedure;

                cmnd.Parameters.AddWithValue("@Code", code);

                Sqlcon.Open();
                DataTable dt = new DataTable();

                using (SqlDataReader dr = cmnd.ExecuteReader())
                {
                    dt.Load(dr);
                    return dt;
                }
            }
            
        }

    }
}



