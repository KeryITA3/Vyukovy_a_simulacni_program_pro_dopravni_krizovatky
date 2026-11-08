using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace DopravniKrizovatky.Modely
{
    public class DopravniZnacka
    {
        public string Rame { get; set; } // "Sever", "Jih", "Zapad", "Vychod"
        public string Typ { get; set; }  // "HlavniSilnice", "DejPrednost", "Stopka"

        public DopravniZnacka(string rame, string typ)
        {
            Rame = rame;
            Typ = typ;
        }
    }
}