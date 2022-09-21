namespace L06Inheritance.Examples;

public class CreditBankAccount : BankAccount
{
    private decimal creditLimit;
    private decimal creditUsed = 0;
    public CreditBankAccount(string owner, decimal initialSaldo, decimal creditLimit)
        : base(owner, initialSaldo)
    {
        this.creditLimit = creditLimit;
    }

    public decimal PurchasePower => creditLimit + Saldo - creditUsed;

    public new void Withdraw(decimal amount)
    {
        if (amount < Saldo)
        {
            base.Withdraw(amount);
            return;
        }

        if (creditUsed > creditLimit)
            throw new InvalidOperationException("You burnt out your credit, despicable consumist");

        creditUsed += amount;
    }
    
    public void OpenChampagne()
    {
        Console.WriteLine("Pufffff!");
    }
}