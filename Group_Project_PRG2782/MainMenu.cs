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
        DataHandler dB = new DataHandler();
        
        
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            dB.TestConnection();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            loadform(new frmStudents());
            
        }

        private void btnModules_Click(object sender, EventArgs e)
        {
            loadform(new frmModules());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnStudents_MouseHover(object sender, EventArgs e)
        {
            btnStudents.BackColor = Color.Red;
        }

        private void btnStudents_MouseLeave(object sender, EventArgs e)
        {
            btnStudents.BackColor = Color.Black;
        }

        private void btnModules_MouseHover(object sender, EventArgs e)
        {

            btnModules.BackColor = Color.Red;



        }

        private void btnModules_MouseLeave(object sender, EventArgs e)
        {

            btnModules.BackColor = Color.Black;
        }

        private void btnTest_MouseHover(object sender, EventArgs e)
        {
            btnTest.BackColor = Color.Red;
        }

        private void btnTest_MouseLeave(object sender, EventArgs e)
        {
            btnTest.BackColor = Color.Black;
        }

        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.Red;
            btnExit.ForeColor = Color.Black;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.ForeColor = Color.Red;
            btnExit.BackColor = Color.Black;

            btnStudents.BackColor = Color.Black;

        }
        public void loadform(object frmShow)
        {
            if (this.PanelFrms.Controls.Count>0)
            {
                this.PanelFrms.Controls.RemoveAt(0);
            }
            Form f = frmShow as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.PanelFrms.Controls.Add(f);
            this.PanelFrms.Tag= f;
            f.Show();
        }
    }
}
