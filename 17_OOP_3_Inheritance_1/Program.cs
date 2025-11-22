namespace _17_OOP_3_Inheritance_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //KALITIM-MİRAS ALMA-INHERITANCE

            //Ortak özelliklere sahip classların tek bir class üzerinden miras alma yöntemi ile ortak özellikleri yazılmadan çekmesine ve sadece kendisine özel olan özellikleri tanımlanmasına denir.

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

    class Calisan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TC { get; set; }
        public DateTime DogumTarihi { get; set; }

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
}
