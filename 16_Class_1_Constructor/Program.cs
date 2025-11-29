namespace _16_Class_1_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CONSTRUCTOR METHOD - YAPICI(KURUCU) METOT
            /*
             Bir sınıftan bir nesne oluşturulduğunda otomatik çalışan gizli metoddur. 
             Bulunuduğu class ile aynı isme sahiptir.
             Herhangi bir void veya return değer almaz.
             Nesne oluşturulduğu an otomatik çalışır ve tanımlanan işlemi gerçekleştirir.
             */

            Ogrenci ogrenci = new Ogrenci();
            //Ogrenci ogrenci2 = new Ogrenci(1,"Altan","Emre");


            Ogrenci ogrenci3 = new Ogrenci(1,"Altan","Emre");           
        }
    }

    class Ogrenci
    {
        //property - nitelik
        public int Numara;
        public string Ad;
        public string Soyad;

        //Sınıfı ile aynı isme sahip içi boş, gizli tanımlı bir metot vardır.
        //public Ogrenci()
        //{

        //}

        //public Ogrenci()
        //{
        //    Console.WriteLine("Nesne Oluştu.");
        //}

        public Ogrenci(int numara, string ad, string soyad)
        {
            Numara = numara;
            Ad = ad;
            Soyad = soyad;
        }

        //public Ogrenci()
        //{
        //    Console.WriteLine("Numara:");
        //    Numara = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Ad:");
        //    Ad = Console.ReadLine();
        //    Console.WriteLine("Soyad:");
        //    Soyad = Console.ReadLine();
        //}


        public Ogrenci()
        {
            Kayit();
        }

        public static void Kayit()
        {
            Ogrenci ogrenci = new Ogrenci();
            Console.WriteLine("Numara:");
            ogrenci.Numara = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ad:");
            ogrenci.Ad = Console.ReadLine();
            Console.WriteLine("Soyad:");
            ogrenci.Soyad = Console.ReadLine();
        }
    }
}
