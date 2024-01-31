using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    public class Salary : UserAccount
    {
        public static int MinDepositAmount = 1000;
        public static int MaxWithdrawAmount = 1000;

        public Salary(string name, string number, DateTime creationDate, int amount)
        {
            Name = name;
            Number = number;
            CreationDate = creationDate;
            Amount = amount;
        }
    }
}
