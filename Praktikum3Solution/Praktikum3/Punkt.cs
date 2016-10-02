using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum3
{
    public class Punkt
    {
        private int _x;
        private int _y;

        //konstruktor väärtustab private _muutujad
        public Punkt(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public double kaugusTeisestPunktist(Punkt p1)
        {
            double xVal = Math.Pow(p1._x - this._x, 2);
            double yVal = Math.Pow(p1._y - this._y, 2);
            double punktideVahelineKaugus = Math.Sqrt(xVal + yVal);
            Console.WriteLine(punktideVahelineKaugus);
            return punktideVahelineKaugus;
        }

        public double kaugusNullpunktist()
        {
            return kaugusTeisestPunktist(new Punkt(0, 0));
        }

        public string teataAndmed()
        {
            //defineerime, millisel kujul andmeid soovime näha
            string tulemus = string.Format("({0};{1})", _x, _y);
            Console.WriteLine(tulemus);

            return tulemus;
        }

        public bool kasOnAlguspunkt()
        {
            if(_x == 0 && _y == 0)
            {
                Console.WriteLine("Punkt on alguspunkt!");
                return true;
            }
            Console.WriteLine("Punkt ei ole alguspunkt!");
            return false;
        }
    }
}
