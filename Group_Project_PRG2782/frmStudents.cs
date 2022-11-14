using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_Project_PRG2782
{
    public partial class frmStudents : Form
    {
        public string sqlString;
        SqlCommand cmd;
        SqlDataReader reader;
        DataHandler data = new DataHandler();

        public frmStudents()
        {
            InitializeComponent();
        }

        
        private void GetStudents()
        {
            try
            {
                data.Sqlcon.Open();
                sqlString = @"Select * from Students";


            }
            catch (Exception t)
            {
                MessageBox.Show(t.Message);
                throw;
            }
        }
    }
}
