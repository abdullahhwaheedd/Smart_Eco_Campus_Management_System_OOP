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

namespace SECMSS
{
    public partial class AddReportForm : Form
    {
        private int loggedInUserId;

       
        public AddReportForm(int userId)
        {
            InitializeComponent();
            this.loggedInUserId = userId;
        }

       

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
           
            if (cmbWasteType.SelectedItem == null)
            {
                MessageBox.Show("Please select a Waste Type!");
                return;
            }

            
            ReportModel newReport = new ReportModel(
                0,
                loggedInUserId,
                txtLocation.Text,
                cmbWasteType.SelectedItem.ToString(),
                rtbDescription.Text,
                "Pending"
            );

         
            ReportBL bl = new ReportBL();
            string result = bl.AddReport(newReport);

            
            MessageBox.Show("Result: " + result);

            if (result == "Success")
            {
                this.Close(); 
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}