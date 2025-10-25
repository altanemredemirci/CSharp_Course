namespace _09_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            *****  ARRAYS - DİZİLER  *****
            * Değişkenler tek bir veri tutarken, diziler birden fazla veri tutabilen koleksiyon tipidir.
            * Index adı verilen numaralandırma yöntemi ile verileri sıralı şekilde tutarlar. Bu sayede çok veri içinden istenilene INDEX numarası ile ulaşılabilir.
            * Index numaraları default olarak 0 dan başlar ve 1'er 1'er artarak devam eder.
            * Diziler kendilerine ait metotlara sahiptirler.
            * Dizi tanımlanırken tutacağı elemanların veri tipi ve kaç eleman tutacağını belirtmek zorunludur.
            * Tek veri tipinde verilen uzunluk kadar eleman tutarlar.                         
            */

            //int sayi = 5;

            #region Diziye Eleman Ekleme
            ////Boş bir Dizi tanımı
            //string[] isimler = new string[5]; //veri tipi ve eleman sayısı belirtilmelidir.



            //isimler[0] = "Altan";
            //isimler[2] = "Ali";
            //isimler[1] = "Buse";


            ////Dolu bir Dizi tanımı
            //int[] sayilar = { 1, 2, 3, 4 }; 
            #endregion


            #region DİZİ OKUMA
            string[] isimler = new string[5];

            isimler[0] = "Altan";
            isimler[2] = "Ali";
            isimler[1] = "Buse";
            isimler[3] = "Muhammed";
            isimler[4] = "Enes";


            ////Console.WriteLine(isimler[1]);

            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    Console.WriteLine(isimler[i]);
            //}

            //int x = 0;
            //while (x < isimler.Length) 
            //{
            //    Console.WriteLine(isimler[x]);
            //    x++;
            //}

            //foreach (string isim in isimler) //string isim="Buse"
            //{
            //    Console.WriteLine(isim);
            //}
            #endregion

            #region Kullanıcıya kaç personeli olduğunu sorunuz. Verilen cevapdan sonra her personelin adını sorup bir diziye ekleyiniz. Dizi tamamlandığında personel isimlerini ekrana yazdırınız.

            //Console.WriteLine("Kaç personeliniz var?");
            //int personelSayisi = Convert.ToInt32(Console.ReadLine());

            //string[] personeller = new string[personelSayisi];

            //for (int i = 0; i < personelSayisi; i++)
            //{
            //    Console.WriteLine("Personel Adı:");
            //    string ad = Console.ReadLine();

            //    personeller[i] = ad;
            //}


            //for (int i = 0; i < personeller.Length; i++)
            //{
            //    Console.WriteLine(personeller[i]);
            //}

            #endregion

            #region ARRAY SINIFININ METOTLARI

            #region Clear()
            // Tanımlı elemanları siler
            //int[] sayilar = { 11, 22, 33, 44, 55 };

            ////Array.Clear(sayilar);
            //Array.Clear(sayilar, 1, 2);
            ////for (int i = 0; i < sayilar.Length; i++)
            ////{
            ////    Console.WriteLine(sayilar[i]);
            ////}

            //foreach (int sayi in sayilar) 
            //{ 
            //    Console.WriteLine(sayi); 
            //}



            #endregion

            #region Copy()
            // Belirli bir koleksiyondan bir diğer koleksiyona istenilen elemanları KOPYALAR.

            //int[] sayilar = { 11, 22, 33, 44 };

            //int[] sayilar2 = new int[5];

            ////Array.Copy(sayilar, sayilar2, 2);

            //Array.Copy(sayilar, 2, sayilar2, 1, 2);


            //foreach (int item in sayilar2)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region IndexOf()
            // Aranacak değerin ilk görüldüğü index numarasını verir.

            //string[] adlar = { "Mehmet", "Ercan", "Bahir", "Arhan", "Bahir", "Koray", "Altan", "Fatma","Bahir" };

            //int index = Array.IndexOf(adlar, "Bahir",3);
            //Console.WriteLine(index);

            #endregion

            #region LastIndexOf()
            // Aranacak değerin son görüldüğü index numarasını verir.

            //string[] adlar = { "Mehmet", "Ercan", "Bahir", "Arhan", "Bahir", "Koray", "Altan", "Fatma", "Bahir" };

            //int index = Array.LastIndexOf(adlar, "Bahir");
            //Console.WriteLine(index);

            #endregion

            #region Sort()
            //// Dizinin elemanlarını 0->9 A->Z ye sıralar.
            //int[] sayilar = { 11, 2, 54, 3, 4, 4, 1, 34, 23, 14 };

            //string[] ogrenciler = { "Safiye", "Nil", "Altan", "Eymen", "Bekir", "Altay", "Rümeysa", "Berat", };


            //Array.Sort(ogrenciler);

            //foreach (string item in ogrenciler)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Resize()
            //Dizinin boyutunu(kapasite) yeniden biçimlendirmeye yarar.

            //int[] sayilar = new int[3];

            //sayilar[0] = 11;
            //sayilar[1] = 12;
            //sayilar[2] = 13;

            //Array.Resize(ref sayilar, 4);
            //sayilar[3] = 14;

            //foreach (int item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion

            #region İSTANBUL kelimesinin harflerini alt alta ekrana yazdırınız.

            //string sehir = "İSTANBUL";

            //for (int i = 0; i < sehir.Length; i++)
            //{
            //    Console.WriteLine(sehir[i]);
            //}


            #endregion

            #region Bir dizinin eleman sayısı 10 ile 20 arasında olacak şekilde sistem tarafında otomatik atılmaktadır.
            //Bu dizinin elemanlarını da sistem 0,100 arasında otomatik atmaktadır.
            //Otomatik oluşturulan bu dizinin eleman sayısını ve elemanlarını kullanıcıya gösteriniz
            //Aynı sayılar tekrar atanmayacak
            //Dizideki en büyük ve en küçük sayılar sort() kullanılmadan bulup ekrana yazdırılacak 
            #endregion

            Random r = new Random();

            int uzunluk = r.Next(10, 20);

            int[] sayilar = new int[uzunluk]; //10

            int i = 0;
            while (i < uzunluk) 
            { 
                int sayi= r.Next(0, 100);

                if (sayilar.Contains(sayi)==false)
                {
                    sayilar[i] = sayi;
                    i++;
                }
               
            }

            int enKucuk = sayilar[0];
            int enBuyuk = sayilar[0];
            foreach (int item in sayilar)
            {
                if (item > enBuyuk)
                {
                    enBuyuk = item;
                }
                if (item < enKucuk)
                {
                    enKucuk = item;
                }

                Console.WriteLine(item);
            }

            Console.WriteLine("En Küçük:"+enKucuk);
            Console.WriteLine("En Büyük:"+enBuyuk);
        }
    }
}
