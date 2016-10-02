using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum3
{
    //selle klassiga tehakse ristküliku objekte, klass kirjeldab, kuidas ristkülikut tehakse ja objekt on kindlate väärtustega ristkülik
    public class Ristkylik
    {
        private int _laius;
        private int _pikkus;
        private int _pindala;

        //konstruktor kannab alati sama nime, mis klass
        /// <summary>
        /// konstruktor teeb ristkülikut, nende andmetega, mis programis new ristkülikuga anname. Konstruktor väärtustab private _muutujad.
        /// </summary>
        /// <param name="laius"> see väärtus, mis new ristkülikus anname</param>
        /// <param name="pikkus">see väärtus, mis new ristkülikus anname</param>
        public Ristkylik(int laius, int pikkus)
        {
            _laius = laius;
            _pikkus = pikkus;
        }

        public int arvutaPindala()
        {
            int pindala = _laius * _pikkus;
            Console.WriteLine(pindala);
            return pindala;
        }

        public int arvutaYmbermoot()
        {
            int ymbermoot = 2 * (_laius + _pikkus);
            Console.WriteLine(ymbermoot);
            return ymbermoot;
        }

        public bool kasOnVordsed(Ristkylik r1)
        {
            if (this._pikkus == r1._pikkus && this._laius == r1._laius && this.arvutaPindala() == r1.arvutaPindala())
            {
                Console.WriteLine("Kaks ristkylikut on võrdsete külgedega ja võrdsete pindaladega!");
                return true;
            }
            Console.WriteLine("Kaks ristkylikut ei ole omavahel võrdsed!");
            return false;
            
        }

        public bool kasOnRuut()
        {
            if (_laius == _pikkus)
            {
                Console.WriteLine("Ristkülik on ruut!");
                return true;
            }
            Console.WriteLine("Ristkylik ei ole ruut!");
            return false;
        }

    }
}
