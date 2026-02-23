namespace OopsPrinciples.Encapsulation;

/// <summary>
/// In this bank account class it encapsulate the account data (balance) and all the related method (deposit, withdraw).
/// This prevent the direct access of the data (balance) from outside of the class.
/// 
/// </summary>
public class BankAccount
{
    private decimal Balance;

    public BankAccount(decimal amount)
    {
        Deposit(amount);
    }

    public void Deposit(decimal amount)
    {
        ValidateAmount(amount);

        Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        ValidateAmount(amount);

        // We are assumed bank amount balance can't be zero. 
        if (amount >= Balance)
        {
            throw new ArgumentException("Insufficient funds!");
        }

        Balance -= amount;
    }

    public decimal GetBalance()
    {
        return Balance;
    }

    private static void ValidateAmount(decimal amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException("Amount can't be negative!");
        }
    }
}
