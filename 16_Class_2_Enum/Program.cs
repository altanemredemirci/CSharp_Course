namespace _16_Class_2_Enum
{

    //Enum: Sabit Veri Tipi
    enum Markalar { Mercedes=1,BMW,Opel,Ford }

    internal class Program
    {
        static void Main(string[] args)
        {
            Araba araba = new Araba();
            araba.Fiyat = 10000000;
            araba.Plaka="34TE223";
            araba.Marka = Markalar.BMW;

            Console.WriteLine(araba.Marka);
            Console.WriteLine(araba.Fiyat);
            Console.WriteLine(araba.Plaka);
        }
    }

    class Araba
    {
        public string Plaka;
        public Markalar Marka;
        public double Fiyat;
    }
}
