using SECMSS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SECMSS.Ui
{
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }

        private void btnSubmitSignup_Click(object sender, EventArgs e)
        {
           
            Reporter newUser = new Reporter();
            newUser.Name = txtSignupName.Text.Trim();
            newUser.Age = (int)numAge.Value; 
            newUser.Email = txtSignupEmail.Text.Trim();
            newUser.Password = txtSignupPassword.Text.Trim();
            newUser.Role = "Reporter";

            
            UserBL bl = new UserBL();
            string result = bl.SignUpReporter(newUser);

           
            if (result == "Success")
            {
                MessageBox.Show("Registration Successful! You can now login.", "Success");
                this.Close(); 
            }
            else
            {
               
                MessageBox.Show(result, "Signup Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
