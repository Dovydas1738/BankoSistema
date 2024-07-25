using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankoSistema.Models
{
    internal class Transaction
    {
        double Amount { get; set; }
        string Type { get; set; }

        public Transaction(double amount, string type)
        {
            Amount = amount;
            Type = type;
        }
    }
}
