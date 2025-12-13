namespace _17_OOP_6_RentACar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             ARAÇ KİRALAMA SİSTEMİ
             
             Bir araç kiralama şirketi için Araç Yönetim Sistemi geliştireceksiniz. Aşağıdaki gereksinimleri karşılayan bir C# konsol uygulaması yazınız.
             
            * IElektrikliArac adında bir interface oluşturun. Bu interface şunları içermelidir:

            BataryaKapasitesi (double) - Property
            MaksimumMenzil (double) - Property
            BataryaDurumunuGoster() - Metod
            SarjSuresiHesapla() - Metod (double döndürmeli)


            * Arac adında bir abstract class oluşturun. Bu sınıf şunları içermelidir:

            Properties: Marka, Model, Yil, Plaka, GunlukKiraBedeli
            Constructor: Tüm özellikleri parametre olarak alsın
            
            * Abstract Metodlar:
            KiraUcretiHesapla(int gun) - double döndürmeli
            AracBilgileriniGoster() - void
            AracTipiGetir() - string döndürmeli
            
            * Virtual Metod:
            GenelBilgi() - Araç bilgilerini konsola yazdırsın

            * Araba Sınıfı:
            Arac sınıfından türetilmeli
            Ek özellikler: KapiSayisi (int), VitesTipi (string)
            Kira ücreti hesaplama: Günlük kira × gün sayısı × 1.10 (hizmet bedeli)
            

            * ElektrikliAraba Sınıfı
            Araba sınıfından türetilmeli
            IElektrikliArac interface'ini implement etmeli
            Şarj süresi hesaplama: BataryaKapasitesi / 10 (her 10 kWh için 1 saat)
            Kira ücreti hesaplama: Günlük kira × gün sayısı × 0.95 (%5 indirim)
             
            * Motosiklet Sınıfı
            Arac sınıfından türetilmeli
            Ek özellikler: MotorHacmi (int), YanCantaVarMi (bool)
            Kira ücreti hesaplama: Günlük kira × gün sayısı + (yan çanta varsa günlük 50 TL ekstra)

            * Main metodunda:

            En az 1 Araba, 1 ElektrikliAraba, 1 Motosiklet nesnesi oluşturun
            Tüm araçların bilgilerini gösterin
            Her araç için 7 günlük kiralama ücretini hesaplayıp ekrana yazdırın
            Polimorfizm kullanarak tüm araçları List<Arac> içinde saklayın ve döngü ile işleyin


             */

            Araba araba = new Araba("Renault","Megane",2013,"34YN297",500,5,"Otomatik");
            ElektrikliAraba elektrikliAraba = new ElektrikliAraba("Tesla","Y",2025,"34TK1152",1000,5,"Otomatik");
            Motorsiklet motorsiklet = new Motorsiklet("Honda","R1000",2020,"34TE2447",400,1000,true);

            Console.WriteLine(araba.KiraUcretiHesapla(7));
            Console.WriteLine(elektrikliAraba.KiraUcretiHesapla(7));
            Console.WriteLine(motorsiklet.KiraUcretiHesapla(7));

            List<Arac> araclar = new List<Arac>()
            {
                araba,elektrikliAraba,motorsiklet
            };

        }
    }

}
