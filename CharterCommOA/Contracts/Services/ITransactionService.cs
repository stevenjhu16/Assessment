namespace AppCore.Contracts.Services
{
    public interface ITransactionService
    {
        decimal GetMonthlyPoints(int months, int customerId);
        decimal GetQuarterlyPoints(int customerId);
    }
}
