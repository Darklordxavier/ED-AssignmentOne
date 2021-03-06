﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrototypeConsultant
{
    public class Expense
    {
        public String Location { get; set; }
        public String Description { get; set; }
        public double Amount { get; set; }
        public String Currency { get; set; }
        public String Receipts { get; set; } //later on, this will need to store multiple receipts

        public Expense(String location, String description, double amount, String currency, String receipts)
        {
            //new expense
            this.Location = location;
            this.Description = description;
            this.Amount = amount;
            this.Currency = currency;
            this.Receipts = receipts; //later on, this will need to store multiple receipts
        }

        public String GetExpense()
        {
            return String.Format("{0}, {1}, {2}, {3}, {4}", Location, Description, Amount, Currency, Receipts);
        }

    }
}