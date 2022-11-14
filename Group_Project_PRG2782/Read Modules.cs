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
    public partial class Read_Modules : Form
    {
        DBConnection dbInfo = new DBConnection();
        BindingSource bs = new BindingSource();

        public Read_Modules()
        {
            InitializeComponent();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            main.Show();
            this.Close();
        }

        private void Read_Modules_Load(object sender, EventArgs e)
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
