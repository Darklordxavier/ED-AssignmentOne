using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BlueConsultingBusinessLogic;

namespace GUI.ConsultantFolder
{
    public partial class SubmitReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Report report = new Report();
            report.ConsultantID = "Consultant#001"; //will need to get consultantID from database later on
            report.ReportDate = DateTime.Now.ToString(); //give current report session a unique identifier
            //Session["report"] = report;
        }

        protected void btnSubmitReport_Click(object sender, EventArgs e)
        {
            //get dtats from the form and store in DB
            //need to send the report to the listbox in consultant page
            //Report report = (Report)Session["report"];
            //if (Session["report"] != null)
            //{
            //    Consultant consultant = new Consultant();
            //    consultant.addReport(report);
            //    Session["Consultant"] = consultant;
            //    lblStatus.Text = "Report was added successfully.";
            //}
            //else
            //{
            //    lblStatus.Text = "Report is fucked up. Fix your code.";
            //}
            
            //String description
            //txtDescription.Text;



        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            ClientScript.RegisterStartupScript(typeof(Page), "closePage", "window.close();", true);
        }
    }
}