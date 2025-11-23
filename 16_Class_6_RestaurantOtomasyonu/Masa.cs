using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Class_6_RestaurantOtomasyonu
{
    internal class Masa
    {
        public int No { get; set; }
        public bool Dolu = false;
        public double Hesap = 0;
        public int SiparisNo { get; set; }

        public static void MasaDurumu(List<Masa> liste)
        {
            Console.Clear();
            foreach (Masa item in liste)
            {
                Console.WriteLine(item.No+"- Dolu Mu:"+(item.Dolu==false ? "Boş" : "Dolu"));                
            }
        }

        public static Masa MasaDoldur(List<Masa> liste)
        {
            foreach (Masa item in liste)
            {
                if (!item.Dolu) //item.Dolu == false
                {
                    item.Dolu = true;
                    return item;
                }
            }
            return null;
        }

        public static int HesapOde(List<Siparis> siparisler,List<Masa> masalar,double kazanc)
        {
            Console.WriteLine("Masa No:");
            int masaNo = Convert.ToInt32(Console.ReadLine());

            foreach (Siparis item in siparisler)
            {
                if (item.MasaNo == masaNo)
                {
                    double hesap = item.Siparisler.Select(i => i.Fiyat).Sum();

                    Console.WriteLine("Hesap:"+hesap);
                    Console.WriteLine("Ödendi mi?(E/H)");
                    string cevap = Console.ReadLine().ToUpper();

                    if (cevap == "E")
                    {
                        kazanc += hesap;
                        siparisler.Remove(item);
                        Masa masa = masalar.FirstOrDefault(i => i.No == masaNo);
                        masa.Dolu = false;
                        return 1;
                    }
                    return -100;
                }
            }

            return -101;
        }


    }
}
