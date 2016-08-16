using System;

namespace Destiny.Client.Models.Account.Summary
{
    public class Characterbase
    {
        public string membershipId { get; set; }
        public int membershipType { get; set; }
        public string characterId { get; set; }
        public DateTime dateLastPlayed { get; set; }
        public string minutesPlayedThisSession { get; set; }
        public string minutesPlayedTotal { get; set; }
        public int powerLevel { get; set; }
        public int raceHash { get; set; }
        public long genderHash { get; set; }
        public long classHash { get; set; }
        public int currentActivityHash { get; set; }
        public int lastCompletedStoryHash { get; set; }
        public Stats stats { get; set; }
        public Customization customization { get; set; }
        public int grimoireScore { get; set; }
        public Peerview peerView { get; set; }
        public int genderType { get; set; }
        public int classType { get; set; }
        public long buildStatGroupHash { get; set; }
    }
}
