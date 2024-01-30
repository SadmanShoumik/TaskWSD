using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    public class AccountTier1 : UserAccount
    {
        public static int MinDepositAmount = 100;
        public static int MaxWithdrawAmount = 1000;

        public AccountTier1(string name, string number, DateTime creationDate, int amount)
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
                Console.WriteLine($"Invalid Amount!\nYou Cannot Deposit a Negative Amount of Money!");
            }
            else if (amount < MinDepositAmount)
                Console.WriteLine($"Invalid Amount!\nThe Minimum Deposit Amount for Your Account is: {MinDepositAmount} USD!");
            else
            {
                Amount += amount;
                Console.WriteLine($"Deposit Successful!\n{amount} USD Has Successfully been Added to Your Account!");
            }
        }
    }
}
