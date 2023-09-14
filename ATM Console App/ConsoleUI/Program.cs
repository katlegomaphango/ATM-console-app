using ATMClassLibrary;

public class Program
{
    private static void Main(string[] args)
    {
        int bankNum = HandleValidateBankNumber();
        int pinNum = HandleValidatePinNumber();


        int menuKey = Menu();

        //switch (menuKey)
        //{
        //    case 1: HandleDeposit(); break;
        //    case 2: HandleWithdraw(); break;
        //    case 3: HandleShowBalance(); break;
        //    default: Menu();
        //        break;
        //}
    }

    private static int HandleValidateBankNumber()
    {
        int cardNum;

        Console.Clear();
        Console.WriteLine("\n\n\t\tATM Console Application: Welcome...");
        Console.WriteLine("\n\t\tPlease enter your bank card (number):");
        Console.Write("\t\t");

        while (true)
        {
            try
            {
                cardNum = int.Parse(Console.ReadLine());
                break;
            }
            catch
            {
                Console.WriteLine("\t\tPlease enter valid card (number)...");
                Console.Write("\t\t");
            }
        }

        return cardNum;
    }

    private static int HandleValidatePinNumber()
    {
        int pin = 0;
        int AttemptsCount = 3;

        Console.WriteLine("\n\t\tPlease enter your pin number:");
        Console.Write("\t\t");

        while (AttemptsCount != 0)
        {
            try
            {
                pin = int.Parse(Console.ReadLine());
                AttemptsCount--;
                break;
            }
            catch
            {
                AttemptsCount--;
                Console.WriteLine("\t\tWrong pin. Please try again...");
                Console.Write("\t\t");
            }

        }

        if (AttemptsCount == 0)
        {
            Console.WriteLine("\n\t\tYou entered wrong pin 3 times, your account will be locked please contact you nearest branch...");
            Console.ReadKey();

            Environment.Exit(0);
        }

        return pin;
    }


    private static int Menu()
    {
        Console.Clear();
        Console.WriteLine("\n\n\t\tATM Console Application: Welcome...");
        Console.WriteLine("\n\n\t\tPlease choose an option ");
        Console.WriteLine("\n\t\t1: Deposit");
        Console.WriteLine("\t\t2: Withdraw");
        Console.WriteLine("\t\t3: Show Balance");
        Console.WriteLine("\t\t4: Exit");
        Console.Write("\t\t");

        if(!(int.TryParse(Console.ReadLine(), out int key)))
        {
            Menu();
        }

        return key;
    }

    public static void HandleDeposit(ATMUser user)
    {
        Console.Clear();
        Console.WriteLine("\n\n\t\tATM Console Application: Welcome...");
        Console.Write("\n\t\tEnter amount you would like to deposit: ");

        if(!(double.TryParse(Console.ReadLine(), out double amount)))
            HandleDeposit(user);

        //user.DepositMoney(amount);

        Console.WriteLine("\n\t\tThank for trusting us...");
        Console.WriteLine($"\t\tYour new balance is {user.Balance}");

    }

    public static void HandleWithdraw(ATMUser user)
    {
        Console.Clear();
        Console.WriteLine("\n\n\t\tATM Console Application: Welcome...");
        Console.Write("\n\t\tEnter amount you would like to Withdraw: ");

        if (!(double.TryParse(Console.ReadLine(), out double amount)))
            HandleWithdraw(user);

        //if (!user.WithdrawMoney(amount))
        //{
        //    Console.WriteLine($"Unfortunately you have insufficient funds to withdraw {amount}");
        //    Console.WriteLine($"Your current balance is: {user.Balance}");
        //}

        Console.WriteLine("\n\t\tThank for trusting us...");
        Console.WriteLine("\t\tPlease take you cash...");
        Console.WriteLine($"\t\tYour new balance is {user.Balance}");

    }

    public static void HandleShowBalance(ATMUser user)
    {
        Console.Clear();
        Console.WriteLine("\n\n\t\tATM Console Application: Welcome...");
        Console.WriteLine($"\n\t\tWelcome, your balance is R {user.Balance.ToString("C")}");

        Console.WriteLine("\n\t\tThank for trusting us...");
    }




}