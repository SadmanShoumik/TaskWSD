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

        public override void DepositMoney(string depositAmount)
        {
            int amount;
            try
            {
                amount = Int32.Parse(depositAmount);
            }
            catch
            {
                Console.WriteLine("Invalid Amount!\nAmount Must Only Contain Numbers!");
                return;
            }

            if(amount < 0)
            {
                Console.WriteLine($"Invalid Amount!\nAmount Cannot Be Negative!");
            }
            else if (amount < MinDepositAmount)
                Console.WriteLine($"Invalid Amount!\nThe Minimum Amount for This Action is: {MinDepositAmount} USD!");
            else
            {
                Amount += amount;
                Console.WriteLine($"Deposit Successful!\n{amount} USD Has Successfully been Added to Your Account!");
            }
        }
    }
}
