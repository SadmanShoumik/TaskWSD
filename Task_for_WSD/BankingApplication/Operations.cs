using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BankingApplication
{
    public class Operations
    {
        #region Data Storage
        List<Current> current = new List<Current>();
        List<Savings> savings = new List<Savings>();
        List<Salary> salary = new List<Salary>();
        #endregion

        public void CreateAccount()
        {
            Console.Clear();

            Console.WriteLine("Welcome to Account Creation Interface!\nPlease Provide the Requested Information:\n\n");

            Console.WriteLine("What Type of Account Would You Like to Open?");
            Console.WriteLine("1. Current");
            Console.WriteLine("2. Savings");
            Console.WriteLine("3. Salary");

            Console.Write("Please Select an Option From Above (1,2,3): ");
            string accType = Console.ReadLine();

            try
            {
                int type = Int32.Parse(accType);
                if(type < 1 || type > 3)
                {
                    Console.WriteLine("Invalid Input! Please Try Again.");
                    return;
                }
            }
            catch
            {
                Console.WriteLine("Invalid Input! Please Try Again.");
                return;
            }
            

            Console.WriteLine("Enter Your Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Provide Your Number: ");
            string number = Console.ReadLine();

            if(!Validity(number, accType))
            {
                Console.WriteLine($"\nInvalid Account Number!\nThis Account Already Exists.");
                Console.WriteLine("\nPress Enter to Run Through the Process Again.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Enter the Amount You Would Like to Deposit Initially: ");
            string amountStr = Console.ReadLine();

            bool validity = false;


            if (accType == "1")
            {
                validity = Validity(Current.MinDepositAmount, amountStr);
            }
            else if (accType == "2")
            {
                validity = Validity(Savings.MinDepositAmount, amountStr);
            }
            else if (accType == "3")
            {
                validity = Validity(Salary.MinDepositAmount, amountStr);
            }

            DateTime creationDate = DateTime.Now;

            if (validity == false)
            {
                Console.WriteLine("\nPress Enter to Run Through the Process Again.");
                Console.ReadLine();
                return;
            }
            else if(validity == true)
            {
                if (accType == "1")
                {
                    current.Add(new Current(name, number, creationDate, Int32.Parse(amountStr)));
                }
                else if (accType == "2")
                {
                    current.Add(new Current(name, number, creationDate, Int32.Parse(amountStr)));
                }
                else if (accType == "3")
                {
                    current.Add(new Current(name, number, creationDate, Int32.Parse(amountStr)));
                }
                Console.WriteLine("\nCongratulations! Your Accout was Created Successfully!\nPress Enter to Go Proceed.");
                Console.ReadLine();
            }

        }

        public void ViewAllAccounts()
        {
            Console.Clear();
            if (current.Count > 0)
            {
                Console.WriteLine("Current Accounts:\n_________________\n\n");
                for(int i=0; i < current.Count; i++)
                {
                    Console.WriteLine($"{i+1}-> Name: {current[i].Name} Number: {current[i].Number}");
                }
            }
            
            if (savings.Count > 0)
            {
                Console.WriteLine("Savings Accounts:\n_________________\n\n");
                for (int i = 0; i < savings.Count; i++)
                {
                    Console.WriteLine($"{i + 1}-> Name: {savings[i].Name} Number: {savings[i].Number}");
                }
            }
            
            if (salary.Count > 0)
            {
                Console.WriteLine("Salary Accounts:\n_________________\n\n");
                for (int i = 0; i < current.Count; i++)
                {
                    Console.WriteLine($"{i + 1}-> Name: {salary[i].Name} Number: {salary[i].Number}");
                }
            }

            if (current.Count == 0 && savings.Count == 0 && salary.Count == 0)
            {
                Console.WriteLine("\n\nThere Are No Accounts to Display.\nPress Enter to Go to the Start Page.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\n\nPress Enter to Go to the Start Page.");
                Console.ReadLine();
            }
        }

        public void UpdateAccount()
        {
            Console.Clear();

            Console.WriteLine("What is the Type of Your Account?");
            Console.WriteLine("1. Current");
            Console.WriteLine("2. Savings");
            Console.WriteLine("3. Salary");

            Console.Write("\nPlease Select an Option From Above (1,2,3): ");
            string accType = Console.ReadLine();

            try
            {
                int type = Int32.Parse(accType);
                if (type < 1 || type > 3)
                {
                    Console.WriteLine("Invalid Input! Please Try Again.");
                    return;
                }
            }
            catch
            {
                Console.WriteLine("Invalid Input! Please Try Again.");
                return;
            }

            Console.WriteLine("Provide Your Account Number:");
            string number = Console.ReadLine();

            if (Validity(number, accType))
            {
                Console.WriteLine($"\nInvalid Account Number!\nThis Account Does Not Exist.");
                Console.WriteLine("\nPress Enter to Run Through the Process Again.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Enter New Name: ");
            string name = Console.ReadLine();

            if (accType == "1")
            {
                for(int i=0; i < current.Count; i++)
                {
                    if (current[i].Number == number)
                    {
                        current[i].Name = name;
                        break;
                    }
                }
            }
            else if (accType == "2")
            {
                for (int i = 0; i < savings.Count; i++)
                {
                    if (savings[i].Number == number)
                    {
                        savings[i].Name = name;
                        break;
                    }
                }
            }
            else if (accType == "3")
            {
                for (int i = 0; i < salary.Count; i++)
                {
                    if (salary[i].Number == number)
                    {
                        salary[i].Name = name;
                        break;
                    }
                }
            }

            Console.WriteLine("Account Updated Successfully!\nPress Enter to Proceed.");
            Console.ReadLine();
            return;
        }
        
        public void DeleteAccount()
        {
            Console.Clear();

            Console.WriteLine("What is the Type of Your Account?");
            Console.WriteLine("1. Current");
            Console.WriteLine("2. Savings");
            Console.WriteLine("3. Salary");

            Console.Write("\nPlease Select an Option From Above (1,2,3): ");
            string accType = Console.ReadLine();

            try
            {
                int type = Int32.Parse(accType);
                if (type < 1 || type > 3)
                {
                    Console.WriteLine("Invalid Input! Please Try Again.");
                    return;
                }
            }
            catch
            {
                Console.WriteLine("Invalid Input! Please Try Again.");
                return;
            }

            Console.WriteLine("Provide Your Account Number:");
            string number = Console.ReadLine();

            if (Validity(number, accType))
            {
                Console.WriteLine($"\nInvalid Account Number!\nThis Account Does Not Exist.");
                Console.WriteLine("\nPress Enter to Run Through the Process Again.");
                Console.ReadLine();
                return;
            }

            if (accType == "1")
            {
                for (int i = 0; i < current.Count; i++)
                {
                    if (current[i].Number == number)
                    {
                        current.RemoveAt(i);
                        break;
                    }
                }
            }
            else if (accType == "2")
            {
                for (int i = 0; i < savings.Count; i++)
                {
                    if (savings[i].Number == number)
                    {
                        savings.RemoveAt(i);
                        break;
                    }
                }
            }
            else if (accType == "3")
            {
                for (int i = 0; i < salary.Count; i++)
                {
                    if (salary[i].Number == number)
                    {
                        salary.RemoveAt(i);
                        break;
                    }
                }
            }

            Console.WriteLine("Account Deleted Successfully!\nPress Enter to Proceed.");
            Console.ReadLine();
            return;
        }

        public bool Validity(string number, string accType)
        {
            if(accType == "1")
            {
                foreach(var num in current)
                {
                    if(num.Number == number)
                    {
                        return false;
                    }
                }
            }
            else if (accType == "2")
            {
                foreach (var num in savings)
                {
                    if (num.Number == number)
                    {
                        return false;
                    }
                }
            }
            else if (accType == "3")
            {
                foreach (var num in salary)
                {
                    if (num.Number == number)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public bool Validity(int minLimit, string amountStr)
        {
            int amount = 0;
            try
            {
                amount = Int32.Parse(amountStr);
            }
            catch
            {
                Console.WriteLine("\nInvalid Amount!\nAmount Must Only Contain Numbers!");
                return false;
            }

            if (amount < 0)
            {
                Console.WriteLine($"\nInvalid Amount!\nAmount Cannot Be Negative!");
                return false;
            }
            else if (amount < minLimit)
            {
                Console.WriteLine($"\nInvalid Amount!\nThe Minimum Amount for This Action is: {minLimit} USD!");
                return false;
            }

            return true;
        }
    }
}
