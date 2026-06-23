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
    public partial class UpdateReportForm : Form
    {
        private ReportModel reportToUpdate;

        public UpdateReportForm(ReportModel report)
        {
            InitializeComponent();
            this.reportToUpdate = report;

           
            txtLocation.Text = reportToUpdate.Location;
            rtbDescription.Text = reportToUpdate.Description;

            
            cmbWasteType.Text = reportToUpdate.TypeOfWaste;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
           
            if (cmbWasteType.SelectedItem == null && string.IsNullOrEmpty(cmbWasteType.Text))
            {
                MessageBox.Show("Please select a valid Waste Type from the dropdown.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            reportToUpdate.Location = txtLocation.Text.Trim();

            reportToUpdate.TypeOfWaste = cmbWasteType.SelectedItem != null ?
                                         cmbWasteType.SelectedItem.ToString() :
                                         cmbWasteType.Text;

            reportToUpdate.Description = rtbDescription.Text.Trim();

            ReportBL bl = new ReportBL();
            string result = bl.UpdateMyReport(reportToUpdate);

            if (result.ToLower().Contains("success"))
            {
                MessageBox.Show("Update Successful!");
                this.Close();
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
