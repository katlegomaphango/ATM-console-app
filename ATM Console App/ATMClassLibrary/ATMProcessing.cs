namespace ATMClassLibrary;

public class ATMProcessing
{
    public static bool CardNumExist(int cardNum)
    {
        ATMUser user = ATMDataBase.ATMUsers.FirstOrDefault(u => u.CardNumber == cardNum);
        
        if(user == null) 
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
