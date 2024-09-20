namespace ContractsDatabaseMVC.Models
{
    public class PaymentIncome
    {
        public int paymentIncomeID { get; set; }
        public string Name { get; set; }
        public int Percentage { get; set; }
        // Relationship with Customer and Booking
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
        public int BookingID { get; set; }
        public Booking Booking { get; set; }
    }
}
