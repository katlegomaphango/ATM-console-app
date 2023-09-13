public class Program
{
    private static void Main(string[] args)
    {
        int menuKey = Menu();
        Console.WriteLine(menuKey);
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
}