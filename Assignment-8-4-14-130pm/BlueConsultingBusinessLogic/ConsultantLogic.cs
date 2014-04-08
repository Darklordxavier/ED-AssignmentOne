using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueConsultingBusinessLogic
{
    public class ConsultantLogic
    {
        List<Report> reports = new List<Report>();

        public ConsultantLogic()
        {
            //create new consultant
        }

        public void addReport(Report report)
        {
            reports.Add(report);
        }

        public void submitReportToDatabase()
        {
            //DatabaseAccess.insertReportToDatabase(
        }

        public List<Report> getAllReports()
        {
            return reports;
        }

        /*
        public Report getReport(String reportDate)
        {
            foreach (Report report in reports)
            {
                if (report.ReportDate.Equals(reportDate))
                {
                    return report;
                }
            }
            return null;
        }
         */
    }
}
