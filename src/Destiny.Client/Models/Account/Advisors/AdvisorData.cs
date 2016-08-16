using System;

namespace Destiny.Client.Models.Account.Advisors
{
    public class AdvisorsData
    {
        public DateTime nextWeeklyReset { get; set; }
        public DateTime nextDailyReset { get; set; }
        public DateTime previousWeeklyReset { get; set; }
        public DateTime previousDailyReset { get; set; }
        public Recordbooks recordBooks { get; set; }
    }
}
