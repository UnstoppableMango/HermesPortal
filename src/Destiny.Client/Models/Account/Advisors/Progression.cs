namespace Destiny.Client.Models.Account.Advisors
{
    public class Progression
    {
        public int dailyProgress { get; set; }
        public int weeklyProgress { get; set; }
        public int currentProgress { get; set; }
        public int level { get; set; }
        public int step { get; set; }
        public int progressToNextLevel { get; set; }
        public int nextLevelAt { get; set; }
        public long progressionHash { get; set; }
    }
}
