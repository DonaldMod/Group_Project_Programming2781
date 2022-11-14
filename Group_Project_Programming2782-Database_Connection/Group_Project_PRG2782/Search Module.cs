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
    public partial class Search_Module : Form
    {
        string code;
        DBConnection dbInfo = new DBConnection();
        BindingSource bs = new BindingSource();

        public Search_Module()
        {
            InitializeComponent();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            main.Show();
            this.Close();
        }

        private void btnSearchModule_Click(object sender, EventArgs e)
        {
            SearchingModule();
        }

        public void SearchingModule()
        {
            try
            {
                code = tbxModuleCode.Text;

                if (tbxModuleCode.Text != "")
                {
                    bs.DataSource = dbInfo.ModuleSearch(code).Tables[0];
                    dgvModuleDetails.DataSource = bs;

                    tbxModuleCode.Clear();
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

        private void Search_Module_Load(object sender, EventArgs e)
        {
            readingModules();
        }

        public void readingModules()
        {
            bs.DataSource = dbInfo.ModuleRead().Tables[0];
            dgvModuleDetails.DataSource = bs;
        }

        private void dgvModuleDetails_SelectionChanged(object sender, EventArgs e)
        {
            
        }
    }
}
