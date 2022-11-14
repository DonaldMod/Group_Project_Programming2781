using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;

namespace Group_Project_PRG2782
{
    public partial class Update_Modules : Form
    {
        string code, name, desc, link;
        DBConnection dbInfo = new DBConnection();
        public BindingSource bs = new BindingSource();

        public Update_Modules()
        {
            InitializeComponent();
        }

        private void btnUpdateModule_Click(object sender, EventArgs e)
        {
            updatingModule();
        }

        public void updatingModule()
        {
            try
            {
                code = tbxModuleCode.Text;
                name = tbxModuleName.Text;
                desc = tbxModuleDesc.Text;
                link = tbxModuleResource.Text;

                if (tbxModuleCode.Text != "" || tbxModuleName.Text != "" || tbxModuleDesc.Text != "")
                {
                    dbInfo.ModuleUpdate(code, name, desc, link);
                    readingModules();

                    tbxModuleCode.Clear();
                    tbxModuleName.Clear();
                    tbxModuleDesc.Clear();
                    tbxModuleResource.Clear();
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

        private void dgvModuleDetails_SelectionChanged(object sender, EventArgs e)
        {
            SelectionProcess();
        }

        public void SelectionProcess()
        {
            try
            {
                tbxModuleCode.Text = dgvModuleDetails.CurrentRow.Cells[0].Value.ToString();
                tbxModuleName.Text = dgvModuleDetails.CurrentRow.Cells[1].Value.ToString();
                tbxModuleDesc.Text = dgvModuleDetails.CurrentRow.Cells[2].Value.ToString();
                tbxModuleResource.Text = dgvModuleDetails.CurrentRow.Cells[3].Value.ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            main.Show();
            this.Close();
        }

        private void Update_Modules_Load(object sender, EventArgs e)
        {
            readingModules();
        }

        public void readingModules()
        {
            bs.DataSource = dbInfo.ModuleRead().Tables[0];
            dgvModuleDetails.DataSource = bs;
        }
    }
}
