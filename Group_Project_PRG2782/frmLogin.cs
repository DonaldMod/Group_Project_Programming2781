using System;
using System.Windows.Forms;

namespace Group_Project_PRG2782
{
    public partial class LoginDetails : Form
    {
        LoginDataHandler login = new LoginDataHandler();
        string user, pass;
        bool check = false, passChecker = false;

        public LoginDetails()
        {
            InitializeComponent();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                Create_Account nextPage = new Create_Account();
                nextPage.Show();
                this.Hide();
            }
            catch (Exception p)
            {
                MessageBox.Show(p.Message);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginVadilation();
        }

        private void LoginDetails_Load(object sender, EventArgs e)
        {

        }

        public void LoginVadilation()
        {
            try
            {
                user = tbxUserame.Text;
                pass = tbxPassword.Text;

                if (tbxUserame.Text != "" && tbxPassword.Text != "")
                {
                    login.ReadingPassWords();
                    foreach (var item in LoginDataHandler.ImportList)
                    {

                        if (item.Username == user)
                        {
                            if (item.Password == pass)
                            {
                                MainMenu main = new MainMenu();
                                MessageBox.Show($"Welcome back, {item.Username}");
                                passChecker = true;
                                main.Show();
                                this.Hide();
                                break;
                            }
                            check = true;
                        }
                    }

                    if (check == false && passChecker == false)
                    {
                        MessageBox.Show("Profile does not exist!!.");
                    }
                    else if (check == true && passChecker == false)
                    {
                        MessageBox.Show("Password is incorrect! TRY AGAIN");
                    }

                    check = false;
                    passChecker = false;
                    tbxUserame.Clear();
                    tbxPassword.Clear();
                    check = false;
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
    }
}
