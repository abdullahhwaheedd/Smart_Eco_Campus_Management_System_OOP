using SECMSS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SECMSS.DL
{
    public interface IReportDL
    {
        bool AddReport(ReportModel report);
        List<ReportModel> GetAllReports();
        List<ReportModel> GetReportsByUserId(int userId);
        bool UpdateReportStatus(int reportId, string newStatus);
        bool DeleteReport(int reportId, int userId);
    }
}
