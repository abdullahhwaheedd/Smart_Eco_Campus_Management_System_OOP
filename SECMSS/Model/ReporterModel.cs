
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SECMSS.Model
{

     class Reporter : UserModel
    {
        private List<ReportModel> myReports;

        public Reporter() : base()
        {
            myReports = new List<ReportModel>();
        }

     
        public Reporter(int userId, string name, int age, string email, string password, string role)
            : base(userId, name, age, email, password, role)
        {
            myReports = new List<ReportModel>();
        }

        public List<ReportModel> MyReports
        {
            get { return myReports; }
            set { myReports = value; }
        }
        public override void DisplayWelcomeMessage()
        {
            MessageBox.Show($"Hello {this.name}!\nReady to report some waste?", "Reporter Login");
        }
    }
}

