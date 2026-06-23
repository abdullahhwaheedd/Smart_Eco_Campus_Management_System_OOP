using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SECMSS.Model
{
        
       public class ReportModel
        {
            private int reportId;
            private int userId;
            private string location;
            private string typeOfWaste;
            private string description;
            private string status;

     

        public ReportModel(int reportId, int userId, string location, string typeOfWaste, string description, string status)
        {
            this.reportId = reportId;
            this.userId = userId;
            this.location = location;
            this.typeOfWaste = typeOfWaste;
            this.description = description;
            this.status = status;

            
           
        }
        public ReportModel()
            {
                
            }

            public int ReportId 
            { get { return reportId; } 
            set { reportId = value; } }
            public int UserId { get { return userId; } set { userId = value; } }
            public string Location { get { return location; } set { location = value; } }
            public string TypeOfWaste { get { return typeOfWaste; } set { typeOfWaste = value; } }
            public string Description { get { return description; } set { description = value; } }
            public string Status { get { return status; } set { status = value; } }

            
          
        }
    }
    


