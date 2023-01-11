using AppCore.Entities;

namespace AppCore.Contracts.Repos
{
    public interface ITransactionRepo
    {
        IEnumerable<Transaction> GetTransactions();
    }
}
