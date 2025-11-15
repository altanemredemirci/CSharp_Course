namespace _15_Kutuphane_Otomasyonu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1-Kitap Ekle\n2-Kitap Sil\n3-Kitap Listele\n4-Kitap Ara\n5-Ödünç Ver\n6-Ödünç Listesi\n7-Üye Ekle\n8-Üye Listele\n9-Çıkış");
                Console.WriteLine("Seçiminiz:");
                int secim = Convert.ToInt32(Console.ReadLine());

                if (secim == 1){ Kitap.Ekle(Kutuphane.Kitaplar); }
                else if (secim == 2){ Kitap.Sil(Kutuphane.Kitaplar); }
                else if (secim == 3){ Kitap.Listele(Kutuphane.Kitaplar);}
                else if (secim == 4) { Kitap.KitapAra(Kutuphane.Kitaplar); }
                else if (secim == 5) { Kutuphane.OduncAl(Kutuphane.Kitaplar); }
                else if (secim == 6) { Kutuphane.OduncListele(Kutuphane.Kitaplar); }
                else if (secim == 7) { Uye.Ekle(Kutuphane.Uyeler); }
                else if (secim == 8) { Uye.Listele(Kutuphane.Uyeler); }
                else if (secim == 9) { break; }
                else
                {
                    Console.WriteLine("Hatalı Seçim!");
                }
                
            }
        }
    }






}
