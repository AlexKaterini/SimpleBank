using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleBank
{
    public class Transaction
    {
        public DateTime datetime { set; get; }
        public double amount { set; get; }
        public string action { set; get; }
        public string actor { set; get; }
                
        public Transaction(DateTime datetime, double amount, string action, string actor)
        {
            this.datetime = datetime;
            this.amount = amount;
            this.action = action;
            this.actor = actor;
        }

        public override string ToString()
        {
            return $"datatetime {datetime} amount {amount} action {action} actor {actor}";
        }
    }
}
