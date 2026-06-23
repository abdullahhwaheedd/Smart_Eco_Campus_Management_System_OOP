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
    public partial class SupervisorDashboard : Form
    {
        private UserModel currentUser;
        private ReportBL reportBL = new ReportBL();

        
        public SupervisorDashboard(UserModel user)
        {
            InitializeComponent(); 
            this.currentUser = user;
            this.Text = "Supervisor: " + currentUser.Name;
        }

       
      

        private void RefreshGrid()
        {
           
            List<ReportModel> allReports = reportBL.GetAllReports();

            dgvAllReports.DataSource = null;
            dgvAllReports.DataSource = allReports;
        }

      
        

        
        private void SupervisorDashboard_Load_1(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void btnLoadAll_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }
        private void btnAssign_Click_1(object sender, EventArgs e)
        {
            if (dgvAllReports.SelectedRows.Count > 0)
            {
                ReportModel selected = (ReportModel)dgvAllReports.SelectedRows[0].DataBoundItem;
                string result = reportBL.AssignTask(selected.ReportId);
                MessageBox.Show(result, "Status Update");
                RefreshGrid();
            }
            else
            {
                MessageBox.Show("Please select a report row first.");
            }
        }

      

        private void btnComplete_Click_1(object sender, EventArgs e)
        {
            if (dgvAllReports.SelectedRows.Count > 0)
            {
                ReportModel selected = (ReportModel)dgvAllReports.SelectedRows[0].DataBoundItem;

                string result = reportBL.MarkAsComplete(selected.ReportId);
                MessageBox.Show(result, "System Info");
                RefreshGrid();
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
