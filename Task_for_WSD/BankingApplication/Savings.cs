using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    public class Savings : UserAccount
    {
        public static int MinDepositAmount = 500;
        public static int MaxWithdrawAmount = 500;

        public Savings(string name, string number, DateTime creationDate, int amount)
        {
            Name = name;
            Number = number;
            CreationDate = creationDate;
            Amount = amount;
        }
    }
}
