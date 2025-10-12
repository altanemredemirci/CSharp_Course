namespace _08_Döngüler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* LOOPS - DÖNGÜLER
             * While
             * For
             * Do While
             * Foreach
           Döngüler belirli bir koşula bağlı olarak kendi içlerindeki kod bloğunu tekrarlı şekilde çalıştıran yazılım yapılarıdır.
                       
             
             */

            #region WHILE
            /*
            while (koşul) //koşul true olduğu sürece {} içerisindeki kodlar tekrar tekrar çalışır. Ne zaman koşul false olursa o zaman döngü biter.
            {

            }
            */

            //1-10 aralığında sayıları ekrana yazdırınız

            //Console.WriteLine(1);
            //Console.WriteLine(2);
            //Console.WriteLine(3);
            //Console.WriteLine(4);
            //Console.WriteLine(5);
            //Console.WriteLine(6);

            //int i = 1;

            //while (i < 11)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}



            //Kullanıcı 0 girene kadar sayı al ve alınan sayıları topla. 0 girdiğinde döngüyü bitir ve toplamı ekrana yaz

            //Console.WriteLine("Sayı:");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //int toplam = 0;

            //while (sayi != 0)
            //{
            //    toplam = toplam + sayi;

            //    Console.WriteLine("Sayı:");
            //    sayi = Convert.ToInt32(Console.ReadLine());
            //}



            //int toplam = 0;
            //while (true)//Sonsuz döngü
            //{
            //    Console.WriteLine("Sayı:");
            //    int sayi = Convert.ToInt32(Console.ReadLine());

            //    if (sayi == 0)
            //    {
            //        Console.WriteLine("Toplam:"+toplam);
            //        break;
            //    }

            //    toplam = toplam + sayi;
            //}


            #region 200 ile 0 arasındaki sayılardan 3'e tam bölünenleri ekrana yazdırınız.

            //int sayi = 200;

            //while (sayi > 0)
            //{
            //    if (sayi % 3 == 0)
            //    {
            //        Console.WriteLine(sayi);
            //    }

            //    sayi--;
            //}


            #endregion

            #region 0-500 arasındaki sayılardan çiftleri ayrı tekleri ayrı toplayarak ekrana toplamları yazınız

            //int sayi = 0;
            //int tektoplam = 0;
            //int cifttoplam = 0;

            //while (sayi < 500)
            //{
            //    if (sayi % 2 == 0)
            //    {
            //        cifttoplam = cifttoplam + sayi;
            //    }
            //    else
            //    {
            //        tektoplam = tektoplam + sayi;
            //    }
            //    sayi++;                  
            //}

            //Console.WriteLine("Tek Toplam:"+tektoplam);
            //Console.WriteLine("Çift Toplam:"+cifttoplam);

            #endregion

            #region BREAK VE CONTINUE KOMUTLARI

            //Break:Okunduğu satırda döngü işlemini bitirir.

            //Continue:Okunduğu satırdan döngü satırına geri döner.

            //1-20 arasındaki sayıları toplayınız
            //7 sayısı toplama işleminde atlansın
            //sayı 15 olduğunda döngü bitsin

            int sayi = 1;

            int toplam = 0;
            while (sayi < 20)
            {
                if (sayi==7)
                {
                    //7 sayısı toplama dahil edilmeyecek
                    sayi++;
                    continue;
                }
                if (sayi == 15)
                {
                    break;
                }
                toplam += sayi; //toplam=toplam+sayi
                sayi++;

            }
            Console.WriteLine(toplam);


            #endregion


            #endregion

        }
    }
}
