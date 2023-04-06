using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9
{
    internal class FootballClub
    {
        public string? name { get; set; }
        public string? country { get; set; }
        public int year { get; set; }
        public Player[] players { get; set; }

        public FootballClub(string name, string country, int year, Player[] players)
        {
            this.name = name;
            this.country = country;
            this.year = year;
            this.players = players;
        }
        public override string ToString()
        {
            return $"Club name: {name}\n" +
                $"Club country: {country}\n" +
                $"Club year: {year}";
        }
    }
}
