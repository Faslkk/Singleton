namespace TournamentLibrary
{
    public class Team
    {
        public string Name { get; set; }
        public int Played { get; set; }
        public int Wins { get; set; }
        public int Draws { get; set; }
        public int Losses { get; set; }
        public int GoalsFor { get; set; }
        public int GoalsAgainst { get; set; }

        public int GoalDifference
        {
            get { return GoalsFor - GoalsAgainst; }
        }

        public int Points
        {
            get { return Wins * 3 + Draws; }
        }

        public Team(string name)
        {
            Name = name;
        }
    }
}
