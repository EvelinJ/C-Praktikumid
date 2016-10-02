using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum3
{
    public class Kompleksarv
    {
        private double _reaalOsa;
        private double _imaginaarOsa;

        public Kompleksarv(double reaalOsa, double imaginaarOsa)
        {
            this._reaalOsa = reaalOsa;
            this._imaginaarOsa = imaginaarOsa;
        }

        //tagastama peame kompleksarvu
        public Kompleksarv liida(Kompleksarv teine)
        {
            double reaalosa = this._reaalOsa + teine._reaalOsa;
            double imaginaarosa = this._imaginaarOsa + teine._imaginaarOsa;
            //liites kaks kompleksarvu saame uue kompleksarvu
            Kompleksarv tulemus = new Kompleksarv(reaalosa, imaginaarosa);
            Console.WriteLine(reaalosa + " " + imaginaarosa);

            return tulemus;
        }

        public Kompleksarv lahuta(Kompleksarv teine)
        {
            double reaalosa = this._reaalOsa - teine._reaalOsa;
            double imaginaarosa = this._imaginaarOsa - teine._imaginaarOsa;
            //lahutades kaks kompleksarvu saame uue kompleksarvu
            Kompleksarv tulemus = new Kompleksarv(reaalosa, imaginaarosa);
            Console.WriteLine(reaalosa + " " + imaginaarosa);

            return tulemus;
        }
    }
}
