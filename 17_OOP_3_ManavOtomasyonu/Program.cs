namespace _17_OOP_3_ManavOtomasyonu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Hal.AnaSecim();
                Hal.UrunSatis();
                Console.WriteLine("Başka Arzunuz Var Mı?(E/H)");
                string cevap = Console.ReadLine().ToUpper();
                if (cevap != "E")
                {
                    break;
                }
            }

            while (true)
            {
                Manav.AnaSecim();
                Manav.UrunSatis();
                Console.WriteLine("Başka Arzunuz Var Mı?(E/H)");
                string cevap = Console.ReadLine().ToUpper();
                if (cevap != "E")
                {
                    break;
                }
            }

            Console.WriteLine("HAL LİSTESİ");
            foreach (Urun item in Hal.urunler)
            {
                Console.WriteLine($"{item.Ad}:{item.Fiyat} - {item.Stok}");
            }

            Console.WriteLine("MANAV LİSTESİ");
            foreach (Urun item in Manav.urunler)
            {
                Console.WriteLine($"{item.Ad}:{item.Fiyat} - {item.Stok}");
            }

            Console.WriteLine("MÜŞTERİ LİSTESİ");
            foreach (Urun item in Musteri.urunler)
            {
                Console.WriteLine($"{item.Ad}:{item.Fiyat} - {item.Stok}");
            }

        }
    }

    

   

   
}
