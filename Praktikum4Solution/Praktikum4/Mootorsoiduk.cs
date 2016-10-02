using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum4
{
    public class Mootorsoiduk
    {
        //määrame väljadele vaikeväärtused
        private int _kiirus = 0;
        private int _maxKiirus = 20;

        /// <summary>
        /// Läbi kuonstruktori määratakse mootorsõidukile maksimumkiirus
        /// </summary>
        /// <param name="maxKiirus">Mootorsõiduki maksimumkiirus</param>
        public Mootorsoiduk(int maxKiirus)
        {
            _maxKiirus = maxKiirus;
        }

        //kasutame void meetodid, sest objekti enda väärtust on vaja muuta (int-i ei kasuta, sest me ei pea midagi tagastama). Virtual baasklassis tähendab seda, et alamklassis on võimalik meetodit üle kirjutada.
        public virtual void kiirenda()
        {
            kiirenda(10);
            //_kiirus = _kiirus + 10;
            //if (_kiirus > _maxKiirus)
            //{
            //    _kiirus = _maxKiirus;
            //}
        }

        public virtual void kiirenda(int kiirus)
        {
            _kiirus = _kiirus + kiirus;
            if (_kiirus > _maxKiirus)
            {
                _kiirus = _maxKiirus;
            }
        }

        public void stop()
        {
            _kiirus = 0;
        }

        //meetodiga tagastame stringi
        public virtual string hetkeseis()
        {
            if (_kiirus == 0)
            {
                return "Sõiduk seisab";
            }
            return string.Format("Sõiduk sõidab {0} km/h", _kiirus);
        }

        //Meetod kutsub välja hetkeseisu meetodit
        public override string ToString()
        {
            return hetkeseis();
        }
    }
}
