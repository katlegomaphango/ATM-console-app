using ATMClassLibrary;

public class Program
{
    private static void Main(string[] args)
    {
        int cardNum = HandleValidateBankNumber();
        int pinNum = HandleValidatePinNumber();

        ATMUser user = ATMProcessing.GetATMUser(cardNum, pinNum);

        Menu(user);

        Console.Clear();

        Console.WriteLine($"\n\n\t\tLogging out {user.FirstName} {user.LastName}...");
        Console.Write("\t\t");
        Thread.Sleep(2000);

        Console.WriteLine($"\n\t\tSuccessfully logged {user.FirstName} out!?");
        Thread.Sleep(1000);

        Console.WriteLine("\n\t\tThank you for using our services...");
        Thread.Sleep(1000);

        Console.WriteLine("\n\t\tBanking made easy... ");
        Thread.Sleep(1000);

        Console.Write("\t\tThank you. Bye...");
        Environment.Exit(0);
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

    private static void Menu(ATMUser user)
    {
        Console.Clear();
        Console.WriteLine($"\n\n\t\tATM Console Application: Welcome {user.FirstName}...");
        Console.WriteLine("\n\n\t\tPlease choose an option ");
        Console.WriteLine("\n\t\t1: Deposit");
        Console.WriteLine("\t\t2: Withdraw");
        Console.WriteLine("\t\t3: Show Balance");
        Console.WriteLine("\t\t4: Exit");
        Console.Write("\t\t");

        if(!(int.TryParse(Console.ReadLine(), out int key)))
        {
            Menu(user);
        }

        switch (key)
        {
            case 1: HandleDeposit(user); Menu(user); break;
            case 2: HandleWithdraw(user); Menu(user); break;
            case 3: HandleShowBalance(user); Menu(user); break;
            case 4: return; 
            default: Menu(user); break;
        }
    }

    public static void HandleDeposit(ATMUser user)
    {
        Console.Clear();
        Console.WriteLine("\n\n\t\tATM Console Application: Welcome...");
        Console.Write("\n\t\tEnter amount you would like to deposit: R ");

        if(!(double.TryParse(Console.ReadLine(), out double amount)))
            HandleDeposit(user);

        ATMProcessing.DepositMoney(user, amount);

        Console.WriteLine("\n\t\tThank for trusting us...");
        Console.WriteLine($"\t\tYour new balance is {user.Balance:C}");
        Console.WriteLine("\t\t");
        Thread.Sleep(3500);

    }

    public static void HandleWithdraw(ATMUser user)
    {
        Console.Clear();
        Console.WriteLine("\n\n\t\tATM Console Application: Welcome...");
        Console.Write("\n\t\tEnter amount you would like to Withdraw: R ");

        if (!(double.TryParse(Console.ReadLine(), out double amount)))
            HandleWithdraw(user);

        if (!ATMProcessing.WithdrawMoney(user, amount))
        {
            Console.WriteLine($"\n\t\tUnfortunately you have insufficient funds to withdraw {amount}");
            Console.WriteLine($"\t\tYour current balance is: R {user.Balance:C}");
            Thread.Sleep(3500);
            return;
        }

        Console.WriteLine("\n\t\tThank for trusting us...");
        Console.WriteLine("\t\tPlease take you cash...");
        Console.WriteLine($"\t\tYour new balance is R {user.Balance:C}");
        Thread.Sleep(3500);
    }

    public static void HandleShowBalance(ATMUser user)
    {
        Console.Clear();
        Console.WriteLine("\n\n\t\tATM Console Application: Welcome...");
        Console.WriteLine($"\n\t\tWelcome, your balance is R {user.Balance:C}");

        Console.WriteLine("\n\t\tThank for trusting us...");
        Thread.Sleep(3500);
    }

}