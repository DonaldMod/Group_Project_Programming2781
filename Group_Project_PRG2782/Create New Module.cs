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
    public partial class Create_New_Module : Form
    {
        string code, name, desc, link;
        DBConnection dbInfo = new DBConnection();

        public Create_New_Module()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            main.Show();
            this.Close();
        }

        private void btnCreateNewModule_Click(object sender, EventArgs e)
        {
            creatingModules();
        }

        public void creatingModules()
        {
            try
            {
                code = tbxModuleCode.Text;
                name = tbxModuleName.Text;
                desc = tbxModuleDesc.Text;
                link = tbxModuleResource.Text;

                if (tbxModuleCode.Text != "" || tbxModuleName.Text != "" || tbxModuleDesc.Text != "")
                {
                    dbInfo.ModuleCreation(code, name, desc, link);

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
    }
}
