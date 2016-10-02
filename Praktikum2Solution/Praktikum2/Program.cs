using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum2
{
    class Program
    {
        static void Main(string[] args)
        {
            //switch-case
            Console.WriteLine("Sul on võimalik teha järgmiseid asju: \n1) sisestada kaks arvu ja see tagastatakse sulle" +
                "\n2) sisestada temperatuur Fahrenheitides ja teisendada see Kelvinitiesse" +
                "\n3) sisestada temperatuur kraadides ja teisendada see Fahrenheitidesse" +
                "\n4) kontrollida, kas oled täisealine" +
                "\n5) sisestada kolmnurga küljed ja kontrollida, kas tegemist on kolmnurgaga" +
                "\n6) kirjutada lause ja loendada selle sõnade arvu" +
                "\n7) kirjutada lause ja näha seda tagurpidi kirjutatuna");

            int valikuNumber = kasutajaSisestusToInt("Palun sisestage oma valiku number: ");

            switch (valikuNumber)
            {
                case 1:
                    //küsime arvu, kuni saame korrektse sisendi
                    int arv = kasutajaSisestusToInt("Sisestage arv:");
                    int arv2 = kasutajaSisestusToInt("Sisestage teine arv:");
                    break;
                case 2:
                    //temperatuur Fahrenheitist Kelvinisse
                    int tempFahrenheitides = kasutajaSisestusToInt("Sisestage temperatuur Fahrenheitides:");
                    double tempKelvinites = fahrenheitToKelvin(tempFahrenheitides);
                    Console.WriteLine("Temperatuur Kelvinites on: " + tempKelvinites);
                    break;
                case 3:
                    //temperatuur Celsiusest Fahrenheiti
                    int tempCelsiustes = kasutajaSisestusToInt("Sisestage temperatuur Kraadides:");
                    double tempFahrenheit = celsiusToFahrenheit(tempCelsiustes);
                    Console.WriteLine("Temperatuur Fahrenheitides on: " + tempFahrenheit);
                    break;
                case 4:
                    // küsime vanust ja ütleme, kas on täisealine või ei ole
                    int vanus = kasutajaSisestusToInt("Palun sisestage oma vanus:");
                    kasOnTaisealine(vanus);
                    break;
                case 5:
                    //küsime kolme külje pikkused ja ütleme, kas on kolmnurk või ei ole
                    int a = kasutajaSisestusToInt("Sisestage esimese külje pikkus:");
                    int b = kasutajaSisestusToInt("Sisestage teise külje pikkus:");
                    int c = kasutajaSisestusToInt("Sisestage kolmanda külje pikks:");
                    kasOnKolmnurk(a, b, c);
                    break;
                case 6:
                    //küsime kasutajalt lause, kuni saame korrektse sisendi
                    int sonedeArv = sonedeArvLauses("Palun sisestage lause, mille sõnade arvu soovite teada:");
                    break;
                case 7:
                    //küsime kasutajalt lause ja kirjutame selle tagurpidi
                    string lause = lauseTagurpidi("Palun sisestage lause, mida soovite näha tagurpidi kirjutatuna:");
                    break;
                default:
                    Console.WriteLine("Sellist valikut ei ole, palun vali nr 1, 2, 3, 4, 5, 6 või 7.");
                    break;
            }

            //küsime arvu, kuni saame korrektse sisendi
            //int arv = kasutajaSisestusToInt("Sisestage arv:");
            //int arv2 = kasutajaSisestusToInt("Sisestage teine arv:");

            //temperatuur Fahrenheitist Kelvinisse
            //int tempFahrenheitides = kasutajaSisestusToInt("Sisestage temperatuur Fahrenheitides:");
            //double tempKelvinites = fahrenheitToKelvin(tempFahrenheitides);
            //Console.WriteLine("Temperatuur Kelvinites on: " + tempKelvinites);

            //temperatuur Celsiusest Fahrenheiti
            //int tempCelsiustes = kasutajaSisestusToInt("Sisestage temperatuur Celsiustes:");
            //double tempFahrenheit = celsiusToFahrenheit(tempCelsiustes);
            //Console.WriteLine("Temperatuur Fahrenheitides on: " + tempFahrenheit);

            // küsime vanust ja ütleme, kas on täisealine või ei ole
            //int vanus = kasutajaSisestusToInt("Palun sisestage oma vanus:");
            //kasOnTaisealine(vanus);

            //küsime kolme külje pikkused ja ütleme, kas on kolmnurk või ei ole
            //int a = kasutajaSisestusToInt("Sisestage esimese külje pikkus:");
            //int b = kasutajaSisestusToInt("Sisestage teise külje pikkus:");
            //int c = kasutajaSisestusToInt("Sisestage kolmanda külje pikks:");
            //kasOnKolmnurk(a, b, c);

            //küsime kasutajalt lause, kuni saame korrektse sisendi
            //int sonedeArv = sonedeArvLauses("Palun sisestage lause, mille sõnade arvu soovite teada:");

            //küsime kasutajalt lause ja kirjutame selle tagurpidi
            //string lause = lauseTagurpidi("Palun sisestage lause, mida soovite näha tagurpidi kirjutatuna:");
        }

        //Luua meetod, mis küsib kasutaja käest arvu ning teeb seda seni kaua, kuni kasutaja on andnud korrektse sisendi
        //1. Mida peaks meetod tagastama?
        //Peaksime tagastama täisarvu
        //2. Mis võiks olla meetodi nimi?
        //kasutajaSisestusToInt
        //3. Kas meetodil on vaja sisendparameetreid, kui on siis milliseid?
        //Jah, tekst, mis kirjutatakse konsoolile.
        //sulgudes anname parameetrina kaasa stringi, mis on Main meetodis kirjas meetodi sees

        /// <summary>
        /// Küsib kasutajalt sisendit, kuni kasutaja kirjutab numbri
        /// </summary>
        /// <param name="kasutajaSisestus">Tekst, mis prinditakse ekraanile</param>
        /// <returns>täisarvu kasutaja sisestatud tekstist</returns>
        static int kasutajaSisestusToInt(string kasutajaSisestus)
        {
            Console.WriteLine(kasutajaSisestus);
            string tulemus = Console.ReadLine();

            int arv;
            if (int.TryParse(tulemus, out arv))
            {
                //ToDo: tuleks kasutaja sisestatud stringist int teha
                Console.WriteLine("Tegid valiku: " + arv);
                return arv;
            }
            else
            {
                return kasutajaSisestusToInt("Tegemist ei olnud arvuga! Palun sisesta number:");
            }
        }

        //Luua meetod fahrenheitToKelvin, mis võtab sisendiks temperatuuri fahrenheitides ja tagastab selle Kelvinites
        //1. Mida peaks meetod tagastama?
        //double, teisenduse Kelvinites
        //2. Mis võiks olla meetodi nimi?
        //fahrenheitToKelvin
        //3. Kas meetodil on vaja sisendparameetreid, kui on siis milliseid?
        //Jah, temperatuuri fahrenheitides, mis kirjutatakse konsoolile.

        /// <summary>
        /// Võtab sisendiks temperatuuri fahrenheitides ja tagastab selle Kelvinites
        /// </summary>
        /// <param name="tempFahrenheit">Temperatuur fahrenheitides</param>
        /// <returns>Temperatuur kelvinites</returns>
        static double fahrenheitToKelvin(int tempFahrenheit)
        {
            double tempKelvin = (tempFahrenheit + 459.67) * 5 / 9;
            return tempKelvin;
        }

        //Luua meetod celsiusToFahrenheit, mis võtab sisendiks temperatuuri kraadides ja tagastab fahrenheitides.
        //1. Mida peaks meetod tagastama?
        //double, teisenduse Fahrenheitides
        //2. Mis võiks olla meetodi nimi?
        //celsiusToFahrenheit
        //3. Kas meetodil on vaja sisendparameetreid, kui on siis milliseid?
        //Jah, temperatuuri celsiustes, mis kirjutatakse konsoolile.

        /// <summary>
        /// Võtab sisendiks temperatuuri kraadides ja tagastab fahrenheitides
        /// </summary>
        /// <param name="tempCelsius">Temperatuur kraadides</param>
        /// <returns>Temperatuur fahrenheitides</returns>
        static double celsiusToFahrenheit(int tempCelsius)
        {
            double tempFahren = tempCelsius * 9/5 + 32;
            return tempFahren;
        }

        //Luua meetod, mis tagastab vastavalt kasutaja vanusele, kas tegemist on täisealise kasutajaga või mitte
        //1. Mida peaks meetod tagastama?
        //peaksime tagastama booleani
        //2. Mis võiks olla meetodi nimi?
        //kasOnTaisealine
        //3. Kas meetodil on vaja sisendparameetreid, kui on siis milliseid?
        //Jah, kasutaja vanust.

            /// <summary>
            /// Kontrollib, kas kasutaja on täisealine
            /// </summary>
            /// <param name="vanus">Kasutaja vanus</param>
            /// <returns>On täisealine või ei ole täisealine</returns>
        static bool kasOnTaisealine (int vanus)
        {
            if (vanus > 17)
            {
                Console.WriteLine("Kasutaja on täisealine!");
                return true;
                
            }
            Console.WriteLine("Kasutaja ei ole täisealine!");
            return false;
        }

        //Luua meetod, mis saab sisendiks kolm arvu, mis on kolmnurga külgede pikkused, ja tagastab kas tegemist on kolmnurgaga
        //1. Mida peaks meetod tagastama?
        //peaksime tagastama booleani
        //2. Mis võiks olla meetodi nimi?
        //kasOnKolmnurk
        //3. Kas meetodil on vaja sisendparameetreid, kui on siis milliseid?
        //Jah, kolme külje pikkused.

            /// <summary>
            /// Kontrollib, kas kas on sisestatud kolmnurga andmed
            /// </summary>
            /// <param name="a">Esimese külje pikkus</param>
            /// <param name="b">Teise külje pikkus</param>
            /// <param name="c">Kolmanda külje pikkus</param>
            /// <returns>On kolnurk või ei ole kolmnurk</returns>
        static bool kasOnKolmnurk(int a, int b, int c)
        {
            if (a + b > c && c + b > a && a + c > b)
            {
                Console.WriteLine("On küll kolmnurk!");
                return true;
            }

            Console.WriteLine("See ei ole kolmnurk!");
            return false;
        }

        //Loo meetod, mis saab sisendiks lause ning tagastab lauses olevate sõnade arvu
        //1. Mida peaks meetod tagastama?
        //Peaksime tagastama täisarvu
        //2. Mis võiks olla meetodi nimi?
        //sonedeArvLauses
        //3. Kas meetodil on vaja sisendparameetreid, kui on siis milliseid?
        //Jah, tekst, mis kirjutatakse konsoolile.
        //sulgudes anname parameetrina kaasa stringi, mis on Main meetodis kirjas meetodi sees
        /// <summary>
        /// Küsib kasutajalt lause ja loendab selle sõnade arvu
        /// </summary>
        /// <param name="kasutajaLause">Tekst, mis prinditakse ekraanile, mille andime main meetodis meetodile kaasa</param>
        /// <returns>int, sõnade arv kasutaja lauses</returns>
        static int sonedeArvLauses(string kasutajaLause)
        {
            Console.WriteLine(kasutajaLause);
            string lauseKasutajalt = Console.ReadLine();
            string lause = lauseKasutajalt.Trim();

            //alustame ühest, sest esimest sõna peab ka lugema
            int sonedeArv = 1;
            for(int i = 0; i < lause.Length; i++)
            {
                if (char.IsWhiteSpace(lause[i]) && char.IsLetter(lause[i+1]))
                {
                    sonedeArv++;
                }
            }
            Console.WriteLine(sonedeArv);
            return sonedeArv;
        }

        //Loo meetod, mis saab sisendiks lause ning tagastab lauses olevate sõnade arvu
        //1. Mida peaks meetod tagastama?
        //Peaksime tagastama stringi
        //2. Mis võiks olla meetodi nimi?
        //lauseTagurpidi
        //3. Kas meetodil on vaja sisendparameetreid, kui on siis milliseid?
        //Jah, tekst, mis kirjutatakse konsoolile.
        //sulgudes anname parameetrina kaasa stringi, mis on Main meetodis kirjas meetodi sees
        /// <summary>
        /// Küsib kasutajalt lause ja kirjutab selle tagurpidi konsooli
        /// </summary>
        /// <param name="lauseKasutajalt">Tekst, mis prinditakse ekraanile, mille andime main meetodis meetodile kaasa</param>
        /// <returns>string, kasutaja lause tagurpidi</returns>
        static string lauseTagurpidi(string lauseKasutajalt)
        {
            Console.WriteLine(lauseKasutajalt);
            string lause = Console.ReadLine();
            string kasutajaLauseTagurpidi = "";

            for (int i = lause.Length-1; i >= 0; i--)
            {
                kasutajaLauseTagurpidi = kasutajaLauseTagurpidi + lause[i];
            }
            Console.WriteLine(kasutajaLauseTagurpidi);
            return kasutajaLauseTagurpidi;  
        }
    }
}
