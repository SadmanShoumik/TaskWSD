using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    public class UserAccount
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public DateTime CreationDate { get; set; }
        public int Amount { get; set; }

        public virtual void DepositMoney(string depositAmount)
        {
            throw new NotImplementedException();
        }
    }
}
