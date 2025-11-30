using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_OOP_3_ManavOtomasyonu
{
    class Manav
    {
        public static List<Urun> urunler = new List<Urun>();

        public static int Bakiye = 10000;

        public static void UrunleriListele(Tur tur)
        {
            foreach (Urun item in urunler.Where(i => i.Tur == tur).ToList())
            {
                Console.WriteLine($"{item.Ad}:{item.Fiyat}₺");
            }
        }

        public static void AnaSecim()
        {
            Console.WriteLine("*** MANAVA HOŞGELDİNİZ ***");
            Console.WriteLine("Meyve Mi? Sebze Mi? (M/S) Çıkış Q");
            string secim = Console.ReadLine().ToUpper();

            if (secim == "M")
            {
                UrunleriListele(Tur.Meyve);

            }
            else if (secim == "S")
            {
                UrunleriListele(Tur.Sebze);
            }
            else if (secim == "Q")
            {
                return;
            }
            else
            {
                Console.WriteLine("Hatalı Seçim!!");
                AnaSecim();
            }
        }
        public static void UrunSatis()
        {
            Console.WriteLine("İstediğiniz Ürün Adı:");
            string urunAd = Console.ReadLine();

            Urun urun = Manav.urunler.Where(i => i.Ad.ToLower() == urunAd.ToLower()).FirstOrDefault();

            if (urun == null)
            {
                Console.WriteLine("Hatalı Ürün Seçimi!!");
            }
            else
            {
                Console.WriteLine("Kaç Kilo:");
                int kilo = Convert.ToInt32(Console.ReadLine());

                if (urun.Stok >= kilo)
                {

                    int miktar = kilo * urun.Fiyat;
                    Bakiye += miktar;
                    urun.Stok -= kilo;

                    Urun satinAlinan = Musteri.urunler.FirstOrDefault(i => i.Ad == urun.Ad);

                    if (satinAlinan == null)
                    {
                        Musteri.urunler.Add(new Urun()
                        {
                            Ad = urun.Ad,
                            Stok = kilo,
                            Fiyat = urun.Fiyat,
                            Tur = urun.Tur
                        });
                    }
                    else
                    {
                        satinAlinan.Stok += kilo;
                    }

                    Console.WriteLine($"{miktar}₺ ödenerek {kilo} {urun.Ad} alındı.");

                }
                else
                {
                    Console.WriteLine("Elimizde bulunan kilo:" + urun.Stok);
                }


            }
        }
    }
}
