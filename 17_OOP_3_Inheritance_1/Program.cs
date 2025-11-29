namespace _17_OOP_3_Inheritance_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //KALITIM-MİRAS ALMA-INHERITANCE

            //Ortak özelliklere sahip classların tek bir class üzerinden miras alma yöntemi ile ortak özellikleri yazılmadan çekmesine ve sadece kendisine özel olan özellikleri tanımlanmasına denir.
            // ** KURAL: Her sınıf tek bir sınıfatan kalıtım alabilir.
            // ** KURAL: Kalıtım alınan sınıfdaki özelliklerin private harici hepsi aktarılır.

            IK ik = new IK();
            ik.Yaz();
            

            IT it = new IT();
            it.Yaz();
            


        }
    }


    /*
      ŞİRKET OTOMASYONU
      *IK: Ad,Soyad,TC,DogumTarihi,Maas,PersonelSayisi
      *IT: Ad,Soyad,TC,DogumTarihi,Maas,BildigiProgramlar
      *MUH:Ad,Soyad,TC,DogumTarihi,Maas,HesapSayisi
     */

    class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TC { get; set; }
        public DateTime DogumTarihi { get; set; }
    }

    class Calisan:Vatandas
    {
        public int Maas { get; set; }

        public void Yaz()
        {
            Console.WriteLine("Ben bir Çalışanım");
        }
    }


    class IK:Calisan
    {
        public int PersonelSayisi { get; set; }
    }

    class IT:Calisan
    {
        public string BildigiProgramlar { get; set; }
    }

    class MUH:Calisan
    {
        public int HesapSayisi { get; set; }
    }

    class Musteri:Vatandas
    {
        public string FirmaAdi { get; set; }
    }

}
