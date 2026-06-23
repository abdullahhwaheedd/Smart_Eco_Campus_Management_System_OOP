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
    public partial class AdminDashboard : Form
    {
        private UserModel currentAdmin;
        private UserBL userBL = new UserBL();
        private ReportBL reportBL = new ReportBL();
        
        public AdminDashboard(UserModel admin)
        {
            InitializeComponent();
            this.currentAdmin = admin;
            this.Text = "Admin Control Panel: " + admin.Name;

            
            LoadAllData();
        }
        private void LoadAllData()
        {
            dgvUsers.DataSource = userBL.GetAllUsers();
            dgvReports.DataSource = reportBL.GetAllReports();
        }

        
        private void btnSearchUserReports_Click(object sender, EventArgs e)
        {
            int userId;
            if (int.TryParse(txtSearchId.Text, out userId))
            {
               
                var results = reportBL.ReverseSearchReportsByUserId(userId);
                dgvReports.DataSource = null;
                dgvReports.DataSource = results;
                MessageBox.Show($"Found {results.Count} reports for User #{userId}");
            }
            else MessageBox.Show("Please enter a valid numeric User ID.");
        }

        private void btnSearchReportOwner_Click(object sender, EventArgs e)
        {
            int reportId;
            if (int.TryParse(txtSearchId.Text, out reportId))
            {
                
                UserModel owner = reportBL.ReverseSearchReporterByReportId(reportId);

                if (owner != null)
                    MessageBox.Show($"Report #{reportId} belongs to:\nName: {owner.Name}\nEmail: {owner.Email}", "Owner Found");
                else
                    MessageBox.Show("No owner found for this Report ID.");
            }
            else MessageBox.Show("Please enter a valid numeric Report ID.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            txtSearchId.Clear();

         
            ReportBL bl = new ReportBL();
            dgvReports.DataSource = null;
            dgvReports.DataSource = bl.GetAllReports();

            MessageBox.Show("View Reset to Global Campus Reports.", "System Info");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
            LoginForm login = new LoginForm();

            
            login.Show();

           
            this.Close();
        }
    }
}
