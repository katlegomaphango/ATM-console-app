public class Program
{
    private static void Main(string[] args)
    {
        char menuKey = Menu();
        
    }

    private static char Menu()
    {
        Console.WriteLine("\n\n\t\tATM Console Application: Welcome...");
        Console.WriteLine("\n\n\t\tPlease choose an option ");
        Console.WriteLine("\n\t\t1: Deposit");
        Console.WriteLine("\t\t2: Withdraw");
        Console.WriteLine("\t\t3: Show Balance");
        Console.Write("\t\t4: Exit");

        return Console.ReadKey().KeyChar;
    }
}