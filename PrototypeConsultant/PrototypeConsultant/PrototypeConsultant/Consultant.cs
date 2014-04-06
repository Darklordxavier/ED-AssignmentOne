using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrototypeConsultant
{
    public class Consultant
    {
        LinkedList<Report> reports = new LinkedList<Report>();

        public Consultant()
        {
            //create new consultant
        }

        public void addReport(Report report)
        {
            reports.AddLast(report);
        }

        public LinkedList<Report> getAllReports()
        {
            return reports;
        }

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

    }
}