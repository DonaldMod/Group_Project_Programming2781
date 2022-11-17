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

            loaddgv();
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

                data.InsertStudents(int.Parse(txbxNumber.Text),txbxName.Text,txbxSurname.Text,image,Dob,cbxGender.Text,int.Parse(txbxPhone.Text),txbxAddress.Text,sb.ToString());
                
                

            }
            catch (Exception t)
            {
                MessageBox.Show(t.Message);
            }
            loaddgv();
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
                    pbxImage.Image = Image.FromFile(imagePath);
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

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            data.deleteStudent(int.Parse(txbxNumber.Text));
            loaddgv();
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            try
            {
                //Add image using byte and image path
                byte[] image = File.ReadAllBytes(imagePath);
                //Convert Listbox to string using stingbuilder 
                foreach (var item in lbxModules.Items)
                {
                    sb.Append($"{item.ToString()},");
                }
                //Save date
                DateTime Dob = DateTime.Parse(dtpDOB.Text);
                data.UpdateStudents(int.Parse(txbxNumber.Text), txbxName.Text, txbxSurname.Text, image, Dob, cbxGender.Text, int.Parse(txbxPhone.Text), txbxAddress.Text, sb.ToString());
            }
            catch (Exception t)
            {
                MessageBox.Show(t.Message);
              
            }
            loaddgv();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvOne.DataSource =  data.searchStudent(int.Parse(tbxSearch.Text));
            
        }
        public void loaddgv()
        {
            data.bs.DataSource = data.DisplayStudents();
            dgvOne.DataSource = data.bs;
        }

        private void dgvOne_SelectionChanged(object sender, EventArgs e)
        {
            txbxNumber.Text = dgvOne.CurrentRow.Cells[0].Value.ToString();
            txbxName.Text = dgvOne.CurrentRow.Cells[1].Value.ToString();
            txbxSurname.Text = dgvOne.CurrentRow.Cells[2].Value.ToString();
            byte[] image = (byte[])(dgvOne.CurrentRow.Cells[3].Value);
            MemoryStream ms = new MemoryStream(image);
            pbxImage.Image = Image.FromStream(ms);
            cbxGender.Text = dgvOne.CurrentRow.Cells[4].Value.ToString();
            txbxPhone.Text = dgvOne.CurrentRow.Cells[5].Value.ToString();
            txbxAddress.Text = dgvOne.CurrentRow.Cells[6].Value.ToString();
            string[] modules = dgvOne.CurrentRow.Cells[7].Value.ToString().Split(',');
            foreach (var item in modules)
            {
                lbxModules.Items.Add(item);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txbxAddress.Clear();
            txbxName.Clear();
            txbxSurname.Clear();
            txbxNumber.Clear();
            txbxPhone.Clear();
            cbxGender.ResetText();
            pbxImage.Image.Dispose();
            lbxModules.Items.Clear();
            tbxSearch.Clear();
        }
    }
}
