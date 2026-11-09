using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DopravniKrizovatky.Modely
{
    public class Semafor
    {
        public string Rame { get; set; } // "Sever", "Jih", "Zapad", "Vychod"
        public string Stav { get; set; } // "Cervena", "Zelena "

        public Semafor(string rame, string stav)
        {
            Rame = rame;
            Stav = stav;
        }
    }
}