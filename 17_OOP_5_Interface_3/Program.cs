namespace _17_OOP_5_Interface_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Şirket:
            // Personel: Id,Departman,ToplamCalismaSaati,AdSoyad,Adres,Maas
            // Robot : Id,Departman,ToplamCalismaSaati
            // Mudur: Id,Departman,ToplamCalismaSaati,AdSoyad,Adres,Maas,PersonelSayisi
        }
    }

    interface ICalisan
    {
        int Id { get; set; }
        string Departman { get; set; }
        int ToplamCalismaSaati { get; set; }
    }

    interface IKisi
    {
        string AdSoyad { get; set; }
        string Adres { get; set; }
        int Maas { get; set; }
    }

    class Robot : ICalisan
    {
        public int Id { get; set; }
        public string Departman { get; set; }
        public int ToplamCalismaSaati { get; set; }
    }

    class Personel : ICalisan, IKisi
    {
        public int Id { get; set; }
        public string Departman { get; set; }
        public int ToplamCalismaSaati { get; set; }
        public string AdSoyad { get; set; }
        public string Adres { get; set; }
        public int Maas { get; set; }
    }

    class Mudur : IKisi, ICalisan
    {
        public string AdSoyad { get; set; }
        public string Adres { get; set; }
        public int Maas { get; set; }
        public int Id { get; set; }
        public string Departman { get; set; }
        public int ToplamCalismaSaati { get; set; }
        public int PersonelSayisi { get; set; }
    }
}
