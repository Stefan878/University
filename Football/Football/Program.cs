using Football;

Coach Team1Coach = new Coach("TRENER1", 34);
Football_player[] footballer_team1 = new Football_player[11];
for (int i = 0; i < footballer_team1.Length; i++)
{
    footballer_team1[1] = new Football_player("Messi", 20, 8, 180);
    footballer_team1[2] = new Football_player("Rooney", 42, 9, 192);
    footballer_team1[3] = new Football_player("Figo", 15, 5, 193);
    footballer_team1[4] = new Football_player("Stoichkov", 34, 23, 194);
    footballer_team1[5] = new Football_player("Berbatov", 21, 54, 195);
    footballer_team1[6] = new Football_player("Kevin De Bruyne", 42, 9, 196);
    footballer_team1[7] = new Football_player("David Villa", 45, 9, 197);
    footballer_team1[8] = new Football_player("Cross", 44, 9, 198);
    footballer_team1[9] = new Football_player("Pesho", 23, 9, 177);
    footballer_team1[10] = new Football_player("Dancho", 42, 9, 169);
    footballer_team1[0] = new Football_player("Gosho", 19, 9, 163);
}
Team team1 = new Team(Team1Coach, footballer_team1, "Nepobedimite");

Coach Team2Coach = new Coach("TRENER2", 43);
Football_player[] footballer_team2 = new Football_player[11];
for (int i = 0; i < footballer_team2.Length; i++)
{
    footballer_team2[1] = new Football_player("Gancho", 20, 8, 169);
    footballer_team2[2] = new Football_player("Ronaldo", 19, 9, 160);
    footballer_team2[3] = new Football_player("Ivan", 42, 9, 180);
    footballer_team2[4] = new Football_player("Georgi", 32, 9, 195);
    footballer_team2[5] = new Football_player("Stefan", 22, 9, 195);
    footballer_team2[6] = new Football_player("Levandowski", 42, 9, 195);
    footballer_team2[7] = new Football_player("Tonkata", 23, 9, 195);
    footballer_team2[8] = new Football_player("Nikolai", 45, 9, 195);
    footballer_team2[9] = new Football_player("Toshko", 25, 9, 195);
    footballer_team2[10] = new Football_player("Pogba", 33, 9, 195);
    footballer_team2[0] = new Football_player("Despodov", 18, 9, 195);

}
Team team2 = new Team(Team2Coach, footballer_team2, "Bezstrashnite");

Game.Goals(team1, team2);
