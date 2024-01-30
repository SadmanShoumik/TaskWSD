using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    public class Operations
    {
        public void CreateAccount<T>( ref List<T> accountList)
        {
            Console.Clear();

            Console.WriteLine("Welcome to Account Creation Interface!\nPlease Provide the Requested Information:\n\n");

            //Console.WriteLine("Enter Your Name: ");
            //string name = Console.ReadLine();

            //Console.WriteLine("Provide Your Number: ");
            //string number = Console.ReadLine();

            //Console.WriteLine("Provide Your Number: ");
            //string amount = Console.ReadLine();

            Type type = accountList.GetType();
            Console.WriteLine($"KEK {type}");

            //DateTime creationDate = DateTime.Now;


        }
    }
}
