using ATMClassLibrary;

public class Program
{
    private static void Main(string[] args)
    {
        int menuKey = Menu();

        switch (menuKey)
        {
            case 1: HandleDeposit(); break;
            default:
                break;
        }
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

        user.DepositMoney(amount);

        Console.WriteLine("\n\t\tThank for trusting us...");
        Console.WriteLine($"\t\tYour new balance is {user.Balance}");

    }
}