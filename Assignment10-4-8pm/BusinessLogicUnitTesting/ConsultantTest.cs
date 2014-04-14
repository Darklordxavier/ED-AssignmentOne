using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlueConsultingBusinessLogic;
using System.Transactions;

namespace BusinessLogicUnitTesting
{
    [TestClass]
    class ConsultantTest
    {
        [TestMethod]
        public void testConsultant()
        {

        }

        public void testConsultantConstructorAndProperties()
        {
            //Tests the consultant constructor and getters
            List<Report> testReports = new List<Report>();
            string testConsultantId = "testPerson";

            Consultant consultant = new Consultant(new List<Report>, testConsultantId);

            Expenses expenses = new Expenses();
            Expenses.ExpensesRow expense = expenses._Expenses.NewExpensesRow();
            expense.Date = new DateTime(2014, 3, 18);
            expense.Location = "Sydney";
            expense.Description = "Airfare Sydney to Tokyo.";
            expense.Amount = 2497;

            // start transaction
            using (TransactionScope testTransaction = new TransactionScope())
            {
                ExpenseManager expenseManager = new ExpenseManager();
                expense.Id = expenseManager.AddExpense(expense);

                Assert.IsTrue(expense.Id > 0, "New Id is not > 0");

                Assert.IsTrue(IsDataInDatabase(expense));

                testTransaction.Dispose(); // rollback
            }
        }
    }
}
