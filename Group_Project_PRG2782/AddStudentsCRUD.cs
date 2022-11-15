using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_Project_PRG2782
{
    class AddStudentsCRUD
    {

        DataHandler data = new DataHandler();  
        SqlConnection SqlConn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        SqlDataReader reader;
        public BindingSource bs = new BindingSource();

        public void SelectModule()
        {
            
            SqlConn =new SqlConnection(data.strcon());
            string sqlstring = @"Select * from Modules where Code = @ModuleCode";
            SqlConn.Open();
            using (cmd = new SqlCommand(sqlstring, SqlConn))
            {
                reader =cmd.ExecuteReader();
                bs.DataSource = reader;
            }
            SqlConn.Close();
            
        }

        public void UpdateStudents(int ID, string fname, string lname, Image image, DateTime DOB, string Gender, int phone, string Address, string Modules)
        {
            using (SqlConn = new SqlConnection(data.strcon()))
            {
                cmd = new SqlCommand("spInsertStudents", SqlConn);
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

                SqlConn.Open();
                cmd.ExecuteNonQuery();
                SqlConn.Close();
            }
        }
    }
}
