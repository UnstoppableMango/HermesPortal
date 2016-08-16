using System;

namespace Destiny.Client.Models.Account.Advisors
{
    public class RecordBook
    {
        public long bookHash { get; set; }
        public Records records { get; set; }
        public Progression progression { get; set; }
        public int completedCount { get; set; }
        public int redeemedCount { get; set; }
        public Spotlight[] spotlights { get; set; }
        public DateTime startDate { get; set; }
        public DateTime expirationDate { get; set; }
    }
}
