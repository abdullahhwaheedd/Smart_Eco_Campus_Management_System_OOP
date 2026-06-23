using SECMSS.Model;
using SECMSS.Ui;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SECMSS
{
    public partial class ReporterDashboard : Form
    {
        private UserModel currentUser;

        public ReporterDashboard(UserModel user) 
        {
            InitializeComponent();
           
            this.currentUser = user;

           
            if (this.currentUser != null)
            {
                this.Text = "Welcome " + this.currentUser.Name;
            }
        }

        private void btnViewReports_Click(object sender, EventArgs e)
        {
        
            if (currentUser != null)
            {
                ReportBL reportBL = new ReportBL();
                List<ReportModel> myReports = reportBL.GetMyReports(currentUser.UserId);
                dgvReports.DataSource = myReports;
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddReportForm f = new AddReportForm(currentUser.UserId);
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            if (dgvReports.SelectedRows.Count > 0)
            {
                
                int reportId = Convert.ToInt32(dgvReports.SelectedRows[0].Cells["ReportId"].Value);

               
                DialogResult dialog = MessageBox.Show("Are you sure you want to delete this report?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialog == DialogResult.Yes)
                {

                    ReportBL bl = new ReportBL();
                    string result = bl.DeleteMyReport(reportId, currentUser.UserId);

                    MessageBox.Show(result);

                   
                    btnViewReports_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Please click the far-left side of a row to select it first!");
            }
        }

        private void btnUpdateReport_Click(object sender, EventArgs e)
        {
            if (dgvReports.SelectedRows.Count > 0)
            {
                
                ReportModel selectedReport = (ReportModel)dgvReports.SelectedRows[0].DataBoundItem;

                
                UpdateReportForm updateForm = new UpdateReportForm(selectedReport);
                updateForm.ShowDialog(); 

                
                btnViewReports_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Please select a report to update!");
            }

        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
          
            DialogResult result = MessageBox.Show("Are you SURE? This will permanently delete your profile and ALL your reports. This cannot be undone.",
                                                  "Confirm Account Deletion",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                UserBL userBL = new UserBL();
               
                string response = userBL.DeleteAccount(currentUser.UserId);

                if (response == "Success")
                {
                    MessageBox.Show("Your account and all associated data have been deleted. Goodbye!", "Account Deleted");

                   
                    LoginForm login = new LoginForm();
                    login.Show();
                    this.Close(); 
                }
                else
                {
                    MessageBox.Show(response);
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
           
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LoginForm login = new LoginForm();

                
                login.Show();

                
                this.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
            LoginForm login = new LoginForm();

          
            login.Show();

           
            this.Close();
        }
    }
}
