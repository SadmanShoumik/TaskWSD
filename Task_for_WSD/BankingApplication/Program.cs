

using BankingApplication;
using System.Linq.Expressions;

#region Data Storage
List<AccountTier1> account1 = new List<AccountTier1>();
List<AccountTier2> account2 = new List<AccountTier2>();
List<AccountTier3> account3 = new List<AccountTier3>();
#endregion

#region Initialize Operation Class
Operations op = new Operations();
#endregion

#region Interface
//while (true)
//{
//    int currentOption = 4;

//    while (true)
//    {
//        Console.Clear();
//        Console.WriteLine("Welcome to the Banking Application!\nPlease Choose an Action to Perform from the List Provided Below:\n\n");
//        Console.WriteLine("  1. Create a New Account");
//        Console.WriteLine("  2. Display All Accounts");
//        Console.WriteLine("  3. Update an Account");
//        Console.WriteLine("  4. Delete an Account");
//        Console.WriteLine("  5. Deposit an Amount Into Your Account");
//        Console.WriteLine("  6. Withdraw an Amount from Your Account");
//        Console.WriteLine("  7. Search for Account");
//        Console.WriteLine("  8. Exit");


//        Console.SetCursorPosition(0, currentOption);
//        Console.Write('>');

//        ConsoleKeyInfo keyInfo = Console.ReadKey(true);

//        if (keyInfo.Key == ConsoleKey.Enter)
//        {
//            break;
//        }
//        else if (keyInfo.Key == ConsoleKey.UpArrow)
//        {
//            currentOption--;
//            if (currentOption < 4)
//            {
//                currentOption = 11;
//            }
//        }
//        else if (keyInfo.Key == ConsoleKey.DownArrow)
//        {
//            currentOption++;
//            if (currentOption > 11)
//            {
//                currentOption = 4;
//            }
//        }
//    }

//    currentOption -= 3;
//    switch (currentOption)
//    {
//        case 1:
//            Console.WriteLine("1");
//            break;
//        case 2:
//            Console.WriteLine("2");
//            break;
//        case 3:
//            Console.WriteLine("3");
//            break;
//        case 4:
//            Console.WriteLine("4");
//            break;
//        case 5:
//            Console.WriteLine("5");
//            break;
//        case 6:
//            Console.WriteLine("6");
//            break;
//        case 7:
//            Console.WriteLine("7");
//            break;
//        case 8:
//            Console.WriteLine("8");
//            break;
//        default:
//            break;
//    }
//}
#endregion



account1.Add(new AccountTier1("Admin", "012xxx", DateTime.Now, 500));
//account1.Add(new AccountTier1("Admin", "012xxx", DateTime.Now, 500));
////Console.WriteLine($"{account1[0].Name} {account1[0].Number} {account1[0].CreationDate} {account1[0].Amount} {account1[0].MinDepositAmount}");
//account1[0].DepositMoney("a50");

op.CreateAccount(ref account1);
