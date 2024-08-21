using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NeKadarClean
{
    internal class CamasirMakinesi : BeyazEsya
    {
        public string YikamaKapasitesi;
        public bool Kurutma;


        public CamasirMakinesi() { } //Default Constructor

        public CamasirMakinesi(string marka, string model, double fiyat, string yikamaKapasitesi, bool kurutma) 
            : base(marka, model, fiyat)

        {
            YikamaKapasitesi = yikamaKapasitesi;
            Kurutma = kurutma;
        }

        public override string ToString()
        {
            return base.Marka + base.Model + " Yıkama Kapasitesi = " + YikamaKapasitesi + " kurutma = " + (Kurutma ? "Evet" : "Hayır");
        }
    }
}
