namespace AppCore.Entities
{
    public class Customer
    {
        public int Customer_Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public List<Transaction> Transaction_History { get; set; }
    }
}

