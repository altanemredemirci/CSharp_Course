using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Class_6_RestaurantOtomasyonu
{
    internal class Siparis
    {
        public int MasaNo { get; set; }
        public List<Yemek> Siparisler { get; set; }


        public Siparis()
        {
            Siparisler = new List<Yemek>();
        }

        public static Yemek YemekSec(Menu secilenMenu)
        {
            foreach (Yemek item in secilenMenu.Yemekler)
            {
                Console.WriteLine(item.No + "-" + item.Ad + ":" + item.Fiyat);
            }

            Console.WriteLine("Yemek No:");
            int yemekNo = Convert.ToInt32(Console.ReadLine());

            return secilenMenu.Yemekler.FirstOrDefault(i => i.No == yemekNo);
        }
    }
}
