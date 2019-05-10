using System;

namespace SimpleBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(1, "Dimitris", "Athens");
            var account = new AnalyticAccount(person);

            account.LoadJSON();
            account.Deposit(1);
            account.Withdraw(2);
            account.SaveToJSON();

            //Console.Write(account);
            //account.PrintTransactions();
            //account.Deposit(50);
            //account.Deposit(120);
            //account.Deposit(80);
            //account.Withdraw(1000);
            //account.PrintTransactions();
            //account.SaveToFile("myFile.txt");
            //account.SaveToJSON();
        }
    }
}
