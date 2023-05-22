using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Reflection.Metadata;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace Football
{
    class Game
    {
        public Game(Referee referee, Referee assistantRef1, Referee assistantRef2, Team team1, Team team2)
        {
            Referee = referee;
            AssistantRef1 = assistantRef1;
            AssistantRef2 = assistantRef2;
            Team1 = team1;
            Team2 = team2;
        }

        public Referee Referee { get; set; }
        public Referee AssistantRef1 { get; set; }
        public Referee AssistantRef2 { get; set; }
        public Team Team1 { get; set; }
        public Team Team2 { get; set; }

        public static void Goals(Team striker, Team defender)
        {
            int score1 = 0;
            int score2 = 0;
            Team first;
            Team second;
            for (int i = 0; i < 90; i++)
            {
                var roll = Random.Shared.Next(2);
                if (roll == 1)
                {
                    first = striker;
                    second = defender;

                }
                else if (roll == 2)
                {
                    first = defender;
                    second = striker;
                }

                var roll2 = Random.Shared.Next(100);
                if (roll2 < 10)
                {
                    Random randomPlayer = new Random();
                    int player = randomPlayer.Next(striker.football_players.Length);
                    Console.WriteLine($"{striker.football_players[player].Name} made {defender.Name_Team} cry in {i} minutes");
                    score1++;
                }
                else if (roll2 > 90)
                {
                    Random randomPlayer = new Random();
                    int player = randomPlayer.Next(0, defender.football_players.Length);
                    Console.WriteLine($"{defender.football_players[player].Name} made {striker.Name_Team}cry in {i} minute!");
                    score2++;
                }

            }
            Console.WriteLine("Match result: ");
            Console.WriteLine($"{striker.Name_Team} has {score1}");
            Console.WriteLine($"{defender.Name_Team} has {score2}");

            Winner(score1, score2, striker, defender);
        }

        public static void Winner(int point1, int point2, Team team1, Team team2)
        {

            if (point1 > point2)
            {
                Console.WriteLine($"The winner is: {team1.Name_Team}");
            }
            else if (point2 > point1)
            {
                Console.WriteLine($"The winner is: {team2.Name_Team}");
            }
            else if (point1 == point2)
            {
                Console.WriteLine("30 mins Overtime");
                int goals_team1 = 0;
                int goals_team2 = 0;
                Team first;
                Team second;
                for (int i = 0; i < 30; i++)
                {
                    var roll = Random.Shared.Next(2);
                    if (roll == 1)
                    {
                        first = team1;
                        second = team2;

                    }
                    else if (roll == 2)
                    {
                        first = team2;
                        second = team1;
                    }

                    var roll2 = Random.Shared.Next(100);
                    if (roll2 < 10)
                    {
                        Random randomPlayer = new Random();
                        int player = randomPlayer.Next(team1.football_players.Length);
                        Console.WriteLine($"{team1.football_players[player].Name} made {team2.Name_Team} cry in {i} minutes");
                        goals_team1++;
                    }
                    else if (roll2 > 90)
                    {
                        Random randomPlayer = new Random();
                        int player = randomPlayer.Next(0, team2.football_players.Length);
                        Console.WriteLine($"{team2.football_players[player].Name} made {team1.Name_Team}cry in {i} minutes");
                        goals_team2++;
                    }



                }
                Console.WriteLine("Match result: ");
                Console.WriteLine($"{team1.Name_Team} has {point1} in the maintime and scored {goals_team1} in the overtime");
                Console.WriteLine($"{team2.Name_Team} has {point2} in the maintime and scored {goals_team2} in the ovetime");
                OvertimeWinner(goals_team1, goals_team2, team1, team2);


            }
        }
        public static void OvertimeWinner(int goals1, int goals2,Team team1, Team team2)
        {
            if (goals1 > goals2)
            {
                Console.WriteLine($"The winner is: {team1.Name_Team}");
            }
            else if (goals2 > goals1)
            {
                Console.WriteLine($"The winner is: {team2.Name_Team}");
            }
            else if (goals1 == goals2) 
            {
                Console.WriteLine("it's a Draw");
            }
        }
    }
}

