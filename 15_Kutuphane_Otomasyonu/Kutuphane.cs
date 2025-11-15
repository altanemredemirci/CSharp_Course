using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Kutuphane_Otomasyonu
{
    class Kutuphane
    {
        public static List<Kitap> Kitaplar = new List<Kitap>();
        public static List<Uye> Uyeler = new List<Uye>();

        public static void OduncListele(List<Kitap> list)
        {
            foreach (Kitap item in list)
            {
                if (item.Durum == false)
                {
                    Console.WriteLine("ISBN:"+ item.ISBN);
                    Console.WriteLine("Kitap Adı:"+ item.Ad);
                    Console.WriteLine("Yazar:"+ item.Yazar);
                }
            }
        }

        public static void OduncAl(List<Kitap> list)
        {
            Console.WriteLine("ISBN:");
            string ISBN = Console.ReadLine();

            Kitap odunc = list.Where(i => i.ISBN == ISBN && i.Durum).FirstOrDefault();

            if (odunc != null)
            {
                Console.WriteLine("Üye No:");
                int no = Convert.ToInt32(Console.ReadLine());

                Uye uye = Uyeler.Where(i => i.UyeNo == no).FirstOrDefault();

                if (uye != null)
                {
                    odunc.Durum = false;
                    uye.AldigiKitaplar.Add(odunc);

                    Console.WriteLine("Kitap Ödünç Alındı.");
                }
                else
                {
                    Console.WriteLine("Üye kaydı bulunamadı.");
                }                
            }
            else
            {
                Console.WriteLine("Kitap Bulunamadı.");
            }
                
        }


    }
}
