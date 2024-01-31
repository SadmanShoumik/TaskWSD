using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    public class Current : UserAccount
    {
        public static int MinDepositAmount = 100;
        public static int MaxWithdrawAmount = 100;

        public Current(string name, string number, DateTime creationDate, int amount)
        {
            Name = name;
            Number = number;
            CreationDate = creationDate;
            Amount = amount;
        }
    }
}
