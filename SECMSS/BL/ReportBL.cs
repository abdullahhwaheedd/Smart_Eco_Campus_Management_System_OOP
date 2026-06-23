using SECMSS.DL;
using SECMSS.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ReportBL
{
    private ReportDL reportDL = new ReportDL();

    public string AddReport(ReportModel report)
    {

        if (string.IsNullOrEmpty(report.Location))
        {
            return "Location is mandatory!";
        }

        if (string.IsNullOrEmpty(report.TypeOfWaste))
        {
            return "Please specify the type of waste (Organic, Plastic, etc.)";
        }

        if (report.Description.Length < 10)
        {
            return "Description must be at least 10 characters long.";
        }


        if (report.UserId <= 0)
        {
            return "Invalid User Session. Please log in again.";
        }


        bool isAdded = reportDL.AddReport(report);

        if (isAdded)
            return "Success";
        else
            return "Error: Database failed to save the report.";
    }
   
    public List<ReportModel> GetMyReports(int userId)
    {
        
        if (userId <= 0)
        {
          
            return new List<ReportModel>();
        }

        
        List<ReportModel> reports = reportDL.GetReportsByUserId(userId);

        return reports;
    }
  
    public string UpdateMyReport(ReportModel report)
    {
       
        if (string.IsNullOrEmpty(report.Location) || string.IsNullOrEmpty(report.TypeOfWaste))
        {
            return "Location and Waste Type cannot be empty!";
        }

        if (report.Description.Length < 10)
        {
            return "Description is too short.";
        }

   
        if (report.ReportId <= 0 || report.UserId <= 0)
        {
            return "Invalid Request. Ownership could not be verified.";
        }

        bool isUpdated = reportDL.UpdateReport(report);

        if (isUpdated)
        {
            return "SUCESS";
        }
        else
        {
            return "Update failed. You might not have permission to edit this report.";
        }
    }
  
    public string DeleteMyReport(int reportId, int userId)
    {
      
        if (reportId <= 0 || userId <= 0)
        {
            return "Invalid Request. ID must be positive.";
        }

       
        bool isDeleted = reportDL.DeleteReport(reportId, userId);

       
        if (isDeleted)
        {
            return "Success";
        }
        else
        {
           
            return "Delete failed. Either the report doesn't exist or you don't have permission.";
        }
    }
    

    public List<ReportModel> GetAllReports()
    {

        return reportDL.GetAllReports();
    }
    public string AssignTask(int reportId)
    {
        if (reportId <= 0) return "Invalid ID.";

      
        bool isSuccess = reportDL.UpdateReportStatus(reportId, "Assigned");

        return isSuccess ? "Success: Task Assigned!" : "Error: ID not found.";
    }

    public string MarkAsComplete(int reportId)
    {
        if (reportId <= 0) return "Invalid ID.";

        bool isSuccess = reportDL.UpdateReportStatus(reportId, "Completed");

        return isSuccess ? "Success: Marked as Completed!" : "Error: ID not found.";

    }

   
    public List<ReportModel> ReverseSearchReportsByUserId(int userId)
    {
        List<ReportModel> allReports = reportDL.GetAllReports(); 
        List<ReportModel> foundReports = new List<ReportModel>();

        
        for (int i = allReports.Count - 1; i >= 0; i--)
        {
            if (allReports[i].UserId == userId)
            {
                foundReports.Add(allReports[i]);
            }
        }
        return foundReports;
    }

    public UserModel ReverseSearchReporterByReportId(int reportId)
    {
        UserDL userDL = new UserDL();
        List<UserModel> allUsers = userDL.GetAllUsers(); 

     
        for (int i = allUsers.Count - 1; i >= 0; i--)
        {
          
            List<ReportModel> theirReports = reportDL.GetReportsByUserId(allUsers[i].UserId);

        
            foreach (var r in theirReports)
            {
                if (r.ReportId == reportId)
                {
                    return allUsers[i]; 
                }
            }
        }
        return null;
    }
}