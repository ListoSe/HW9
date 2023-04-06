using System;
using System.Diagnostics.Metrics;
using HW9;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Player[] players1 = new Player[3];
            for (int i = 0; i < 3; i++)
            {
                players1[i] = new Player(1, "andree", "east");
            }
            Player[] players2 = new Player[3];
            for (int i = 0; i < 3; i++)
            {
                players2[i] = new Player(1, "vlad", "west");
            }
            FootballClub first = new FootballClub("abdarvi", "USA", 1983, players1);
            FootballClub second = new FootballClub("asokas", "Germany", 1984, players2);
            Match match = new Match(first, second);

            match.GoalScored += Match_OnGoalScored;
            match.YellowCardAchieved += Match_OnYellowCardAchieved;
            match.RedCardAchieved += Match_OnRedCardAchieved;

            void Match_OnRedCardAchieved(object? sender, RedCardArgs e)
            {
                Console.WriteLine($"{e.min} RedCard\nPlayer {e.plaNAme}\"");
            }

            void Match_OnYellowCardAchieved(object? sender, YellowCardArgs e)
            {
                Console.WriteLine($"{e.min} YellowCard\nPlayer {e.plaNAme}");
            }

            void Match_OnGoalScored(object? sender, GoalArgs e)
            {

                Console.WriteLine($"{e.min} Goal\nPlayer {e.plaNAme}\nClub: {e.club}");
            }

            match.Simulate();
        }
    }
}

