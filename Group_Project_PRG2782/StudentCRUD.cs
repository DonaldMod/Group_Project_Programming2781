using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;

namespace Group_Project_PRG2782
{
    class StudentCRUD
    {
        DataHandler data = new DataHandler();
        public string sqlString;
        SqlCommand cmd;
        SqlConnection sqlConn;


        public void UpdateStudents(int ID, string fname,string lname, Image image, DateTime DOB, string Gender, int phone, string Address, string Modules)
        {
            using (sqlConn = new SqlConnection(data.strcon()))
            {
                cmd = new SqlCommand("spInsertStudents", sqlConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@FirstName", fname);
                cmd.Parameters.AddWithValue("@LastName",lname);
                cmd.Parameters.AddWithValue("@Image", image);
                cmd.Parameters.AddWithValue("@DOB",DOB);
                cmd.Parameters.AddWithValue("@Gender",Gender);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@Address", Address);
                cmd.Parameters.AddWithValue("@MODULES", Modules);

                sqlConn.Open();
                cmd.ExecuteNonQuery();
                sqlConn.Close();
            }
        }
        
    }
}
