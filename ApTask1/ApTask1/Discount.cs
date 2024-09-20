namespace ContractsDatabaseMVC.Models
{
    public class Discount
    {
        public int DicountID { get; set; }
        public decimal UserID { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime StartDate { get; set; }

        // Relationship with ServiceProvider
        public int paymentIncomeID { get; set; }
        public PaymentIncome PaymentIncome { get; set; }
    }
}
