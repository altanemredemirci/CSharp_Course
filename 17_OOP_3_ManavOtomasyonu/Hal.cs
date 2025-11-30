using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_OOP_3_ManavOtomasyonu
{
    class Hal
    {
        public static List<Urun> urunler = new List<Urun>()
            {
                new Urun(){Tur=Tur.Meyve, Ad="Elma",Stok=100,Fiyat=30},
                new Urun(){Tur=Tur.Meyve, Ad="Armut",Stok=100,Fiyat=40},
                new Urun(){Tur=Tur.Meyve, Ad="Kiraz",Stok=100,Fiyat=50},
                new Urun(){Tur=Tur.Meyve, Ad="Çilek",Stok=100,Fiyat=60},
                new Urun(){Tur=Tur.Meyve, Ad="Karpuz",Stok=100,Fiyat=20},
                new Urun(){Tur=Tur.Sebze, Ad="Biber",Stok=100,Fiyat=30},
                new Urun(){Tur=Tur.Sebze, Ad="Domates",Stok=100,Fiyat=40},
                new Urun(){Tur=Tur.Sebze, Ad="Patlıcan",Stok=100,Fiyat=50},
                new Urun(){Tur=Tur.Sebze, Ad="Kıvırcık",Stok=100,Fiyat=60},
                new Urun(){Tur=Tur.Sebze, Ad="Soğan",Stok=100,Fiyat=20}
            };
        public static int Bakiye = 0;


        public static void UrunleriListele(Tur tur)
        {
            foreach (Urun item in urunler.Where(i=> i.Tur==tur).ToList())
            {
                Console.WriteLine($"{item.Ad}:{item.Fiyat}₺");
            }
        }

        public static void AnaSecim() 
        {
            Console.WriteLine("*** HALE HOŞGELDİNİZ ***");
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

            Urun urun = Hal.urunler.Where(i => i.Ad.ToLower() == urunAd.ToLower()).FirstOrDefault();

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
                    if (Manav.Bakiye >= (kilo * urun.Fiyat))
                    {
                        int miktar = kilo * urun.Fiyat;
                        Manav.Bakiye -= miktar;
                        urun.Stok -= kilo;

                        Urun satinAlinan = Manav.urunler.FirstOrDefault(i => i.Ad == urun.Ad);

                        if (satinAlinan == null)
                        {
                            Manav.urunler.Add(new Urun()
                            {
                                Ad = urun.Ad,
                                Stok = kilo,
                                Fiyat = urun.Fiyat + 10,
                                Tur = urun.Tur
                            });
                        }
                        else
                        {
                            satinAlinan.Stok += kilo;
                        }


                        Bakiye += miktar;

                        Console.WriteLine($"{miktar}₺ ödenerek {kilo} {urun.Ad} alındı.");
                    }
                    else
                    {
                        Console.WriteLine("Yetersiz Bakiye!!");
                    }


                }
                else
                {
                    Console.WriteLine("Elimizde bulunan kilo:" + urun.Stok);
                }

               
            }
        }
    }
}
