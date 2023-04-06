using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9
{
    public class RedCardArgs : EventArgs
    {
        public int min { get; set; }
        public string? plaNAme { get; set; }
        public RedCardArgs(int min, string? plaNAme)
        {
            this.min = min;
            this.plaNAme = plaNAme;
        }
    }
}
