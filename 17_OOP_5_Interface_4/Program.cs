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

            List<Islem> Islemler = new List<Islem>();

         
            KrediKarti krediKarti = new KrediKarti();
            krediKarti.KartNo = "1111";
            krediKarti.KartSahibi = "Altan Emre Demirci";
            krediKarti.Limit = 50000;

            BankaHavalesi bankaHavalesi = new BankaHavalesi();
            bankaHavalesi.Bakiye = 50000;
            bankaHavalesi.BankaAdi = "Ziraat Yatırım";
            bankaHavalesi.HesapNo = "1111";

            Kripto kripto = new Kripto();
            kripto.CuzdanAdresi = "A0XXAAB";
            kripto.KriptoTipi = "Bitcoin";
            kripto.Miktar = 1000;

            int islemNo = 0;

            while (true)
            {
                Console.WriteLine("1-Kredi Kartı\n2-Banka Hesabı\n3-Kripto\nİşlem Tipi:");
                string secim = Console.ReadLine();

                if (secim == "1") 
                {
                    Console.WriteLine("1-Ödeme Yap\n2-Limit Sorgula\n3-İşlem İptal\nSeçiminiz:");
                    string secimIslem = Console.ReadLine();

                    if (secimIslem == "1")
                    {
                        Console.WriteLine("Ödeme miktarı:");
                        double miktar = Convert.ToDouble(Console.ReadLine());

                        double sonuc = krediKarti.OdemeYap(miktar);

                        Islem islem = new Islem();
                        islem.IslemNo = ++islemNo;
                        islem.odemeYontemi = krediKarti;
                        islem.Tutar = miktar;
                        islem.IslemDurumu = sonuc == 1 ? true : false;
                        Islemler.Add(islem);
                    }
                    else if (secimIslem == "2")
                    {
                        Console.WriteLine(krediKarti.BakiyeSorgula());
                    }
                    else
                    {
                        foreach (Islem item in Islemler.Where(i=> i.IslemDurumu==true).ToList())
                        {
                            Console.WriteLine("İşlem No:"+item.IslemNo+" Tutar:"+item.Tutar);
                        }

                        Console.WriteLine("İptal Edilecek İşlem No:");
                        int islemNumarasi = Convert.ToInt32(Console.ReadLine());

                        Islem silinecekIslem = Islemler.Where(i => i.IslemNo == islemNumarasi).FirstOrDefault();

                        if (silinecekIslem != null)
                        {
                            silinecekIslem.IslemDurumu = false;
                            krediKarti.Limit += silinecekIslem.Tutar;
                            Console.WriteLine("İşlem iptal edildi.");
                        }
                    }

                   
                }
                else if (secim == "2") 
                {
                    Console.WriteLine("Ödeme miktarı:");
                    double miktar = Convert.ToDouble(Console.ReadLine());

                    double sonuc = bankaHavalesi.OdemeYap(miktar);

                    Islem islem = new Islem();
                    islem.IslemNo = ++islemNo;
                    islem.odemeYontemi = bankaHavalesi;
                    islem.Tutar = miktar;
                    islem.IslemDurumu = sonuc == 1 ? true : false;
                    Islemler.Add(islem);

                }
                else if (secim == "3") 
                {
                    Console.WriteLine("Ödeme miktarı:");
                    double miktar = Convert.ToDouble(Console.ReadLine());

                    double sonuc = kripto.OdemeYap(miktar);

                    Islem islem = new Islem();
                    islem.IslemNo = ++islemNo;
                    islem.odemeYontemi = kripto;
                    islem.Tutar = miktar;
                    islem.IslemDurumu = sonuc == 1 ? true : false;
                    Islemler.Add(islem);
                }
                else
                {
                    Console.WriteLine("Hatalı Seçim!!");
                }
            }







        }
    }

    //class,interface erişim belirteci olarak default internal tanımlıdır.
    public interface IOdemeYontemi
    {
        double OdemeYap(double tutar); //default olarak public tanımlıdır.
        void IslemIptal(string islemNo);
        double BakiyeSorgula();
        void OdemeDetayGoster();
    }

    class Islem
    {
        public int IslemNo { get; set; }
        public IOdemeYontemi odemeYontemi { get; set; }
        public double Tutar { get; set; }
        public bool IslemDurumu { get; set; }
    }


    class KrediKarti : IOdemeYontemi
    {
        public string KartNo { get; set; }
        public string KartSahibi { get; set; }
        public double Limit { get; set; }
        public double BakiyeSorgula()
        {
            return Limit;
        }

        public void IslemIptal(string islemNo)
        {
            throw new NotImplementedException();
        }

        public void OdemeDetayGoster()
        {
            Console.WriteLine(Limit);
        }

        public double OdemeYap(double tutar)
        {
            if (Limit >= tutar)
            {
                Limit -= tutar;

                return 1;
            }
            else
            {
                return -1;
            }
              
        }
    }

    class BankaHavalesi : IOdemeYontemi
    {
        public string HesapNo { get; set; }
        public string BankaAdi { get; set; }
        public double Bakiye { get; set; }
        public double BakiyeSorgula()
        {
            throw new NotImplementedException();
        }

        public void IslemIptal(string islemNo)
        {
            throw new NotImplementedException();
        }

        public void OdemeDetayGoster()
        {
            throw new NotImplementedException();
        }

        public double OdemeYap(double tutar)
        {
            throw new NotImplementedException();
        }
    }

    class Kripto : IOdemeYontemi
    {
        public string CuzdanAdresi { get; set; }
        public string KriptoTipi { get; set; }
        public double Miktar { get; set; }
        public double OdemeYap(double tutar)
        {
            throw new NotImplementedException();
        }

        public void IslemIptal(string islemNo)
        {
            throw new NotImplementedException();
        }

        public double BakiyeSorgula()
        {
            throw new NotImplementedException();
        }

        public void OdemeDetayGoster()
        {
            throw new NotImplementedException();
        }
    }
}
