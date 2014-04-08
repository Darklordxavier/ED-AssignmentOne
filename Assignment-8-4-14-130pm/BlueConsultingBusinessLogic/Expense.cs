using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BlueConsultingBusinessLogic
{
    public class Expense
    {
        public String Location { get; set; }
        public String Description { get; set; }
        public double Amount { get; set; }
        public String Currency { get; set; }
        public Image Receipt { get; set; } //later on, this will need to store multiple receipts

        public Expense(String location, String description, double amount, String currency, string receiptPdfFilePath)
        {
            //new expense
            this.Location = location;
            this.Description = description;
            this.Amount = amount;
            this.Currency = currency;

            if (receiptPdfFilePath != null)
            {
                this.Receipt = Image.FromFile(receiptPdfFilePath);
            }
            else
            {
                this.Receipt = null;
            }
        }

        public String GetExpense()
        {
            //omits receipts
            return String.Format("{0}, {1}, {2}, {3}", Location, Description, Amount, Currency);
        }
    }
}
