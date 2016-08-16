namespace Destiny.Client.Models.Account.Summary
{
    public class Character
    {
        public Characterbase characterBase { get; set; }
        public Levelprogression levelProgression { get; set; }
        public string emblemPath { get; set; }
        public string backgroundPath { get; set; }
        public long emblemHash { get; set; }
        public int characterLevel { get; set; }
        public int baseCharacterLevel { get; set; }
        public bool isPrestigeLevel { get; set; }
        public float percentToNextLevel { get; set; }
    }
}
