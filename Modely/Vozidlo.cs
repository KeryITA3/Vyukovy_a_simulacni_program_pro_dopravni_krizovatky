using System;
using System.Drawing;

namespace DopravniKrizovatky.Modely
{
    public class Vozidlo
    {
        public int Id { get; set; }
        public string Nazev { get; set; }
        public Color Barva { get; set; }
        public string OdkudJede { get; set; }   // "Sever", "Jih", "Zapad", "Vychod"
        public string KamOdbocuje { get; set; } // "Rovne", "Vlevo", "Vpravo" 
        public int PoradiPrujezdu { get; set; }

        public Rectangle PoziceNaPlatne { get; set; }

        public Vozidlo(int id, string nazev, Color barva, string odkud, string kam, int poradi)
        {
            Id = id;
            Nazev = nazev;
            Barva = barva;
            OdkudJede = odkud;
            KamOdbocuje = kam;
            PoradiPrujezdu = poradi;
        }
    }
}