namespace Destiny.Client.Models.Account.Advisors
{
    public class Record
    {
        public int recordHash { get; set; }
        public Objective[] objectives { get; set; }
        public int status { get; set; }
    }
}
