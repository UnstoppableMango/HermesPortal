namespace Destiny.Client.Models.Account.Summary
{
    public class SummaryData
    {
        public string membershipId { get; set; }
        public int membershipType { get; set; }
        public Character[] characters { get; set; }
        public string clanName { get; set; }
        public string clanTag { get; set; }
        public Inventory inventory { get; set; }
        public int grimoireScore { get; set; }
        public int versions { get; set; }
        public int accountState { get; set; }
    }
}
