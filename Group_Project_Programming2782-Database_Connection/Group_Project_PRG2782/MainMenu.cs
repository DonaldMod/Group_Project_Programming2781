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
    public partial class MainMenu : Form
    {
        DBConnection dB = new DBConnection();
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            dB.TestConnection();
        }

        private void btnCreateNewModule_Click(object sender, EventArgs e)
        {
            Create_New_Module module = new Create_New_Module();
            module.Show();
            this.Close();
        }

        private void btnReadModule_Click(object sender, EventArgs e)
        {
            Read_Modules modulesRead = new Read_Modules();
            modulesRead.Show();
            this.Close();
        }

        private void btnUpdateModule_Click(object sender, EventArgs e)
        {
            Update_Modules moduleUpdate = new Update_Modules();
            moduleUpdate.Show();
            this.Close();
        }

        private void btnDeleteModules_Click(object sender, EventArgs e)
        {
            Delete_Module moduleDelete = new Delete_Module();
            moduleDelete.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Search_Module moduleSearch = new Search_Module();
            moduleSearch.Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginDetails logout = new LoginDetails();
            logout.Show();
            this.Close();
        }
    }
}
