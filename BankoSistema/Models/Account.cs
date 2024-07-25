using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BankoSistema.Models
{
    internal class Account
    {
        public string Number { get; set; }
        public double Balance { get; set; }
        public List<Transaction> Transactions { get; set; }

        public Account(string number, double balance, List<Transaction> transactions)
        {
            Number = number;
            Balance = balance;
            Transactions = transactions;
        }

        public double Deposit(double amount)
        {
            Balance += amount;
            Transaction transaction = new Transaction(amount, "Deposit");
            Transactions.Add(transaction);

            return Balance;
        }

        public double Withdraw(double amount)
        {
            Balance -= amount;
            Transaction transaction = new Transaction(amount, "Withdraw");
            Transactions.Add(transaction);

            return Balance;
        }


    }
}
