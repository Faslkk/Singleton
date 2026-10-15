using System;

namespace TournamentLibrary
{
    public class Match
    {
        public string HomeTeam { get; set; }
        public string AwayTeam { get; set; }
        public int HomeGoals { get; set; }
        public int AwayGoals { get; set; }
        public DateTime Date { get; set; }

        public Match(string homeTeam, string awayTeam, int homeGoals, int awayGoals, DateTime date)
        {
            HomeTeam = homeTeam;
            AwayTeam = awayTeam;
            HomeGoals = homeGoals;
            AwayGoals = awayGoals;
            Date = date;
        }

        public override string ToString()
        {
            return $"{Date:dd.MM.yyyy HH:mm}   {HomeTeam}  {HomeGoals} : {AwayGoals}  {AwayTeam}";
        }
    }
}
