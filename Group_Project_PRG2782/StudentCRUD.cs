using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Project_PRG2782
{
    class StudentCRUD
    {
        DataHandler data = new DataHandler();
        public string sqlString;
        SqlCommand cmd;


        public void UpdateStudents(int ID, string fname,string lname, byte[] image, DateTime DOB, string Gender, int phone, string Address, string Modules)
        {
            using (data.Sqlcon)
            {

            }
        }
        public StudentCRUD()
        {

        }
    }
}
