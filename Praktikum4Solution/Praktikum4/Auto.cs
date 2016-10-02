using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum4
{
    public class Auto:Mootorsoiduk
    {
        private bool _uksedAvatud = false;

        //Pöördub baasklassi (Mootorsoiduk) konstruktori poole, mis oskab võtta sisendiks maxKiiruse 100. Iga kord kui teen uue auto, siis max kiirus on 100
        public Auto() : base(100)
        {

        }

        //Tegime uue konstruktori, sest meil ei olnud sellist konstruktorit, mis väärtustaks, meil on Auto klassis tühi konstruktor ja Veoautoklassist saame pöörduda ainult Auto klassi poole, mitte Mootorsõiduki klassi poole. 
        //Uue konstruktori poole on võimalik pöörduda alamklassidest (Veoauto) ja anname läbi selle max kiiruse ette.
        //see konstruktor ei ole avalik, seda ei saa väljaspool klassi kasutada, ei ole võimalik anda suuremat kiirust kui 100.
        protected Auto(int maxkiirus) : base(maxkiirus)
        {

        }

        public void avaUksed()
        {
            //Pöördume baasklassi poole ja kutsume välja meetodi stop
            base.stop();
            _uksedAvatud = true;
        }

        public void sulgeUksed()
        {
            _uksedAvatud = false;
        }

        //Alamklassis kirjutame üle baasklassi meetodi, et loogikat natuke muuta
        public override void kiirenda(int kiirus)
        {
            if (_uksedAvatud == false)
            {
                base.kiirenda(kiirus);
            }
            
        }

        //Ilma etteantud parameetrita kiirenda meetodit ülekirjutades pöördume alamklassi meetodi poole mitte baasklassi meetodi poole
        public override void kiirenda()
        {
            this.kiirenda(10);
        }

        public override string hetkeseis()
        {
            if (_uksedAvatud)
            {
                return "Sõiduk seisab ja uksed on avatud";
            }
            return base.hetkeseis();
        }

        public override string ToString()
        {
            return hetkeseis();
        }
    }
}
