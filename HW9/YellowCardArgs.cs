using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9
{
    public class YellowCardArgs:EventArgs
    {
        public int min { get; set; }
        public string? plaNAme { get; set; }
        public YellowCardArgs(int min, string? plaNAme)
        {
            this.min = min;
            this.plaNAme = plaNAme;
        }
    }
}
