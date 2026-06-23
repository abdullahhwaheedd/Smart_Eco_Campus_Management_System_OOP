using SECMSS.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SECMSS.DL
{
    class ReportDL : IReportDL
    {
        public bool AddReport(ReportModel report)
        {
            using (SqlConnection conn = DbConfig.GetConnection())
            {
              
                string query = "INSERT INTO Reports (UserId, Location, TypeOfWaste, Description, Status) " +
                               "VALUES (@UserId, @Location, @TypeOfWaste, @Description, 'Pending')";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserId", report.UserId);
                cmd.Parameters.AddWithValue("@Location", report.Location);
                cmd.Parameters.AddWithValue("@TypeOfWaste", report.TypeOfWaste);
                cmd.Parameters.AddWithValue("@Description", report.Description);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
        }
      


public List<ReportModel> GetReportsByUserId(int userId)
    {
        List<ReportModel> myReportsList = new List<ReportModel>();

        using (SqlConnection conn = DbConfig.GetConnection())
        {
          
            string query = "SELECT * FROM Reports WHERE UserId = @UserId";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserId", userId);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            
            while (reader.Read())
            {
                ReportModel report = new ReportModel(
                    (int)reader["ReportId"],
                    (int)reader["UserId"],
                    reader["Location"].ToString(),
                    reader["TypeOfWaste"].ToString(),
                    reader["Description"].ToString(),
                    reader["Status"].ToString()
                );
                myReportsList.Add(report);
            }
        }
        return myReportsList;
    }
        public bool UpdateReport(ReportModel report)
        {
            using (SqlConnection conn = DbConfig.GetConnection())
            {
                
                string query = "UPDATE Reports SET Location = @Location, " +
                               "TypeOfWaste = @TypeOfWaste, Description = @Description " +
                               "WHERE ReportId = @ReportId AND UserId = @UserId AND Status ='Pending'";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Location", report.Location);
                cmd.Parameters.AddWithValue("@TypeOfWaste", report.TypeOfWaste);
                cmd.Parameters.AddWithValue("@Description", report.Description);
                cmd.Parameters.AddWithValue("@ReportId", report.ReportId);
                cmd.Parameters.AddWithValue("@UserId", report.UserId);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
        }
        public bool DeleteReport(int reportId, int userId)
        {
            using (SqlConnection conn = DbConfig.GetConnection())
            {
                
                string query = "DELETE FROM Reports WHERE ReportId = @ReportId AND UserId = @UserId AND Status ='Pending'";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ReportId", reportId);
                cmd.Parameters.AddWithValue("@UserId", userId);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                
                return rows > 0;
            }
        }
       
        public List<ReportModel> GetAllReports()
        {
            List<ReportModel> allReports = new List<ReportModel>();

            using (SqlConnection conn = DbConfig.GetConnection())
            {
               
                string query = "SELECT * FROM Reports";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ReportModel report = new ReportModel(
                        (int)reader["ReportId"],
                        (int)reader["UserId"],
                        reader["Location"].ToString(),
                        reader["TypeOfWaste"].ToString(),
                        reader["Description"].ToString(),
                        reader["Status"].ToString()
                    );
                    allReports.Add(report);
                }
            }
            return allReports;
        }
        public bool UpdateReportStatus(int reportId, string newStatus)
        {
            using (SqlConnection conn = DbConfig.GetConnection())
            {
                
                string query = "UPDATE Reports SET Status = @Status WHERE ReportId = @ReportId";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Status", newStatus);
                cmd.Parameters.AddWithValue("@ReportId", reportId);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
        }
        
        
    }
}
