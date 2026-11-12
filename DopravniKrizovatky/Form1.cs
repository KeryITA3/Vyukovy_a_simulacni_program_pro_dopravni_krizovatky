using DopravniKrizovatky.Modely;
using DopravniKrizovatky.Vykreslovani;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DopravniKrizovatky
{
    public partial class Form1 : Form
    {
        List<Krizovatka> seznam = new List<Krizovatka>();
        Krizovatka vybranaKrizovatka;
        VykreslovacKrizovatky vykreslovac = new VykreslovacKrizovatky();

        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnNapoveda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nahoře vyber křižovatku a vpravo přepni režim.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PravidloPrednosti p1 = new PravidloPrednosti("Hlavní a vedlejší silnice", "Auto 2 jede první, pak auto 1 a poslední auto 3 z vedlejší.");
            Krizovatka k1 = new Krizovatka("1. Čtyřramenná se značkami", "Ctyrramenna", p1);
            k1.Znacky.Add(new DopravniZnacka("Jih", "HlavniSilnice"));
            k1.Znacky.Add(new DopravniZnacka("Sever", "HlavniSilnice"));
            k1.Znacky.Add(new DopravniZnacka("Zapad", "DejPrednost"));
            k1.Znacky.Add(new DopravniZnacka("Vychod", "DejPrednost"));
            k1.Vozidla.Add(new Vozidlo(1, "Červené", Color.Red, "Jih", "Vlevo", 2));
            k1.Vozidla.Add(new Vozidlo(2, "Modré", Color.Blue, "Sever", "Rovne", 1));
            k1.Vozidla.Add(new Vozidlo(3, "Zelené", Color.Green, "Vychod", "Vpravo", 3));

            // 2. Křižovatka
            PravidloPrednosti p2 = new PravidloPrednosti("Přednost zprava", "Auto 2 z jihu má přednost zprava před autem 1 ze západu.");
            Krizovatka k2 = new Krizovatka("2. T-křižovatka", "TKrizovatka", p2);
            k2.Vozidla.Add(new Vozidlo(1, "Oranžové", Color.Orange, "Zapad", "Rovne", 2));
            k2.Vozidla.Add(new Vozidlo(2, "Modré", Color.Blue, "Jih", "Vlevo", 1));

            // 3. Křižovatka
            PravidloPrednosti p3 = new PravidloPrednosti("Semafory", "Auto 1 má zelenou a jede. Auto 2 stojí na červenou.");
            Krizovatka k3 = new Krizovatka("3. Křižovatka se semafory", "SeSemafory", p3);
            k3.Semafory.Add(new Semafor("Jih", "Zelena"));
            k3.Semafory.Add(new Semafor("Sever", "Zelena"));
            k3.Semafory.Add(new Semafor("Zapad", "Cervena"));
            k3.Semafory.Add(new Semafor("Vychod", "Cervena"));
            k3.Vozidla.Add(new Vozidlo(1, "Zelené", Color.Green, "Jih", "Rovne", 1));
            k3.Vozidla.Add(new Vozidlo(2, "Červené", Color.Red, "Zapad", "Vpravo", 2));

            // Uložení do seznamu
            seznam.Add(k1);
            seznam.Add(k2);
            seznam.Add(k3);

            // Přidání názvů do ComboBoxu
            cmbSablona.Items.Add(k1.NazevScenare);
            cmbSablona.Items.Add(k2.NazevScenare);
            cmbSablona.Items.Add(k3.NazevScenare);

            cmbSablona.SelectedIndex = 0;
        }

        private void cmbSablona_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cmbSablona.SelectedIndex;
            vybranaKrizovatka = seznam[index];

            lblInfo.Text = vybranaKrizovatka.Pravidlo.NazevPravidla + "\n\n" + vybranaKrizovatka.Pravidlo.Vysvetleni;
            platnoKrizovatky.Refresh();
        }

        private void chkSipky_CheckedChanged(object sender, EventArgs e)
        {
            vykreslovac.ZobrazovatSipky = chkSipky.Checked;
            platnoKrizovatky.Refresh();
        }

        private void platnoKrizovatky_Paint(object sender, PaintEventArgs e)
        {
            if (vybranaKrizovatka != null)
            {
                vykreslovac.Vykresli(e.Graphics, platnoKrizovatky.Width, platnoKrizovatky.Height, vybranaKrizovatka);
            }
        }

        private void platnoKrizovatky_Resize(object sender, EventArgs e)
        {
            platnoKrizovatky.Refresh();
        }
    }
}
