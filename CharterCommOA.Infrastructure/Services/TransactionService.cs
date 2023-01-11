using AppCore.Contracts.Repos;
using AppCore.Contracts.Services;

namespace Infrastructure.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepo _transactionRepo;
        public TransactionService(ITransactionRepo transactionRepo)
        {
            _transactionRepo = transactionRepo;
        }

        //Calculate and return points from transaction amount
        public decimal RewardAlgorithm(decimal transaction_amount)
        {
            decimal points = 0;
            if (transaction_amount > 100)
            {
                decimal val = transaction_amount - 100;
                points += Math.Floor(val) * 2;
            }
            if (transaction_amount > 50)
            {
                points += Math.Floor(Math.Min(transaction_amount, 100)) - 50;
            }
            return points;
        }

        public decimal GetMonthlyPoints(int targetMonth, int customerId)
        {
            var transactionsQuery = _transactionRepo.GetTransactions().Where(
                m => m.Customer_Id == customerId &&
                //Target Month ==  Month Delta + Year Delta * 12
                (targetMonth == ((DateTime.Today.Month - m.Transaction_Date.Month) + (DateTime.Today.Year - m.Transaction_Date.Year)*12))
             );

            decimal points = 0;
            foreach (var transaction in transactionsQuery)
            {
                points += RewardAlgorithm(transaction.Transaction_Amount);
            }
            return points;
        }

        public decimal GetQuarterlyPoints(int customerId)
        {
            var transactionsQuery = _transactionRepo.GetTransactions().Where(
                m => m.Customer_Id == customerId &&
                // Month Delta + Year Delta * 12 <= 3
                (((DateTime.Today.Month - m.Transaction_Date.Month) + (DateTime.Today.Year - m.Transaction_Date.Year) * 12) <= 3)
            );

            decimal points = 0;
            foreach (var transaction in transactionsQuery)
            {
                points += RewardAlgorithm(transaction.Transaction_Amount);
            }
            return points;
        }
    }
}
