namespace _16_Class_5_Partial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* --- PARTIAL ---
             * Bir bütünün parçaları anlamına gelir. Tek başına bir class gibi davranır.
             * Partial classlar aynı isimde olmak zorundadır.
             * Aynı isimdeki partiallar bir araya gelerek bir bütün oluştururlar.             
             */

            Personel personel = new Personel();
            personel.

        }
    }

    partial class Personel
    {
        public string Ad;
        public string Soyad;
        public int Maas;
    }

    partial class Personel
    {
        public string Departman;
        public int CalismaSaati;
    }
}
