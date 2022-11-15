using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_Project_PRG2782
{
    public partial class frmStudents : Form
    {
        DataHandler data  = new DataHandler();
        StringBuilder sb = new StringBuilder();
        StudentCRUD cRUD = new StudentCRUD();
        MainMenu main = new MainMenu();
        public frmStudents()
        {
            InitializeComponent();
        }

        private void frmStudents_Load(object sender, EventArgs e)
        {

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            try
            {
                //Add image using byte and image path
                byte[] image = File.ReadAllBytes($@"{txbxImagePath.Text}");
                //Convert Listbox to string using stingbuilder 
                foreach (var item in lbxModules.Items)
                {
                    sb.Append($"{item.ToString()},");
                }
                //Save date
                DateTime Dob = DateTime.Parse(dtpDOB.Text);

                cRUD.UpdateStudents(int.Parse(txbxNumber.Text),txbxName.Text,txbxSurname.Text,image,Dob,cbxGender.Text,int.Parse(txbxPhone.Text),txbxAddress.Text,sb.ToString());
                

            }
            catch (Exception t)
            {
                MessageBox.Show(t.Message);
            }
        }

        private void btnAddSubjects_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            main.Show();
        }

        private void txbxImagePath_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofdImage.ShowDialog()== DialogResult.OK)
                {
                    txbxImagePath.Text = ofdImage.FileName.ToString();
                }
            }
            catch (Exception t)
            {

                MessageBox.Show(t.Message);
            }
        }
    }
}
