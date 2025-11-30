namespace _17_OOP_3_Inheritance_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bir Kolej sisteminde ilkokul,Ortaokul ve lise yer almaktadır.
            //ilkokul:No,Ad,Soyad,Veli Telefon,OkumaYazmaBiliyorMu
            //ortaokul:No,Ad,Soyad,Veli Telefon,Notlar
            //lise:No,Ad,Soyad,Veli Telefon,YKSPuanı

            Ilkokul ilkokulogrenci = new Ilkokul();
            ilkokulogrenci.Ad = "Altan Emre";
            ilkokulogrenci.Soyad = "Demirci";
            ilkokulogrenci.No = 1;
            ilkokulogrenci.VeliTelefonu = "05366295131";
            ilkokulogrenci.OkumaBiliyor = false;

            ilkokulogrenci.Yaz();
            //ilkokulogrenci.Kaydet();
            Ilkokul.Kaydet();

        }
    }

    class Ogrenci
    {
        public int No { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string VeliTelefonu { get; set; }

        public void Yaz()
        {
            Console.WriteLine("No:" + No);
            Console.WriteLine("Ad:" + Ad);
            Console.WriteLine("Soyad:" + Soyad);
            Console.WriteLine("Telefon:" + VeliTelefonu);
        }

        public static void Kaydet()
        {
            Ogrenci ogrenci = new Ogrenci();
            Console.WriteLine("Öğrenci No:");
            ogrenci.No = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Öğrenci Adı:");
            ogrenci.Ad = Console.ReadLine();
            Console.WriteLine("Öğrenci Soyadı:");
            ogrenci.Soyad = Console.ReadLine();
            Console.WriteLine("Öğrenci Veli Telefon Numarası:");
            ogrenci.VeliTelefonu = Console.ReadLine();

        }
    }

    class Ilkokul : Ogrenci
    {
        public bool OkumaBiliyor { get; set; }

        public new void Yaz() //new keyword'ü ile miras alınan metot yok sayılıyor.
        {
            base.Yaz(); //Miras alınan sınıfı temsil eder.
            Console.WriteLine("Okuma Biliyor Mu?"+OkumaBiliyor);
        }
    }

    class Ortaokul : Ogrenci
    {
        public int Notlar { get; set; }

        public new void Yaz()
        {
            base.Yaz();
            Console.WriteLine("Notlar:" + Notlar);
        }
    }
    class Lise : Ogrenci
    {
        public int YKSPuani { get; set; }

        public new void Yaz() 
        {
            base.Yaz(); 
            Console.WriteLine("YKS Puanı:" + YKSPuani);
        }
    }
}
