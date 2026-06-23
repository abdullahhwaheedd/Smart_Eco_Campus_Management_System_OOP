using SECMSS.Model;
using SECMSS.Ui;
using System;
using System.Windows.Forms;

namespace SECMSS
{
    public partial class LoginForm : Form
    {

        private UserModel currentUser;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();





            UserBL bl = new UserBL();
            UserModel user = bl.Login(email, password);

            if (user != null)
            {

                user.DisplayWelcomeMessage();


                if (user.Role.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                {
                    AdminDashboard adminDash = new AdminDashboard(user);
                    adminDash.Show();
                }
                else if (user.Role.Equals("Supervisor", StringComparison.OrdinalIgnoreCase))
                {
                    SupervisorDashboard superDash = new SupervisorDashboard(user);
                    superDash.Show();
                }
                else
                {
                    ReporterDashboard reporterDash = new ReporterDashboard(user);
                    reporterDash.Show();
                }

                this.Hide();
            }
            else
            {

                MessageBox.Show("Invalid Email or Password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);


                txtPassword.Clear();
                txtEmail.Focus();
            }
        }

        private void btnOpenSignup_Click(object sender, EventArgs e)
        {
            SignupForm signup = new SignupForm();
            signup.ShowDialog();

        }
    }
}
