

using DebitCreditAmtExample.DataContext;
using DebitCreditAmtExample.Infrastructure.Interface;
using DebitCreditAmtExample.Model;

namespace DebitCreditAmtExample.Infrastructure.Repository
{
    public class TransactionRepo : Itransaction
    {
        private readonly ComponyContext _cc;

        public decimal Balance{ get; private set; }
        public TransactionRepo(ComponyContext cc)
        {
            _cc = cc;
            Balance = _cc.transactions.Sum(t => t.Amount);//initialize balance
        }

        public void Deposit(decimal amount)
        {
           var transaction =new Transaction { Amount=amount };
            _cc.transactions.Add(transaction);
            _cc.SaveChanges();

            Balance += amount;
        }

        public void WithDraw(decimal amount)
        {
            var transaction = new Transaction { Amount = - amount };
            _cc.transactions.Add(transaction);
            _cc.SaveChanges();

            Balance += amount;
        }
    }
}
