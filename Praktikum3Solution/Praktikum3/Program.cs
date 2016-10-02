using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum3
{
    class Program
    {
        static void Main(string[] args)
        {
            //RISTKYLIK
            // new Ristkylikuga kutsume Ristkyliku konstruktori välja
            Ristkylik esimeneRistkylik = new Ristkylik(2, 3);
            Ristkylik teineRistkylik = new Ristkylik(3, 3);

            int esimeseRiskylikuPindala = esimeneRistkylik.arvutaPindala();
            int teiseRistkylikuPindala = teineRistkylik.arvutaPindala();

            int esimeseRiskylikuYmbermoot = esimeneRistkylik.arvutaYmbermoot();
            int teiseRistkylikuYmbermoot = teineRistkylik.arvutaYmbermoot();

            //esimene on this ja teine on r1
            bool kasOnVordsed = esimeneRistkylik.kasOnVordsed(teineRistkylik);

            bool kasEsimeneRistkylikOnRuut = esimeneRistkylik.kasOnRuut();
            bool kasTeineRistkylikOnRuut = teineRistkylik.kasOnRuut();

            //PUNKT
            Punkt esimenePunkt = new Punkt(2, 3);
            Punkt teinePunkt = new Punkt(5, 3);

            double esimesePunktiKaugusNullpunktist = esimenePunkt.kaugusNullpunktist();
            double teisePunktiKaugusNullpunktist = teinePunkt.kaugusNullpunktist();

            string esimesePunktiAndmed = esimenePunkt.teataAndmed();
            string teisePunktiAndmed = teinePunkt.teataAndmed();

            double esimesePunktiKaugusTeisestPunktist = esimenePunkt.kaugusTeisestPunktist(teinePunkt);

            bool kasEsimenePunktOnAlguspunkt = esimenePunkt.kasOnAlguspunkt();
            bool kasTeinePunktOnAlguspunkt = teinePunkt.kasOnAlguspunkt();

            //KOMPLEKSARV
            Kompleksarv esimeneKompleksarv = new Kompleksarv(5.2, 2.8);
            Kompleksarv teineKompleksarv = new Kompleksarv(2.2, 3.8);

            Kompleksarv liida = esimeneKompleksarv.liida(teineKompleksarv);
            Kompleksarv lahuta = esimeneKompleksarv.lahuta(teineKompleksarv);
        }
    }
}
