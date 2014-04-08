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
        LinkedList<Report> reports = new LinkedList<Report>();
        string consultantID;
        public Consultant()
        {
            //create new consultant
        }

        public void addReport(Report report)
        {
            reports.AddLast(report);
        }

        public void submitReportToDatabase()
        {
            //DatabaseAccess.insertReportToDatabase(
        }
        public LinkedList<Report> getAllReports()
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
