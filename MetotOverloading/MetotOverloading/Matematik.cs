using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MetotOverloading
{
    internal class Matematik
    {
        public void Topla(int s1, int s2)
        {
            int toplam = s1 + s2;
            Console.WriteLine("Toplam = " + toplam);
        }
        //public void DoubleTopla(double s1, double s2)
        //{
        //    double toplam = s1 + s2;
        //    Console.WriteLine("Toplam = " + toplam);
        //}
        public void Topla(int s1, int s2, int s3)
        {
            int toplam = s1 + s2+ s3;
            Console.WriteLine("Toplam = " + toplam);
        }
        public void Topla(double s1, double s2)
        {
            double toplam = s1 + s2;
            Console.WriteLine("Toplam = " + toplam);
        }
        public void Topla(string s1, string s2)
        {
            double sayi1= Convert.ToDouble(s1);
            double sayi2= Convert.ToDouble(s2);
            double toplam = sayi1 + sayi2;

            Console.WriteLine("Toplam = " + toplam);
        }

        
    }
}
