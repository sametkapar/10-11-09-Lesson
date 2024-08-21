using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotOverloading
{
    internal class Konferans
    {
        public Insan[] katilimcilar;
        public Konferans()
        {
            katilimcilar = new Insan[0];
        }

        public void KatilimciEkle(Insan p_ins)
        {
            Insan[] tempt = new Insan[katilimcilar.Length+1];
            Array.Copy(katilimcilar, tempt, katilimcilar.Length);
            tempt[tempt.Length-1] = p_ins;
            katilimcilar = tempt;
        }
        public void KatilimciEkle(string isim, string soyisim)
        {
            Insan insan1 = new Insan();
            insan1.isim = isim;
            insan1.soyisim = soyisim;

            this.KatilimciEkle(insan1);

        }

    }
}
