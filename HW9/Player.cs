using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9
{
    internal class Player
    {
        public int number { get; set; }
        public string? name { get; set; }
        public string? pos { get; set; }

        public Player() { }
        public Player(int number, string? name, string? pos)
        {
            this.number = number;
            this.name = name;
            this.pos = pos;
        }
    }
}
