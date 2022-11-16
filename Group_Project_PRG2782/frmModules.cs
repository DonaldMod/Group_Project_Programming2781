using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_Project_PRG2782
{
    public partial class frmModules : Form
    {
        DataHandler data = new DataHandler();
        string code, name, desc, link;

        public frmModules()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmModules_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdateCourse_Click(object sender, EventArgs e)
        {
            try
            {
                code = txbxCode.Text;
                name = txbxName.Text;
                desc = rtxDescription.Text;
                link = rtxDescription.Text;

                if (!(String.IsNullOrEmpty(code)) || !(String.IsNullOrEmpty(name)) || !(String.IsNullOrEmpty(desc)))
                {
                    data.UpdateModule(code, name, desc, link);

                    txbxCode.Clear();
                    txbxName.Clear();
                    rtbResources.Clear();
                    rtxDescription.Clear();
                }
                else
                {
                    MessageBox.Show("Please fill in all empty spaces!!");
                }


            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            
            try
            {
                code = txbxCode.Text;
                name = txbxName.Text;
                desc = rtxDescription.Text;
                link = rtxDescription.Text;

                if (!(String.IsNullOrEmpty(code)) || !(String.IsNullOrEmpty(name)) || !(String.IsNullOrEmpty(desc)))
                {
                    data.InsertModule(code, name, desc, link);

                    txbxCode.Clear();
                    txbxName.Clear();
                    rtbResources.Clear();
                    rtxDescription.Clear();
                }
                else
                {
                    MessageBox.Show("Please fill in all empty spaces!!");
                }


            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            main.Show();
            this.Close();
        }

        private void btnDeleteCoure_Click(object sender, EventArgs e)
        {
            try
            {
                code = txbxCode.Text;

                if (!(String.IsNullOrEmpty(code)))
                {
                    data.DeleteModule(code);
                   

                    txbxCode.Clear();
                }
                else
                {
                    MessageBox.Show("Please fill in all empty spaces!!");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
