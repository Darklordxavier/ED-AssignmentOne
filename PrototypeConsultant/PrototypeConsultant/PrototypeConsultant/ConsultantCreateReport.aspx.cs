using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrototypeConsultant
{
    public partial class ConsultantReportDialog : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Report report = new Report();
            report.ConsultantID = "Consultant#001"; //will need to get consultantID from database later on
            report.ReportDate = DateTime.Now.ToString(); //give current report session a unique identifier
            Session["report"] = report;
        }

        protected void btnAddExpense_Click(object sender, EventArgs e)
        {
            //getting data from form
            String location = textboxLocation.Text;
            String description = textboxDescription.Text;
            double amount = Convert.ToDouble(textboxAmount.Text);
            String currency = dropdownlistCurrency.SelectedItem.ToString();
            String receipts = textboxReceipts.Text;

            //create new expense
            Expense expense = new Expense(location, description, amount, currency, receipts);
            Report report = new Report();

            //adding expenses to current session of report
            if (Session["report"] != null)
            {
                report = (Report)Session["report"]; //get report from session
                report.addExpense(expense); //update model
                listboxExpenses.Items.Add(expense.GetExpense()); //update view
                Session["report"] = report; //update session
            }
        }

        protected void btnSubmitReport_Click(object sender, EventArgs e)
        {
            //need to send the report to the listbox in consultant page
            Report report = (Report)Session["report"];
            if (Session["report"] != null)
            {
                Consultant consultant = new Consultant();
                consultant.addReport(report);
                Session["Consultant"] = consultant;
                labelStatus.Text = "Report was added successfully.";
            }
            else
            {
                labelStatus.Text = "Report is fucked up. Fix your code.";
            }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("ConsultantPage.aspx");
        }

    }
}