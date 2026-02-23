using OopsPrinciples.Encapsulation;

var bankAccount = new BadBankAccount
{
    Balance = 100
};

System.Console.WriteLine(bankAccount.Balance);

// But clint app can modify this balance, no encapsulation
bankAccount.Balance = -500;
System.Console.WriteLine(bankAccount.Balance); 

// var account = new BankAccount(-500); // Throw an exception
var account = new BankAccount(100);
var balance = account.GetBalance();
Console.WriteLine($"Your Current Balance: $ {balance}");


// account.Balance = -500; // Client can't directly access the data member as it is encapsulated properly.
// account.Withdraw(200); // Throw an exception as account has only 100 balance! Correctly implement the business rule.  
account.Deposit(500);
account.Withdraw(200);
balance = account.GetBalance();
Console.WriteLine($"Your Current Balance: $ {balance}");