using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9
{
    internal class Match
    {
        public FootballClub club1 { get; set; }
        public FootballClub club2 { get; set; }
        public int[] skore { get; set; } = new int[2];//1ячейка первый клуб 2я 2ой
        

        public Match(FootballClub club1, FootballClub club2)
        {
            this.club1 = club1;
            this.club2 = club2;
        }
        public void Simulate()
        {
            Random rnd = new Random();
            int counter = 10;
            for (int i = 0; i <= counter; i++)
            {
                Console.WriteLine(i);
                int tic = rnd.Next(1, 10);
                if (tic == 1)
                {
                    if (OnGoalScored != null)
                    {
                        int club = rnd.Next(1, 3);

                        if (club == 1)
                        {
                            skore[0]++;
                            int randomPlayer = rnd.Next(0, club1.players.Length);
                            OnGoalScored(new GoalArgs(i, club1.players[randomPlayer].name, club1.name));
                        }
                        else
                        {
                            skore[1]++;
                            int randomPlayer = rnd.Next(0, club2.players.Length);
                            OnGoalScored(new GoalArgs(i, club2.players[randomPlayer].name, club2.name));
                        }

                    }
                    Thread.Sleep(1000);
                }
                else if (tic == 2)
                {
                    if (OnYellowCardAchieved != null)
                    {
                        int randomPlayer = rnd.Next(0, club2.players.Length + club1.players.Length);
                        if(randomPlayer < club2.players.Length)
                        {
                            OnYellowCardAchieved(new YellowCardArgs(i, club2.players[randomPlayer].name));
                        }
                        else
                        {
                            OnYellowCardAchieved(new YellowCardArgs(i, club1.players[randomPlayer - club2.players.Length].name));
                        }
                        
                    }
                    Thread.Sleep(1000);
                }
                else if (tic == 3)
                {
                    if (OnRedCardAchieved != null)
                    {
                        int randomPlayer = rnd.Next(0, club2.players.Length + club1.players.Length);
                        if (randomPlayer < club2.players.Length)
                        {
                            OnRedCardAchieved(new RedCardArgs(i, club2.players[randomPlayer].name));
                        }
                        else
                        {
                            OnRedCardAchieved(new RedCardArgs(i, club1.players[randomPlayer - club2.players.Length].name));
                        }
                    }
                    Thread.Sleep(1000);
                }
                else
                {
                    Thread.Sleep(1000);
                }
            }
            Console.WriteLine("END");
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Final skore:\n{club1}:\nSkore: {skore[0]}\n" +
                $"{club2}:\nSkore: {skore[1]}");
        }
        protected virtual void OnGoalScored(GoalArgs e)
        {
            EventHandler<GoalArgs> handler = GoalScored;
            if (handler != null)
            {
                handler(this, e);
            }

        }
        protected virtual void OnYellowCardAchieved(YellowCardArgs e)
        {
            EventHandler<YellowCardArgs> handler = YellowCardAchieved;
            if (handler != null)
            {
                handler(this, e);
            }

        }
        protected virtual void OnRedCardAchieved(RedCardArgs e)
        {
            EventHandler<RedCardArgs> handler = RedCardAchieved;
            if (handler != null)
            {
                handler(this, e);
            }

        }
        public event EventHandler<GoalArgs> GoalScored;
        public event EventHandler<YellowCardArgs> YellowCardAchieved;
        public event EventHandler<RedCardArgs> RedCardAchieved;
    }
}
