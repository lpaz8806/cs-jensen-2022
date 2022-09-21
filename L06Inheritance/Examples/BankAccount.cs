namespace L06Inheritance.Examples;

/*
 * Implement a class representing a bank account.
 * A bank account should have the following features:
 * - Deposit the specified amount of money
 * - Withdraw the specified amount of money.
 *   When the amount of money to widthrdaw is greater than the
 *   saldo the operation must fail.
 * - Transfer the specified amount to another account
 * - Ask for the Saldo of the account
 * - Ask for the Name of the owner
*/

public class BankAccount
{
    public string Owner { get; }
    public decimal Saldo { get; private set; }
    public BankAccount(string owner, decimal initialSaldo)
    {
        Owner = owner;
        Saldo = initialSaldo;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("");
        
        Saldo += amount;
    }
    
    public void Withdraw(decimal amount)
    {
        if (amount > Saldo)
            throw new InvalidOperationException(
                "You don't have enough fund, you poor soul");
        
        Saldo -= amount;
    }
    public void Transfer(decimal amount, BankAccount other)
    {
        Withdraw(amount);
        other.Deposit(amount);
    }
}

