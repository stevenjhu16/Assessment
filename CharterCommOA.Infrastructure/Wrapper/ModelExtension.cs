using AppCore.Entities;
using AppCore.Models;


namespace Infrastructure.Wrapper
{
    public static class ModelExtension
    {
        public static TransactionExportModel ExportTransaction(this Transaction transaction)
        {
            return new TransactionExportModel
            {
                Transaction_Id = transaction.Transaction_Id,
                Customer_Id = transaction.Customer_Id,
                Transaction_Date = transaction.Transaction_Date,
                Transaction_Amount = transaction.Transaction_Amount
            };
        }
    }
}

