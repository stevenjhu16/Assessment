using AppCore.Contracts.Repos;
using AppCore.Entities;

namespace Infrastructure.Repos
{
    public class TransactionRepo : ITransactionRepo
    {
        public IEnumerable<Transaction> GetTransactions()
        {
            var transaction_list = new List<Transaction>();

            transaction_list.Add(new Transaction //Points: 90
            {
                Transaction_Id = 1,
                Customer_Id = 1,
                Transaction_Date = DateTime.Now.AddMonths(-5),
                Transaction_Amount = 120
            });
            transaction_list.Add(new Transaction //Points: 50
            {
                Transaction_Id = 2,
                Customer_Id = 1,
                Transaction_Date = DateTime.Now.AddMonths(-4),
                Transaction_Amount = 100
            });
            transaction_list.Add(new Transaction //Points: 40
            {
                Transaction_Id = 3,
                Customer_Id = 1,
                Transaction_Date = DateTime.Now.AddMonths(-3),
                Transaction_Amount = 90
            });
            transaction_list.Add(new Transaction //Points: 0
            {
                Transaction_Id = 4,
                Customer_Id = 1,
                Transaction_Date = DateTime.Now.AddMonths(-2),
                Transaction_Amount = 50
            });
            transaction_list.Add(new Transaction //Points: 0
            {
                Transaction_Id = 5,
                Customer_Id = 1,
                Transaction_Date = DateTime.Now.AddMonths(-1),
                Transaction_Amount = 40
            });
            return transaction_list;
        }
    }
}
