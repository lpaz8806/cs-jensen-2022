namespace L06Inheritance.Examples;

public class SavingAccount : BankAccount
{
    private DateTime lastWithdrawDate = DateTime.Now;
    private int intervalInMonths;
    public SavingAccount(
        string owner,
        decimal initialSaldo,
        int intervalInMonths)
        : base(owner, initialSaldo)
    {
        this.intervalInMonths = intervalInMonths;
    }

    public new void Withdraw(decimal amount)
    {
        if ((DateTime.Now - lastWithdrawDate).Days < 30 * intervalInMonths)
            throw new InvalidOperationException("Your money is frozen");
        
        base.Withdraw(amount);
    }
}