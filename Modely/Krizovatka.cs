using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DopravniKrizovatky.Modely
{
    public class Krizovatka
    {
        public string NazevScenare { get; set; }
        public string Sablona { get; set; } // "Ctyrramenna", "TKrizovatka", "SeSemafory" 
        public List<Vozidlo> Vozidla { get; set; }
        public List<DopravniZnacka> Znacky { get; set; }
        public List<Semafor> Semafory { get; set; }
        public PravidloPrednosti Pravidlo { get; set; }

        public Krizovatka(string nazev, string sablona, PravidloPrednosti pravidlo)
        {
            NazevScenare = nazev;
            Sablona = sablona;
            Pravidlo = pravidlo;
            Vozidla = new List<Vozidlo>();
            Znacky = new List<DopravniZnacka>();
            Semafory = new List<Semafor>();
        }
    }
}
