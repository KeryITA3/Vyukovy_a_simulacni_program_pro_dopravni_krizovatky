using DopravniKrizovatky.Modely;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DopravniKrizovatky.Vykreslovani
{
    public class VykreslovacKrizovatky
    {
        public bool ZobrazovatSipky { get; set; } = true;

        public void Vykresli(Graphics g, int sirkaPlatna, int vyskaPlatna, Krizovatka krizovatka)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(Color.FromArgb(60, 140, 60));

            int stredX = sirkaPlatna / 2;
            int stredY = vyskaPlatna / 2;
            int mensiRozmer = Math.Min(sirkaPlatna, vyskaPlatna);
            int sirkaSilnice = mensiRozmer / 4;
            int pulkaSilnice = sirkaSilnice / 2;

            VykresliSilnice(g, sirkaPlatna, vyskaPlatna, stredX, stredY, sirkaSilnice, pulkaSilnice, krizovatka.Sablona);

            foreach (DopravniZnacka znacka in krizovatka.Znacky)
            {
                VykresliZnacku(g, stredX, stredY, pulkaSilnice, znacka);
            }

            foreach (Semafor semafor in krizovatka.Semafory)
            {
                VykresliSemafor(g, stredX, stredY, pulkaSilnice, semafor);
            }

            foreach (Vozidlo auto in krizovatka.Vozidla)
            {
                VykresliVozidlo(g, stredX, stredY, pulkaSilnice, auto);
            }
        }

        private void VykresliSilnice(Graphics g, int sirka, int vyska, int stredX, int stredY, int sirkaSilnice, int pulkaSilnice, string sablona)
        {
            Brush barvaAsfaltu = new SolidBrush(Color.FromArgb(70, 70, 70));
            Pen prerusovanaCara = new Pen(Color.White, 2);
            prerusovanaCara.DashStyle = DashStyle.Dash;

            g.FillRectangle(barvaAsfaltu, 0, stredY - pulkaSilnice, sirka, sirkaSilnice);

            if (sablona == "TKrizovatka")
            {
                g.FillRectangle(barvaAsfaltu, stredX - pulkaSilnice, stredY - pulkaSilnice, sirkaSilnice, vyska - (stredY - pulkaSilnice));
            }
            else
            {
                g.FillRectangle(barvaAsfaltu, stredX - pulkaSilnice, 0, sirkaSilnice, vyska);
            }

            g.DrawLine(prerusovanaCara, 0, stredY, stredX - pulkaSilnice, stredY);
            g.DrawLine(prerusovanaCara, stredX + pulkaSilnice, stredY, sirka, stredY);
            g.DrawLine(prerusovanaCara, stredX, stredY + pulkaSilnice, stredX, vyska);

            if (sablona != "TKrizovatka")
            {
                g.DrawLine(prerusovanaCara, stredX, 0, stredX, stredY - pulkaSilnice);
            }
        }

        private void VykresliZnacku(Graphics g, int stredX, int stredY, int pulkaSilnice, DopravniZnacka znacka)
        {
            int odsazeni = pulkaSilnice + 25;
            int x = stredX;
            int y = stredY;

            if (znacka.Rame == "Jih") { x = stredX + odsazeni; y = stredY + odsazeni; }
            else if (znacka.Rame == "Sever") { x = stredX - odsazeni; y = stredY - odsazeni; }
            else if (znacka.Rame == "Zapad") { x = stredX - odsazeni; y = stredY + odsazeni; }
            else if (znacka.Rame == "Vychod") { x = stredX + odsazeni; y = stredY - odsazeni; }

            if (znacka.Typ == "HlavniSilnice")
            {
                Point[] body = new Point[]
                {
                    new Point(x, y - 16),
                    new Point(x + 16, y),
                    new Point(x, y + 16),
                    new Point(x - 16, y)
                };
                g.FillPolygon(Brushes.Gold, body);
                g.DrawPolygon(new Pen(Color.White, 3), body);
                g.DrawPolygon(Pens.Black, body);
            }
            else if (znacka.Typ == "DejPrednost")
            {
                Point[] body = new Point[]
                {
                    new Point(x - 16, y - 12),
                    new Point(x + 16, y - 12),
                    new Point(x, y + 16)
                };
                g.FillPolygon(Brushes.White, body);
                g.DrawPolygon(new Pen(Color.Red, 3), body);
            }
        }

        private void VykresliSemafor(Graphics g, int stredX, int stredY, int pulkaSilnice, Semafor semafor)
        {
            int odsazeni = pulkaSilnice + 30;
            int x = stredX;
            int y = stredY;

            if (semafor.Rame == "Jih") { x = stredX + odsazeni; y = stredY + odsazeni; }
            else if (semafor.Rame == "Sever") { x = stredX - odsazeni; y = stredY - odsazeni; }
            else if (semafor.Rame == "Zapad") { x = stredX - odsazeni; y = stredY + odsazeni; }
            else if (semafor.Rame == "Vychod") { x = stredX + odsazeni; y = stredY - odsazeni; }

            g.FillRectangle(Brushes.Black, x - 10, y - 22, 20, 44);
            g.DrawRectangle(Pens.White, x - 10, y - 22, 20, 44);

            Brush cerveneSvetlo = (semafor.Stav == "Cervena") ? Brushes.Red : Brushes.DarkRed;
            Brush zeleneSvetlo = (semafor.Stav == "Zelena") ? Brushes.Lime : Brushes.DarkGreen;

            g.FillEllipse(cerveneSvetlo, x - 7, y - 18, 14, 14);
            g.FillEllipse(zeleneSvetlo, x - 7, y + 4, 14, 14);
        }

        private void VykresliVozidlo(Graphics g, int stredX, int stredY, int pulkaSilnice, Vozidlo auto)
        {
            int stredPruhu = pulkaSilnice / 2;
            int vzdalenostOdKrizovatky = pulkaSilnice + 45;

            int autoX = stredX;
            int autoY = stredY;
            int sirkaAuta = 30;
            int delkaAuta = 50;

            if (auto.OdkudJede == "Jih")
            {
                autoX = stredX + stredPruhu - (sirkaAuta / 2);
                autoY = stredY + vzdalenostOdKrizovatky - (delkaAuta / 2);
            }
            else if (auto.OdkudJede == "Sever")
            {
                autoX = stredX - stredPruhu - (sirkaAuta / 2);
                autoY = stredY - vzdalenostOdKrizovatky - (delkaAuta / 2);
            }
            else if (auto.OdkudJede == "Zapad")
            {
                sirkaAuta = 50;
                delkaAuta = 30;
                autoX = stredX - vzdalenostOdKrizovatky - (sirkaAuta / 2);
                autoY = stredY + stredPruhu - (delkaAuta / 2);
            }
            else if (auto.OdkudJede == "Vychod")
            {
                sirkaAuta = 50;
                delkaAuta = 30;
                autoX = stredX + vzdalenostOdKrizovatky - (sirkaAuta / 2);
                autoY = stredY - stredPruhu - (delkaAuta / 2);
            }

            Rectangle obdelnikAuta = new Rectangle(autoX, autoY, sirkaAuta, delkaAuta);
            auto.PoziceNaPlatne = obdelnikAuta;

            Brush stetecAuta = new SolidBrush(auto.Barva);
            g.FillRectangle(stetecAuta, obdelnikAuta);
            g.DrawRectangle(new Pen(Color.Black, 2), obdelnikAuta);

            Font pismo = new Font("Arial", 11, FontStyle.Bold);
            g.DrawString(auto.Id.ToString(), pismo, Brushes.White, autoX + (sirkaAuta / 2) - 7, autoY + (delkaAuta / 2) - 8);

            if (ZobrazovatSipky)
            {
                VykresliSipku(g, auto, autoX + (sirkaAuta / 2), autoY + (delkaAuta / 2));
            }
        }

        private void VykresliSipku(Graphics g, Vozidlo auto, int stredAutaX, int stredAutaY)
        {
            Pen peroSipky = new Pen(Color.Yellow, 3);
            peroSipky.CustomEndCap = new AdjustableArrowCap(4, 4);

            int x1 = stredAutaX, y1 = stredAutaY;
            int x2 = stredAutaX, y2 = stredAutaY;
            int x3 = stredAutaX, y3 = stredAutaY;

            if (auto.OdkudJede == "Jih")
            {
                y1 = stredAutaY - 30;
                y2 = stredAutaY - 55;
                if (auto.KamOdbocuje == "Rovne") { x3 = x2; y3 = y2; }
                else if (auto.KamOdbocuje == "Vpravo") { x3 = x2 + 20; y3 = y2; }
                else if (auto.KamOdbocuje == "Vlevo") { x3 = x2 - 20; y3 = y2; }
            }
            else if (auto.OdkudJede == "Sever")
            {
                y1 = stredAutaY + 30;
                y2 = stredAutaY + 55;
                if (auto.KamOdbocuje == "Rovne") { x3 = x2; y3 = y2; }
                else if (auto.KamOdbocuje == "Vpravo") { x3 = x2 - 20; y3 = y2; }
                else if (auto.KamOdbocuje == "Vlevo") { x3 = x2 + 20; y3 = y2; }
            }
            else if (auto.OdkudJede == "Zapad")
            {
                x1 = stredAutaX + 30;
                x2 = stredAutaX + 55;
                if (auto.KamOdbocuje == "Rovne") { x3 = x2; y3 = y2; }
                else if (auto.KamOdbocuje == "Vpravo") { x3 = x2; y3 = y2 + 20; }
                else if (auto.KamOdbocuje == "Vlevo") { x3 = x2; y3 = y2 - 20; }
            }
            else if (auto.OdkudJede == "Vychod")
            {
                x1 = stredAutaX - 30;
                x2 = stredAutaX - 55;
                if (auto.KamOdbocuje == "Rovne") { x3 = x2; y3 = y2; }
                else if (auto.KamOdbocuje == "Vpravo") { x3 = x2; y3 = y2 - 20; }
                else if (auto.KamOdbocuje == "Vlevo") { x3 = x2; y3 = y2 + 20; }
            }

            Point[] bodySipky = new Point[] { new Point(x1, y1), new Point(x2, y2), new Point(x3, y3) };
            g.DrawLines(peroSipky, bodySipky);
        }
    }
}
