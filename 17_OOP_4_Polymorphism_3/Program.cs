namespace _17_OOP_4_Polymorphism_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Tekstil    : Ad,Fiyat,KumasTuru,Beden,UreticiFirma - KDVUygula(%20)
            CepTelefonu: Ad,Fiyat,Ozellikler,Marka - KDVUygula(%120)
            Ekmek      : Ad,Fiyat,EkmekTuru,Gramaj - KDVUygula(%20)

            Nesne ozelliklerini Contructor method ile alın.

            Sepet : Alınan urunleri bir listeye kaydetsin, Toplamtutarı söylesin

             */

            Ekmek ekmek = new Ekmek("Çavdar", 150, "ekmek", 250);
            CepTelefonu cepTelefonu = new CepTelefonu("Huawei", 30000, "Bluetooth", "Huawei");

            Sepet s = new Sepet();
            s.Ekle(ekmek);
            s.Ekle(cepTelefonu);

            Console.WriteLine(s.ToplamTutar());
        }
    }

    class Urun
    {
        public string Ad { get; set; }
        public double Fiyat { get; set; }

        public Urun(string ad, double fiyat)
        {
            Ad = ad;
            Fiyat = fiyat;
        }

        public virtual double KDVUygula()
        {
            return Fiyat * 1.2;
        }
    }

    class Tekstil : Urun
    {
        public string KumasTuru { get; set; }
        public string Beden { get; set; }
        public string UreticiFirma { get; set; }

        public Tekstil(string ad, double fiyat, string kumasTuru,string beden,string ureticiFirma):base(ad,fiyat)
        {
            KumasTuru = kumasTuru;
            Beden = beden;
            UreticiFirma = ureticiFirma;
        }
    }
    class CepTelefonu : Urun
    {
        public string Ozellikler { get; set; }
        public string Marka { get; set; }

        public CepTelefonu(string ad,double fiyat,string ozellikler,string marka):base(ad,fiyat)
        {
            Ozellikler = ozellikler;
            Marka = marka;
        }

        public override double KDVUygula()
        {
            return Fiyat * 2.2;
        }
    }

    class Ekmek : Urun
    {
        public string EkmekTuru { get; set; }
        public int Gramaj { get; set; }

        public Ekmek(string ad, double fiyat,string ekmekTuru,int gramaj):base(ad,fiyat)
        {
            EkmekTuru = ekmekTuru;
            Gramaj = gramaj;
        }
    }

    class Sepet
    {
        private List<Urun> urunler = new List<Urun>();

        public double ToplamTutar()
        {
            double toplam = 0;

            foreach (Urun urun in urunler)
            {
                toplam += urun.Fiyat;
            }
            return toplam;
        }

        public void Ekle(Urun urun)
        {
            urun.Fiyat = urun.KDVUygula();
            urunler.Add(urun);
        }
    }

}
