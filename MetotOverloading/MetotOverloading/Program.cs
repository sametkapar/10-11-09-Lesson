using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Tanımlama

            //isimleri aynı ancak metot imzaları farklı olan metotlara overload metotlar denir
            //metot imzası = aldığı parametrelerin türü veya sayısı


            #endregion

            #region Kullanım

            //Matematik m = new Matematik();

            //m.Topla(45, 15);

            ////m.DoubleTopla(45.7, 56.8);
            //m.Topla(45.7, 56.8);

            //m.Topla(3, 4, 5);

            //m.Topla("45", "15");
            #endregion

            #region Kullanım 2
            Konferans kon = new Konferans();
            kon.KatilimciEkle("Samet","Kapar");
           
            
            Insan i = new Insan();
            i.isim = "Mevlüt";
            i.soyisim = "Koyuncu";

            kon.KatilimciEkle(i);
            #endregion

        }
    }
}
