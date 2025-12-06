namespace _17_OOP_4_Polymorphism_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.
        }
    }
    class Insan
    {
        public int Boy { get; set; }
        public int Agirlik { get; set; }

        public virtual void Kayit()
        {
            Console.WriteLine("Boy:");
            Boy = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ağırlık:");
            Agirlik = Convert.ToInt32(Console.ReadLine());
        }
    }
    class Ogrenci : Insan
    {
        public int No { get; set; }
        public string Ad { get; set; }

        public override void Kayit()
        {
            base.Kayit();
            Console.WriteLine("Ad:");
            Ad = Console.ReadLine();
            Console.WriteLine("No:");
            No = Convert.ToInt32(Console.ReadLine());
        }
    }

    class Lise : Ogrenci
    {
        public string Bolum { get; set; }

        public override void Kayit()
        {
            base.Kayit();
            Console.WriteLine("Bölüm:");
            Bolum = Console.ReadLine();
        }
    }


}
