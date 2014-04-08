using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BlueConsultingBusinessLogic;

namespace GUI.Consultant
{
    public partial class SubmitReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Report report = new Report();
            report.ConsultantID = User.Identity.Name; //will need to get consultantID from database later on
            //report.ReportDate = DateTime.Now.ToString(); //give current report session a unique identifier
            Session["currentReport"] = report;
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            ClientScript.RegisterStartupScript(typeof(Page), "closePage", "window.close();", true);
        }

        protected void btnAddExpense_Click(object sender, EventArgs e)
        {
            string location = textboxLocation.Text;
            string description = textboxDescription.Text;
            int amount = Convert.ToInt32(textboxAmount.Text);
            string currency = dropdownlistCurrency.SelectedItem.ToString();
            string receipts = Server.MapPath(fupReceipts.FileName);

            Expense expense = new Expense(location, description, amount, currency, null);
            string reportStatus = "SubmittedByConsultant";

            Report report = new Report(User.Identity.Name, reportStatus, null);

            //adding expenses to current session of report
            if (Session["currentReport"] != null)
            {
                report = (Report)Session["currentReport"]; //get report from session
                report.addExpense(expense); //update model
                listboxExpenses.Items.Add(expense.GetExpense()); //update view
                Session["currentReport"] = report; //update session
            }
        }

        protected void btnSubmitReport_Click(object sender, EventArgs e)
        {
            //get stats from the form and store in DB
            Report report = (Report)Session["currentReport"];
            if (Session["currentReport"] != null)
            {
                BlueConsultingBusinessLogic.DatabaseAccess.insertReportToDatabase(report);
                labelStatus.Text = "report submitted successfully";
            }
        }
    }
}