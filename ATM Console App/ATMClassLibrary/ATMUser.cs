namespace ATMClassLibrary;

public class ATMUser
{
    private int cardNumber;
    private string firstName;
    private string lastName;
    private int pinNumber;
    private double balance;

    public ATMUser(int card, string name, string lastname, int pin, double balance)
    {
        this.cardNumber = card;
        this.firstName = name;
        this.lastName = lastname;
        this.pinNumber = pin;
        this.balance = balance;
    }

    public int CardNumber { get { return cardNumber;  } set { cardNumber = value; } }
    public string FirstName { get { return firstName; } set { firstName = value; } }
    public string LastName { get { return lastName; } set { lastName = value; } }
    public int PinNumber { get { return pinNumber; } set {  pinNumber = value; } }
    public double Balance { get { return balance; } set { balance = value; } }
}
