namespace ATMClassLibrary;

public class ATMProcessing
{
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
