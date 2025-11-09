namespace _14_Class_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bir üniversite öğrenci kayıt sistemine ihtiyacımız var.

            //Öğrenci:Numara,adSoyad,bolum,Tc
            //Ekle,Listele,Sil ve Güncelle 

            List<Ogrenci> ogrenciler = new List<Ogrenci>();
            while (true)
            {
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine("1-Öğrenci Ekle\n2-Öğrenci Listele\n3-Öğrenci Sil\n4-Öğrenci Güncelle\nSeçiminiz:");
                int secim = Convert.ToInt32(Console.ReadLine());

                if (secim == 1)
                {
                    Ogrenci.Kayit(ogrenciler);
                }

                else if (secim == 2)
                {
                    Ogrenci.Listele(ogrenciler);
                }

                else if (secim == 3)
                {
                    Ogrenci.Sil(ogrenciler);
                }

                else if (secim == 4)
                {
                    Ogrenci.Guncelle(ogrenciler);
                }
                else
                {
                    Console.WriteLine("Hatalı Tuşlama!");
                }
            }
        }
    }
}
