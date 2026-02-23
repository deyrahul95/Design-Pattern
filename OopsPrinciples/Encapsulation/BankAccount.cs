namespace OopsPrinciples.Encapsulation;

/// <summary>
/// In this bank account class it encapsulate the account data (balance) and all the related method (deposit, withdraw).
/// This prevent the direct access of the data (balance) from outside of the class.
/// </summary>
public class BankAccount
{
    /// <summary>
    /// Private member Balance
    /// </summary>
    private decimal Balance;

    /// <summary>
    /// Initialize a bank account instant
    /// </summary>
    /// <param name="amount">The amount user want to deposit in the account</param>
    public BankAccount(decimal amount)
    {
        Deposit(amount);
    }

    /// <summary>
    /// Deposit an amount from the account
    /// </summary>
    /// <param name="amount">The amount value</param>
    public void Deposit(decimal amount)
    {
        ValidateAmount(amount);

        Balance += amount;
    }

    /// <summary>
    /// Withdraw an amount from the account
    /// </summary>
    /// <param name="amount">The amount value</param>
    /// <exception cref="ArgumentException">Argument exception for insufficient funds</exception>
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

    /// <summary>
    /// Get current account balance
    /// </summary>
    /// <returns>Returns balance value</returns>
    public decimal GetBalance()
    {
        return Balance;
    }


    /// <summary>
    /// Validate if amount is valid or not
    /// </summary>
    /// <param name="amount">The amount value</param>
    /// <exception cref="ArgumentException">Argument exception for invalid amount</exception>
    private static void ValidateAmount(decimal amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException("Amount can't be negative!");
        }
    }
}
