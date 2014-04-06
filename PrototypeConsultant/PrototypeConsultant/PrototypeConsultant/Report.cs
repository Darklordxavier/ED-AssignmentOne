using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrototypeConsultant
{
    public class Report
    {
        LinkedList<Expense> expenses = new LinkedList<Expense>();
        public String ConsultantID { get; set; } //later on, we need to get this from database
        public String ReportDate { get; set; }

        public Report()
        {

        }

        public void addExpense(Expense expense)
        {
            expenses.AddLast(expense);
        }

        public LinkedList<Expense> getExpenses()
        {
            //return list of expenses
            return expenses;
        }

        public String getFormattedReport()
        {
            String header = String.Format("{0}, {1}", ConsultantID, ReportDate);
            String body = "\nExpenses: ";

            foreach (Expense expense in expenses)
            {
                body += expense.GetExpense(); //can't seem to get expenses
            }

            return header + body;
        }
    }
}