namespace _17_OOP_5_Interface_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Bir e-ticaret sitesi için farklı ödeme yöntemlerini destekleyen bir sistem geliştireceksiniz.
           
             * IOdemeYontemi adında bir interface oluşturun. Bu interface şunları içermelidir:

                OdemeYap(double tutar) - bool döndürmeli
                IslemIptal(string islemNo) - void
                BakiyeSorgula() - double döndürmeli
                OdemeDetayGoster() - void

            * KrediKarti Sınıfı
                IOdemeYontemi interface'ini implement etmeli
                Properties: KartNo (string), KartSahibi (string), Limit (double)
                Ödeme yaparken limit kontrolü yapmalı
                Her ödeme sonrası limit azalmalı

            * BankaHavalesi Sınıfı
                IOdemeYontemi interface'ini implement etmeli
                Properties: HesapNo (string), BankaAdi (string), Bakiye (double)
                Ödeme yaparken bakiye kontrolü yapmalı
                Her ödeme sonrası bakiye azalmalı
            
             * Kripto Sınıfı
                IOdemeYontemi interface'ini implement etmeli
                Properties: CuzdanAdresi (string), KriptoTipi (string - örn: "Bitcoin"), Miktar (double)
                Ödeme yaparken miktar kontrolü yapmalı
                Her ödeme sonrası miktar azalmalı

            Her ödeme yönteminden 1'er nesne oluşturun
            Her ödeme yöntemi ile 500 TL'lik bir ödeme yapın
            Tüm ödeme yöntemlerinin detaylarını gösterin
            List<IOdemeYontemi> kullanarak tüm ödeme yöntemlerini bir listede saklayın ve döngü ile işleyin
             */
        }
    }
}
