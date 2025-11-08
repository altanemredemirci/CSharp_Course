using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Class_1
{
    internal class Ogrenci
    {
        internal int Numara;
        internal string AdSoyad;
        internal string Bolum;
        internal string Tc;


        internal static void Kayit(List<Ogrenci> list)
        {
            Ogrenci ogr = new Ogrenci();
            Console.WriteLine("Numarası:");
            ogr.Numara = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ad Soyad:");
            ogr.AdSoyad = Console.ReadLine();

            Console.WriteLine("Bölüm:");
            ogr.Bolum = Console.ReadLine();

            Console.WriteLine("TC:");
            ogr.Tc = Console.ReadLine();

            list.Add(ogr);
        }


    }
}
