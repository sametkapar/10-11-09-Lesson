using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Kalitim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Tanımlama (inheritance - kalıtım)

            //Üst sınıfa(Base Class) ait olan özelliklerin kalıtım yolu ile alt sınıflara aktarılması olayıdır.

            #endregion

            #region Personel Sınıfı

            //Personel prs = new Personel();
            //prs.isim = "Murtaza";
            //prs.soyisim = "Şuayipoğlu";
            //prs.PersonelNo = "123456789";
            //prs.Departman = "Muhasebe";

            //Console.WriteLine(prs.isim + " " + prs.soyisim + " " + prs.PersonelNo + " " + prs.Departman);
            #endregion

            #region Ogrenci Sınıfı

            //Ogrenci ogr = new Ogrenci();
            //ogr.isim = "Samet";
            //ogr.soyisim = "Kapar";
            //ogr.okulAdi = "Kütahya Lisesi";
            //ogr.okulNo = "6474";
            //ogr.sinif = "11/FenA";

            //Console.WriteLine($"{ogr.isim} {ogr.soyisim } {ogr.okulAdi} {ogr.sinif} {ogr.okulNo}");

            #endregion

            #region COnsole İle Form Uygulaması
            //KayitFormu frm = new KayitFormu();
            //frm.Text = "Merhaba dilenci değilim....";
            //frm.ShowDialog();
            #endregion

            #region Diziye Nesne Ekleyelim

            Personel p1 = new Personel();
            p1.isim = "Personel 1";
            p1.soyisim = "Soyisim";
            p1.PersonelNo = "123456789";
            p1.Departman = "Yazılım Geliştirme";

            Personel p2 = new Personel();
            p2.isim = "Personel 2";
            p2.soyisim = "Soyisim";
            p2.PersonelNo = "987654321";
            p2.Departman = "Halkla İlişkiler";

            //Personel[] personeller = new Personel[2];
            //personeller[0] = p1;
            //personeller[1] = p2;

            Ogrenci o1 = new   Ogrenci();
            o1.isim = "Öğrenci 1";
            o1.soyisim = "Soyisim";
            o1.okulNo = "1234";
            o1.okulAdi = "Atatürk Meslek Lisesi";
            o1.sinif = "11/A";
            
            Ogrenci o2= new   Ogrenci();
            o2.isim = "Öğrenci 2";
            o2.soyisim = "Soyisim";
            o2.okulNo = "1235";
            o2.okulAdi = "Atatürk Meslek Lisesi";
            o2.sinif = "11/A";

            //Ogrenci[] ogrenciler = new Ogrenci[2];
            //ogrenciler[0] = o1;
            //ogrenciler[1] = o2;

            //for (int i = 0; i < ogrenciler.Length; i++)
            //{
            //    Console.WriteLine(ogrenciler[i].isim + " " + ogrenciler[i].soyisim + " "+ ogrenciler[i].okulAdi + " "  + ogrenciler[i].okulNo + " " + ogrenciler[i].sinif);
            //}

            Insan[] insanlar = new Insan[4];

            insanlar[0] = p1;
            insanlar[1] = p2;
            insanlar[2] = o1;
            insanlar[3] = o2;


            for (int i = 0; i < insanlar.Length; i++)
            {

                Console.WriteLine(insanlar[i].isim + "  " + insanlar[i].soyisim);

            }

          
            #endregion



        }
    }
}
