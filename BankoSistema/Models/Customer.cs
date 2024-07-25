using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankoSistema.Models
{
    internal class Customer
    {
        public string Name { get; set; }
        public List<Account> Accounts { get; set; }

        public Customer(string name, List<Account> accounts)
        {
            Name = name;
            Accounts = accounts;
        }

        public double GetTotalBalance()
        {
            double totalBalance = 0;

            foreach (var account in Accounts)
            {
                totalBalance += account.Balance;
            }
            return totalBalance;
        }
    }
}
