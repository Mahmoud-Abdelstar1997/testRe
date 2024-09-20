namespace ContractsDatabaseMVC.Models
{
    public class ProviderContract
    {
        public int ContractID { get; set; }
        public string Details { get; set; }
        
        // Relationship with Provider
        public int ProviderID { get; set; }
        public Provider Provider { get; set; }
    }
}
