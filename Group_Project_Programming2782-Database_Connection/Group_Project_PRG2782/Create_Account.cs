using System;
using System.Windows.Forms;

namespace Group_Project_PRG2782
{
    public partial class Create_Account : Form
    {
        LoginDataHandler creatingAcc = new LoginDataHandler();

        string user, pass;
        bool check = false;

        public Create_Account()
        {
            InitializeComponent();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            Creating();
        }

        public void Creating()
        {
            try
            {
                user = tbxUserame.Text;
                pass = tbxPassword.Text;

                if (tbxPassword.Text != "" && tbxUserame.Text != "")
                {
                    creatingAcc.ReadingPassWords();

                    foreach (var item in LoginDataHandler.ImportList)
                    {
                        if (item.Username == user)
                        {
                            check = true;
                        }
                    }

                    if (check != true)
                    {
                        creatingAcc = new LoginDataHandler(user, pass);
                        creatingAcc.CreatingAccDetails();
                    }
                    else
                    {
                        MessageBox.Show("The username already exists!");
                    }

                    tbxUserame.Clear();
                    tbxPassword.Clear();
                }
                else
                {
                    MessageBox.Show("Please fill in all the empty textboxes!");
                }
            }
            catch (Exception p)
            {
                MessageBox.Show(p.Message);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginDetails login = new LoginDetails();
            login.Show();
            this.Close();
        }
    }
}
