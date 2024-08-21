using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideKavrami
{
    internal class BulasikMakinesi:BeyazEsya
    {
        public double icHacim;
        public int programSayisi;

        public override string Yazdir()
        {
            return base.Yazdir() + "\nİç Hacim= " + icHacim + "\nProgram Sayısı = " + programSayisi;
        }
    }
}
