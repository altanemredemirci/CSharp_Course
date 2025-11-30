namespace _17_OOP_3_Inheritance_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IK> IKListesi = new List<IK>();

            /* 
           Şirket Otomasyonu

           IK:Ad,Soyad,TC,SGKGirisTarihi,PersonelSayisi
           IT:Ad,Soyad,TC,SGKGirisTarihi,ProgramSayisi
           MUH:Ad,Soyad,TC,SGKGirisTarihi,HesapSayisi
           PAZ:Ad,Soyad,TC,SGKGirisTarihi,TeklifSayisi

           PersonelEkle(),PersonelListele(),PersonelSil(),PersonelGuncelle()


           */
        }
    }

    class Personel
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TC { get; set; }
        public string SGKGirisTarihi { get; set; }

        public void PersonelEkle()
        {
            Console.WriteLine("Ad:");
            Ad = Console.ReadLine();

            Console.WriteLine("Soyad:");
            Soyad = Console.ReadLine();

            Console.WriteLine("TC:");
            TC = Console.ReadLine();

            Console.WriteLine("SGKGirisTarihi:");
            SGKGirisTarihi = Console.ReadLine();

        }

        public void Listele()
        {
            Console.WriteLine(Ad);
            Console.WriteLine(Soyad);
            Console.WriteLine(TC);
            Console.WriteLine(SGKGirisTarihi);
        }
        public static void PersonelSil(List<Personel> liste)
        {
            foreach (IK item in liste)
            {
                Console.WriteLine(item.Ad + " " + item.Soyad + " " + item.TC);
            }
            Console.WriteLine("Silinecek personel tc:");
            string tc = Console.ReadLine();

            Personel personel = liste.Where(i => i.TC == tc).FirstOrDefault();
            if (personel != null)
            {
                liste.Remove(personel);
            }
        }
    }

    class IK : Personel
    {
        public int PersonelSayisi { get; set; }

        public new void PersonelEkle()
        {
            base.PersonelEkle();
            Console.WriteLine("Personel Sayısı:");
            PersonelSayisi = Convert.ToInt32(Console.ReadLine());
        }
        public new void Listele()
        {
            base.Listele();
            Console.WriteLine(PersonelSayisi);
        }

        public static void PersonelSil(List<IK> liste)
        {
            foreach (IK item in liste)
            {
                Console.WriteLine(item.Ad+" "+item.Soyad + " "+item.TC);
            }
            Console.WriteLine("Silinecek personel tc:");
            string tc = Console.ReadLine();

            IK personel=liste.Where(i => i.TC == tc).FirstOrDefault();
            if (personel != null)
            {
                liste.Remove(personel);
            }
        }

    }
    class IT : Personel
    {
        public int ProgramSayisi { get; set; }
        public new void PersonelEkle()
        {
            base.PersonelEkle();
            Console.WriteLine("Program Sayısı:");
            ProgramSayisi = Convert.ToInt32(Console.ReadLine());
        }
        public new void Listele()
        {
            base.Listele();
            Console.WriteLine(ProgramSayisi);
        }
        public static void PersonelSil(List<IT> liste)
        {
            foreach (IT item in liste)
            {
                Console.WriteLine(item.Ad + " " + item.Soyad + " " + item.TC);
            }
            Console.WriteLine("Silinecek personel tc:");
            string tc = Console.ReadLine();

            IT personel = liste.Where(i => i.TC == tc).FirstOrDefault();
            if (personel != null)
            {
                liste.Remove(personel);
            }
        }
    }
    class MUH : Personel
    {
        public int HesapSayisi { get; set; }
        public new void PersonelEkle()
        {
            base.PersonelEkle();
            Console.WriteLine("Hesap Sayısı:");
            HesapSayisi = Convert.ToInt32(Console.ReadLine());
        }
        public new void Listele()
        {
            base.Listele();
            Console.WriteLine(HesapSayisi);
        }
        public static void PersonelSil(List<MUH> liste)
        {
            foreach (MUH item in liste)
            {
                Console.WriteLine(item.Ad + " " + item.Soyad + " " + item.TC);
            }
            Console.WriteLine("Silinecek personel tc:");
            string tc = Console.ReadLine();

            MUH personel = liste.Where(i => i.TC == tc).FirstOrDefault();
            if (personel != null)
            {
                liste.Remove(personel);
            }
        }
    }
    class PAZ : Personel
    {
        public int TeklifSayisi { get; set; }
        public new void PersonelEkle()
        {
            base.PersonelEkle();
            Console.WriteLine("TeklifSayisi:");
            TeklifSayisi = Convert.ToInt32(Console.ReadLine());
        }
        public new void Listele()
        {
            base.Listele();
            Console.WriteLine(TeklifSayisi);
        }
        public static void PersonelSil(List<PAZ> liste)
        {
            foreach (PAZ item in liste)
            {
                Console.WriteLine(item.Ad + " " + item.Soyad + " " + item.TC);
            }
            Console.WriteLine("Silinecek personel tc:");
            string tc = Console.ReadLine();

            PAZ personel = liste.Where(i => i.TC == tc).FirstOrDefault();
            if (personel != null)
            {
                liste.Remove(personel);
            }
        }
    }
}
