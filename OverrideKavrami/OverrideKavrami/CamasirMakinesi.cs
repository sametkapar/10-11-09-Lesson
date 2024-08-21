using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideKavrami
{
    internal class CamasirMakinesi:BeyazEsya
    {
        public string YikamaKapasitesi;
        public bool Kurutma;

        public override string Yazdir()
        {
            return base.Yazdir() + "\nYıkama Kapsitesi= " + YikamaKapasitesi + "\nKurutma=" + Kurutma;
        }

    }
}
