using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum4
{
    class Program
    {
        static void Main(string[] args)
        {
            //MOOTORSÕIDUK
            //soiduki maksimumkiiruseks saab 60
            //kiirendame nullist 2 korda ja paneme seisma
            Mootorsoiduk soiduk = new Mootorsoiduk(60);
            soiduk.kiirenda();
            soiduk.kiirenda();
            //Console.WriteLine kutsub alati vaikimisi välja objekti küljest ToString meetodi, mis meil omaakorda tagastab hetkeseisu meetodi, sest me kirjutasime ToString meetodi üle
            Console.WriteLine(soiduk);
            soiduk.stop();
            Console.WriteLine(soiduk);

            //AUTO
            Auto uusAuto = new Auto();
            uusAuto.kiirenda();
            uusAuto.kiirenda();
            uusAuto.kiirenda();
            uusAuto.kiirenda();
            Console.WriteLine(uusAuto);
            uusAuto.avaUksed();
            Console.WriteLine(uusAuto);
            uusAuto.kiirenda();
            uusAuto.kiirenda();
            Console.WriteLine(uusAuto);
            uusAuto.sulgeUksed();
            uusAuto.kiirenda();
            Console.WriteLine(uusAuto);

            //VEOAUTO
            Veoauto uusVeoauto = new Veoauto();
            uusVeoauto.kiirenda();
            uusVeoauto.kiirenda();
            uusVeoauto.kiirenda();
            uusVeoauto.kiirenda();
            Console.WriteLine(uusVeoauto);
            uusVeoauto.hakkaKallutama();
            Console.WriteLine(uusVeoauto);
            uusVeoauto.kiirenda();
            Console.WriteLine(uusVeoauto);
        }
    }
}
