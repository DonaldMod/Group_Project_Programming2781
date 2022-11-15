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
        
        frmAddSubjects addSubjects = new frmAddSubjects();  

        string imagePath;
        public frmStudents()
        {
            InitializeComponent();
        }

        private void frmStudents_Load(object sender, EventArgs e)
        {
            data.DisplayStudents();
            dgvOne.DataSource = data.bs;
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            try
            {
                //Add image using byte and image path
                byte[] image= File.ReadAllBytes(imagePath);
                //Convert Listbox to string using stingbuilder 
                foreach (var item in lbxModules.Items)
                {
                    sb.Append($"{item.ToString()},");
                }
                //Save date
                DateTime Dob = DateTime.Parse(dtpDOB.Text);

                data.UpdateStudents(int.Parse(txbxNumber.Text),txbxName.Text,txbxSurname.Text,image,Dob,cbxGender.Text,int.Parse(txbxPhone.Text),txbxAddress.Text,sb.ToString());
                

            }
            catch (Exception t)
            {
                MessageBox.Show(t.Message);
            }
            data.bs.ResetBindings(false);
        }

        private void btnAddSubjects_Click(object sender, EventArgs e)
        {
            addSubjects.ShowDialog();
            foreach (var item in addSubjects.Modules)
            {
                lbxModules.Items.Add(item);
            } 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            
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
                    imagePath = ofdImage.FileName.ToString();
                    pictureBox1.Image = Image.FromFile(imagePath);
                }
            }
            catch (Exception t)
            {

                MessageBox.Show(t.Message);
            }
        }

        private void dgvOne_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
