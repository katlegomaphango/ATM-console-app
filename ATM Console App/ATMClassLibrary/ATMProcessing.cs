namespace ATMClassLibrary;

public class ATMProcessing
{
    public static ATMUser GetATMUser(int cardNumber, int pinNumber)
    {
        return ATMDataBase.ATMUsers.FirstOrDefault(user => user.CardNumber == cardNumber && user.PinNumber == pinNumber);
    }

    public static bool ValidateCardCredentials(int credential)
    {
        ATMUser user;
        int length = credential.ToString().Length;

        if (length == 4)
            user = ATMDataBase.ATMUsers.FirstOrDefault(u => u.PinNumber == credential);
        else
            user = ATMDataBase.ATMUsers.FirstOrDefault(u => u.CardNumber == credential);

        if (user == null) 
            return false;
        else
            return true;
    }

    public static void DepositMoney(ATMUser user, double amount)
    {
        user.Balance += amount;
    }

    public static Boolean WithdrawMoney(ATMUser user, double amount)
    {
        if (amount > user.Balance)
            return false;

        user.Balance -= amount;
        return true;


        //double temp = balance;
        //double result = this.balance - amount;

        //if (result > 0)
        //{
        //    this.balance = result;
        //    return true;
        //} 
        //return false;        

    }
}
