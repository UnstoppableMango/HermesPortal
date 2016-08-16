namespace Destiny.Client.Models.Account.Advisors
{
    public class Objective
    {
        public int objectiveHash { get; set; }
        public int destinationHash { get; set; }
        public int activityHash { get; set; }
        public int progress { get; set; }
        public bool hasProgress { get; set; }
        public bool isComplete { get; set; }
        public string displayValue { get; set; }
    }
}
