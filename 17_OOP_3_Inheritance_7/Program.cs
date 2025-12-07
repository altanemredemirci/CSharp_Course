namespace _17_OOP_3_Inheritance_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Protected: Sadece miras alındığı sınıflarda erişilebilir.       

            //Instance
            Vatandas vatandas = new Vatandas();
            //vatandas.

        }
    }

    class Insan
    {
        public int Boy { get; set; }
        protected int Agirlik { get; set; } //Miras alındığı sınıfta kullanılabilir.

        protected void Ozellikler()
        {
            Console.WriteLine(Boy);
            Console.WriteLine(Agirlik);
        }
    }

    class Vatandas : Insan
    {
        public string TC { get; set; }

        public void Yazdir()
        {
            Console.WriteLine(Agirlik);

            Ozellikler();
        }
    }
}
