using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrototypeConsultant
{
    public partial class ConsultantPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //update the date time using session?
            labelDate.Text = DateTime.Now.ToString();

            Consultant consultant = (Consultant)Session["consultant"];
            LinkedList<Report> reports = new LinkedList<Report>();

            if (consultant != null)
            {
                reports = consultant.getAllReports();

                foreach (Report report in reports)
                {
                    String reportData = String.Format("{0}", report.ReportDate); //could add more identifiers?
                    listboxReports.Items.Add(reportData);
                }
            }

        }

        protected void btnCreateReport_Click(object sender, EventArgs e)
        {
            Response.Redirect("ConsultantCreateReport.aspx");
        }

        protected void btnShowReport_Click(object sender, EventArgs e)
        {
            Consultant consultant = (Consultant)Session["consultant"];
            
            if (consultant != null)
            {
                //find and print report
                //later on make sure user selected something

                String selectedReport = listboxReports.SelectedItem.ToString();
                Report report = consultant.getReport(selectedReport); //here lies the problem

                if (report != null) //if report is found
                {
                    Session["reportPreview"] = report.getFormattedReport();
                    Response.Redirect("ConsultantShowReport.aspx");
                }
            }
        }
    }
}