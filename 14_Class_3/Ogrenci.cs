using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Class_3
{
    internal class Ogrenci
    {
        public int Numara;
        public string AdSoyad;
        public string Bolum;
        public string Tc;


        internal static void Kayit(List<Ogrenci> liste)
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

            liste.Add(ogr);
            Console.WriteLine("Öğrenci Ekleme Başarılı.");
        }

        internal static void Listele(List<Ogrenci> liste)
        {
            foreach (Ogrenci item in liste)
            {
                Console.WriteLine($"{item.Numara}-{item.AdSoyad}:{item.Bolum}-{item.Tc}");
            }
        }

        internal static void Sil(List<Ogrenci> liste)
        {
            Listele(liste);

            Console.WriteLine("Silinecek Öğrenci Numarası:");
            int numara = Convert.ToInt32(Console.ReadLine());

            foreach (Ogrenci item in liste)
            {
                if (item.Numara == numara)
                {
                    liste.Remove(item);
                    Console.WriteLine("Silme İşlemi Başarılı.");
                    break;
                }
            }

        }
        internal static void Guncelle(List<Ogrenci> liste)
        {
            Listele(liste);

            Console.WriteLine("Güncellenecek Öğrenci Numarası:");
            int numara = Convert.ToInt32(Console.ReadLine());

            foreach (Ogrenci item in liste)
            {
                if (item.Numara == numara)
                {
                    Console.WriteLine("Numarası:");
                    item.Numara = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Ad Soyad:");
                    item.AdSoyad = Console.ReadLine();

                    Console.WriteLine("Bölüm:");
                    item.Bolum = Console.ReadLine();

                    Console.WriteLine("TC:");
                    item.Tc = Console.ReadLine();

                    Console.WriteLine("Güncelleme İşlemi Başarılı.");
                    break;
                }
            }
        }
    }
}
