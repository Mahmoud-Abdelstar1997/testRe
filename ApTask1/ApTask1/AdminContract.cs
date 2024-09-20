namespace ContractsDatabaseMVC.Models
{
    public class AdminContract
    {
        public int ContractID { get; set; }
        

        // Relationship with Admin
        public int UserID { get; set; }
        public User User { get; set; }
      
    }
}
