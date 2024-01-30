

using BankingApplication;
using System.Linq.Expressions;

#region Initialize Operation Class
Operations op = new Operations();
#endregion

#region Interface
while (true)
{
    int currentOption = 4;

    while (true)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Banking Application!\nPlease Choose an Action to Perform from the List Provided Below (Use the Arrow Keys to Navigate This Menu):\n\n");
        Console.WriteLine("  1. Create a New Account");
        Console.WriteLine("  2. Display All Accounts");
        Console.WriteLine("  3. Update an Account");
        Console.WriteLine("  4. Delete an Account");
        Console.WriteLine("  5. Deposit an Amount Into Your Account");
        Console.WriteLine("  6. Withdraw an Amount from Your Account");
        Console.WriteLine("  7. Search for Account");
        Console.WriteLine("  8. Exit");


        Console.SetCursorPosition(0, currentOption);
        Console.Write('>');

        ConsoleKeyInfo keyInfo = Console.ReadKey(true);

        if (keyInfo.Key == ConsoleKey.Enter)
        {
            break;
        }
        else if (keyInfo.Key == ConsoleKey.UpArrow)
        {
            currentOption--;
            if (currentOption < 4)
            {
                currentOption = 11;
            }
        }
        else if (keyInfo.Key == ConsoleKey.DownArrow)
        {
            currentOption++;
            if (currentOption > 11)
            {
                currentOption = 4;
            }
        }
    }

    currentOption -= 3;
    switch (currentOption)
    {
        case 1:
            //Console.WriteLine("1");
            op.CreateAccount();
            break;
        case 2:
            //Console.WriteLine("2");
            op.ViewAllAccounts();
            break;
        case 3:
            Console.WriteLine("3");
            break;
        case 4:
            Console.WriteLine("4");
            break;
        case 5:
            Console.WriteLine("5");
            break;
        case 6:
            Console.WriteLine("6");
            break;
        case 7:
            Console.WriteLine("7");
            break;
        case 8:
            Console.WriteLine("8");
            break;
        default:
            break;
    }
}
#endregion


