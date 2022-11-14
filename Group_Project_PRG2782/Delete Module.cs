using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using System.Xml.Linq;
using System.Data.Common;

namespace Group_Project_PRG2782
{
    public partial class Delete_Module : Form
    {
        string code;
        DBConnection dbInfo = new DBConnection();
        BindingSource bs = new BindingSource();

        public Delete_Module()
        {
            InitializeComponent();
        }

        private void btnDeleteModule_Click(object sender, EventArgs e)
        {
            deletingModules();
        }

        public void deletingModules()
        {
            try
            {
                code = tbxModuleCode.Text;

                if (tbxModuleCode.Text != "" )
                {
                    dbInfo.ModuleDelete(code);
                    readingModules();

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

        private void Delete_Module_Load(object sender, EventArgs e)
        {
            readingModules();
        }

        public void readingModules()
        {
            bs.DataSource = dbInfo.ModuleRead().Tables[0];
            dgvModuleDetails.DataSource = bs;
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            main.Show();
            this.Close();
        }

        private void dgvModuleDetails_SelectionChanged(object sender, EventArgs e)
        {
            SelectionProcess();
        }

        public void SelectionProcess()
        {
            try
            {
                tbxModuleCode.Text = dgvModuleDetails.CurrentRow.Cells[0].Value.ToString();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
