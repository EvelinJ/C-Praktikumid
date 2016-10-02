using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum4
{
    public class Veoauto:Auto
    {
        private bool _kallutab = false;

        public Veoauto() : base(70)
        {

        }

        public void hakkaKallutama()
        {
            base.stop();
            _kallutab = true;
        }

        public override void kiirenda(int kiirus)
        {
            if (!_kallutab)
            {
                base.kiirenda(kiirus);
            }
        }

        public override string hetkeseis()
        {
            if (_kallutab)
            {
                return "Sõiduk kallutab";
            }
            return base.hetkeseis();
        }

        public override string ToString()
        {
            return hetkeseis();
        }
    }
}
