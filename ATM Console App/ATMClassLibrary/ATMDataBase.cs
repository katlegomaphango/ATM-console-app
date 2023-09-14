namespace ATMClassLibrary;

public class ATMDataBase
{
    public static readonly List<ATMUser> ATMUsers = new()
    {
        new ATMUser(1835760368, "Gcina", "Mkhonto", 1234, 150.78),
        new ATMUser(1393589365, "Sbu", "Buda", 1235, 0.20),
        new ATMUser(0691958988, "Sabelo", "Mpangeni", 1236, 1245.01),
        new ATMUser(1981855144, "Obama", "Mphahlele", 1237, 20.48),
        new ATMUser(0215668866, "Nhlnhla", "Mthembu", 1238, 405.50),
    };
}
