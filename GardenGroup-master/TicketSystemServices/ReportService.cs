using System.Collections.Generic;
using TicketSystemDAO;
using TicketSystemModels;

namespace TicketSystemServices
{
    public class ReportService
    {
        private readonly ReportDAO reportDao;

        public ReportService() => reportDao = new ReportDAO();

        public void InsertReport(Report report) => reportDao.InsertReport(report);
        
        public List<Report> GetAllReports() => reportDao.GetAllReports();
        public void DeleteReport(Report report) => reportDao.deleteReport(report);
    }
}
