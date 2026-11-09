using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DopravniKrizovatky.Modely
{
    public class PravidloPrednosti
    {
        public string NazevPravidla { get; set; }
        public string Vysvetleni { get; set; }

        public PravidloPrednosti(string nazev, string vysvetleni)
        {
            NazevPravidla = nazev;
            Vysvetleni = vysvetleni;
        }
    }
}
