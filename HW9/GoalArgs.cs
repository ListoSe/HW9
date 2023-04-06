using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9
{
    public class GoalArgs : EventArgs
    {
        public int min { get; set; }
        public string? plaNAme { get; set; }
        public string? club { get; set; }
        public GoalArgs(int min, string? plaNAme, string? club)
        {
            this.min = min;
            this.plaNAme = plaNAme;
            this.club = club;
        }
    }
}
