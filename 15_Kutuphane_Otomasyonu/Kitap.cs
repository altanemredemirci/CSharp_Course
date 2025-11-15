using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Kutuphane_Otomasyonu
{
    class Kitap
    {
        public string ISBN;
        public string Ad;
        public string Yazar;
        public bool Durum;

        public static void Ekle(List<Kitap> list)
        {
            Kitap kitap = new Kitap();
            Console.WriteLine("ISBN:");
            kitap.ISBN = Console.ReadLine();

            Console.WriteLine("Ad:");
            kitap.Ad = Console.ReadLine();

            Console.WriteLine("Yazar:");
            kitap.Yazar = Console.ReadLine();

            kitap.Durum = true;

            list.Add(kitap);
        }

        public static bool Sil(List<Kitap> list)
        {
            Console.WriteLine("ISBN:");
            string ISBN = Console.ReadLine();

            //foreach (Kitap item in list)
            //{
            //    if (item.ISBN == ISBN && item.Durum)
            //    {
            //        list.Remove(item);

            //        return true;
            //    }
            //}

            //return false;

            Kitap silinen = list.Where(i => i.ISBN == ISBN && i.Durum).FirstOrDefault();

            if (silinen != null)
            {
                list.Remove(silinen);
                return true;
            }
            return false;
        }

        public static void KitapAra(List<Kitap> list)
        {
            Console.WriteLine("ISBN:");
            string ISBN = Console.ReadLine();

            //foreach (Kitap item in list)
            //{
            //    if (item.ISBN == ISBN)
            //    {
            //        return item;
            //    }
            //}

            //return null;

            Kitap aranan = list.Where(i => i.ISBN == ISBN).FirstOrDefault();

            if (aranan != null)
            {
                Console.WriteLine("ISBN:" + aranan.ISBN);
                Console.WriteLine("Kitap Adı:" + aranan.Ad);
                Console.WriteLine("Yazar:" + aranan.Yazar);
                Console.WriteLine("Durumu:" + (aranan.Durum == true ? "Ödünç Verilebilir" : "Ödünç Verilemez"));
            }

            Console.WriteLine("Kitap bulunamadı.");
        }

        public static void Listele(List<Kitap> list)
        {
            foreach (Kitap item in list)
            {
                Console.WriteLine("ISBN:"+item.ISBN);
                Console.WriteLine("Kitap Adı:"+item.Ad);
                Console.WriteLine("Yazar:"+item.Yazar);
                Console.WriteLine("Durumu:"+(item.Durum==true ? "Ödünç Verilebilir": "Ödünç Verilemez"));
            }
        }
    }
}
