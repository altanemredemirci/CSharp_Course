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

            //int sayi = 1;

            //int toplam = 0;
            //while (sayi < 20)
            //{
            //    if (sayi==7)
            //    {
            //        //7 sayısı toplama dahil edilmeyecek
            //        sayi++;
            //        continue;
            //    }
            //    if (sayi == 15)
            //    {
            //        break;
            //    }
            //    toplam += sayi; //toplam=toplam+sayi
            //    sayi++;

            //}
            //Console.WriteLine(toplam);


            #endregion

            #region Kullanıcıdan 0 girilene kadar pozitif sayılar girmesi istensin. 
            //0 girilene kadar girilen pozitif sayılar toplansın ve ortalaması hesaplansın.
            // Kullanıcı 0 girdiğinde döngü bitsin ve toplam,ortalama ekrana yazdırılsın.
            // ** Kullanıcı ilk sayıyı 0 girerse tekrar sayı istensin
            // ** kullanıcı negatif sayı girerse "lütfen Pozitif Sayı Giriniz!!" uyarısını verilsin.

            //int toplam = 0;
            //int sayac = 0;
            //while (true)
            //{
            //    Console.WriteLine("Sayı giriniz:");
            //    int sayi = Convert.ToInt32(Console.ReadLine());

            //    if (sayi < 0)
            //    {
            //        Console.WriteLine("Pozitif Sayı Giriniz!");
            //    }
            //    else if (sayi == 0)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        toplam += sayi;
            //        sayac++;
            //    }
            //}

            //Console.WriteLine("Toplam:"+toplam);
            //Console.WriteLine("Ortalama:"+(toplam/sayac));


            #endregion
            #endregion


            #region FOR LOOP

            //1-10 arasındaki sayıları ekrana yazdırınız
            //int i = 1;
            //while (i < 11)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            /* While Çalışma Şekli
            1-Sayaç tanımlandı
            2-Koşul kontrol edildi. T->3 F->5
            3-İşlem yapıldı
            4-Sayaç arttırıldı. -> 2
            5-Bitti
             */

            //for(int a=1; a < 11; a++)
            //{
            //    Console.WriteLine(a);
            //}

            #region Başlangıç ve bitiş değerlerini kullanıcının girdiği sayı aralığını ekrana yazdıran döngü

            //Console.WriteLine("Başlangıç Değeri:");
            //int basla = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Bitiş Değeri:");
            //int bitis = Convert.ToInt32(Console.ReadLine());

            //if (basla > bitis)
            //{
            //    for (int i = bitis; i < basla; i++)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //else
            //{
            //    for (int i = basla; i < bitis; i++)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            #endregion

            #region Kullanıcının girmiş olduğu ilk 5 pozitif sayıyı toplayınız.

            //int toplam = 0;
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Sayı Giriniz");
            //    int sayi = Convert.ToInt32(Console.ReadLine());

            //    if (sayi > 0)
            //    {
            //        toplam += sayi;
            //    }
            //    else
            //    {
            //        i--;
            //    }

            //}


            //int i = 0;
            //while (i < 5)
            //{
            //    Console.WriteLine("Sayı Giriniz");
            //    int sayi = Convert.ToInt32(Console.ReadLine());

            //    if (sayi > 0)
            //    {
            //        toplam += sayi;
            //        i++;
            //    }
            //}






            //Console.WriteLine(toplam);

            #endregion

            #region Kullanıcıdan alınan bir sayının faktöriyeli hesaplayan for döngüsünü yazınız.

            ////5 => 1*2*3*4*5

            //int carpim = 1;

            //Console.WriteLine("Faktöriyel hesaplanacak sayı:");
            //int fakt = Convert.ToInt32(Console.ReadLine());


            //for (int i = 1; i <= fakt; i++)
            //{
            //    carpim *= i;
            //}

            //Console.WriteLine("Faktöriyel:"+carpim);

            #endregion


            #region 1-500 arasındaki sayıların içinden 13 katlarının sayısını ve toplamlarını hesaplayınız

            //int toplam = 0;
            //int sayac = 0;
            //for (int i = 1; i < 500; i++)
            //{
            //    if (i % 13 == 0)
            //    {
            //        toplam += i;
            //        sayac++;
            //    }
            //}
            //Console.WriteLine("Toplam:"+toplam);
            //Console.WriteLine("Adet:"+sayac);

            #endregion

            #region PASCAL ÜÇGENİ
            /*
             
             *
             **
             ***
             ****
             *****
             ******
             
             */

            //for (int i = 1; i < 7; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}



            #endregion

            #region DİKDÖRTGEN

            /*
             **********
             *        *
             *        *
             *        *
             *        *
             *        *
             *        *
             **********
             
             */

            #endregion

            #region YILBAŞI AĞACI
            /*
                *
               ***
              *****
             *******
            *********
           ***********
             */
            #endregion


            #region Ters Çam Ağacı
            /*
          *************
           ***********
            *********
             *******
              *****
               ***
                *

          */
            #endregion

            #region Çarpım Tablosu

            /* 
             1x1=1  2x1=2  3x1=3 ......
             1x2=2  2x2=4
             1x3=3  2x3=6 
             */

            #endregion

            #region Kullanıcının girmiş olduğu sayının asal olup olmadığını ekrana yazdıran döngü.

            //Asal Sayı:1 ve kendisinden başka sayıya tam bölünmeyen sayılara ASAL SAYI denir.
            //En küçük asal sayı:2
            //2,3,5,7,11,13,...


            //Console.WriteLine("Sayı giriniz:");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //if (sayi < 2)
            //{
            //    Console.WriteLine("Asal Değildir");
            //}

            //else if (sayi == 2)
            //{
            //    Console.WriteLine("Asaldır");
            //}
            //else
            //{
            //    bool asalMi = true;
            //    for (int i = 2; i < sayi; i++)
            //    {
            //        if (sayi % i == 0)
            //        {
            //            asalMi = false;
            //            break;
            //        }
            //    }

            //    if (asalMi)
            //    {
            //        Console.WriteLine("Asaldır");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Asal Değildir.");
            //    }
            //}



            #endregion

            #region 1 ile 1000000 arasındaki asal sayıları ekrana yazdıran döngü.
            #endregion
            #endregion
        }
    }
}
