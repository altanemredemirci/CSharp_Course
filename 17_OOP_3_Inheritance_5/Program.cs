namespace _17_OOP_3_Inheritance_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Isci isci = new Isci("Altan", "Emre",100000);

            
        }
    }
    class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public Vatandas(string ad,string soyad)
        {
            Ad = ad;
            Soyad = soyad;
        }
    }

    class Isci : Vatandas
    {
        public int Maas { get; set; }

        public Isci(string isim,string soyisim,int maas):base(isim,soyisim)
        {
            Maas = maas;
        }
    }

    class Usta : Vatandas
    {
        public string Meslek { get; set; }

        public Usta(string ad, string soyad):base(ad,soyad)
        {
            
        }
    }
}
