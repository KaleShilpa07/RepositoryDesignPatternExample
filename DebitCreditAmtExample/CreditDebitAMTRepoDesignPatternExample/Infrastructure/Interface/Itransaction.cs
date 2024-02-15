namespace DebitCreditAmtExample.Infrastructure.Interface
{
    public interface Itransaction
    {
        decimal Balance { get; }
        void Deposit(decimal amount);
        void WithDraw(decimal amount);
    }
}
