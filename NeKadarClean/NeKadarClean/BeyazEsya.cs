using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeKadarClean
{
    internal class BeyazEsya
    {

        public string Marka;
        public string Model;
        public double Fiyat;

        public BeyazEsya() { } //Default Constructor

        public BeyazEsya(string marka, string model, double fiyat)
        {
            Marka = marka;
            Model = model;
            Fiyat = fiyat;
        }

        public override string ToString()
        {
            return " Marka= " + Marka + " Model= " + Model + " Fiyat= " + Fiyat + " TL";
        }



    }
}
