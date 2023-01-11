namespace AppCore.Entities
{
    public class Transaction
    {
        public int Transaction_Id { get; set; }
        public int Customer_Id { get; set; }
        public Customer Customer_Obj { get; set; }
        public DateTime Transaction_Date { get; set; }
        public decimal Transaction_Amount { get; set; }
    }
}


