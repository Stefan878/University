using System.Reflection.PortableExecutable;

namespace Football
{
    class Team
    {
        public Team(Coach coach, Football_player[] football_players, string name_Team)
        {
            this.coach = coach;
            this.football_players = football_players;
            Name_Team = name_Team;
        }

        public string Name_Team { get; set; }
        public Coach coach { get; set; }
        public Football_player[] football_players { get; set; }

        public int CalcAverageAge(Football_player[] players)
        {
            int avgAge = 0;
            for (int i = 0; i < football_players.Length; i++) 
            {
                avgAge = avgAge + players[i].Age;
            }
            return avgAge / football_players.Length;     
        }
    }
}
