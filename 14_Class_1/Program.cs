namespace _14_Class_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bir üniversite öğrenci kayıt sistemine ihtiyacımız var.

            //Öğrenci:Numara,adSoyad,bolum,Tc

            //int numara = 1213;
            //string adSoyad = "Altan Emre";
            //string bolum = "Yazılım";
            //long tc = 1321312313123;

            //int numara2 = 1214;
            //string adSoyad2 = "Altan Uras";
            //string bolum2 = "Elektronik";
            //long tc2 = 1321312313123;

            //int numara3 = 1215;
            //string adSoyad3 = "Altan Emre";
            //string bolum3 = "Yazılım";
            //long tc3 = 1321312313123;


            //List<Ogrenci> ogrenciler = new List<Ogrenci>();



            ////Nesne Oluşturma İşlemi - Instance - Örneklem
            //Ogrenci ogrenci = new Ogrenci(); //ogrenci => object-nesne
            //ogrenci.Numara = 1111;
            //ogrenci.AdSoyad = "Altan Emre";
            //ogrenci.Bolum = "Yazılım";
            //ogrenci.Tc = "12345678901";


            //Ogrenci ogrenci2 = new Ogrenci();
            //ogrenci2.Numara = 1112;
            //ogrenci2.AdSoyad = "Kıvanç Demirci";
            //ogrenci2.Bolum = "İşletme";
            //ogrenci2.Tc = "12345678902";


            //Ogrenci ogrenci3 = new Ogrenci();
            //Console.WriteLine("Numarası:");
            //ogrenci3.Numara = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Ad Soyad:");
            //ogrenci3.AdSoyad = Console.ReadLine();

            //Console.WriteLine("Bölüm:");
            //ogrenci3.Bolum = Console.ReadLine();

            //Console.WriteLine("TC:");
            //ogrenci3.Tc = Console.ReadLine();


            //Ogrenci.Kayit(ogrenciler);
            //Ogrenci.Kayit(ogrenciler);
            //Ogrenci.Kayit(ogrenciler);

           


            ogrenciler.Add(ogrenci);
            ogrenciler.Add(ogrenci2);
            //ogrenciler.Add(ogrenci3);


            Console.WriteLine(ogrenciler);
            Console.WriteLine(ogrenciler[0].AdSoyad);
            Console.WriteLine(ogrenciler[1].Bolum);
        }
    }
}
