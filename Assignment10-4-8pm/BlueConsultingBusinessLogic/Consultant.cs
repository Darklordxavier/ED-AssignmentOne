using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BlueConsultingBusinessLogic
{
    public class Consultant
    {
        List<Report> reports = new List<Report>();
        string consultantID;
        public Consultant()
        {
            //create new consultant
        }

        public Consultant(List<Report> reports, string consultantID)
        {
            this.reports = reports;
            this.consultantID = consultantID;
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

        public void fillReportList()
        {
            //foreach row in dataset
            //create report and add to list
            DataSet dataSet = DatabaseAccess.getReportDataSet(consultantID);
            //dataSet.
            
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
