using System.Collections;
using System.Globalization;

namespace _12_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region METOTLAR
            /*
             Belirli bir işlemi gerçekleştiren kod bloğuna bir adlandırma yaparak istenilen yerden tekrar verilen ad ile kodu çağırmamızı ve tekrar yazmaktan bizi kurtaran yazılım yapısıdır.

            Metotlar ikiye ayrılır:
             *Değer Döndürmeyen Metotlar(parametreli,parametresiz)
             *Değer Döndüren Metotlar(parametreli,parametresiz)
            
            

            Metotları () işaretleri tanımlar.

            SOLID prensibleri ilki olan S-Single responsibility principle:Her metodun bir iş yapmasıdır.


            *** KURALLAR ***
            * Metotlar iç içe tanımlanamaz.
            * Aynı class altında metot tanımlanırsa { } kesişmelidir. Kapsam alanları (SCOPE) birbiri içinde olmamalıdır.
            * Metot ismi yapılan işe uygun olmalıdır.
            * Metot isimlendirirken UNIQUE(benzersiz) olmalıdır.
            * Benzer işi yapacak metotlar METOT İMZASI(parametre sayısı veya parametre veri tipi) ile ayrılmalıdır.

            Console.WriteLine();
            Console.ReadLine();
            Convert.ToInt32();
            Random r = new Random();
            ArrayList arrayList = new ArrayList();
             */
            #endregion

            #region DEĞER DÖNDÜRMEYEN METOTLAR

            /*
             Değer döndürmeyen metodu tanımlayan keyword VOID kelimesidir. Bu metotlar tanımlı oldukları işlemleri gerçekleştir ve sonucu dışarıya taşımazlar.
             */


            //Kullanıcıdan iki sayı alınız ve bu iki sayının toplamını ekrana yazdırınız
            //Console.WriteLine("1.Sayı:");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2.Sayı:");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Toplam:"+(sayi1+sayi2));

            //*** METOT ÇAĞIRMA ***

            //Toplama();

            //Console.WriteLine("1.Sayı:");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2.Sayı:");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());


            //** Tanımlanırken metoda verilen parametrelere çağırırken dikkat edilmelidir. Eğer 2 int parametre tanımlandıysa, mutlaka metot kullanılırken bu int tipinde 2 adet değer gönderilmelidir.
            //** Parametre isimlerine uymak zorunlu değildir. Önemli olan veri tipi ve paremetre sayısının aynı olmasıdır.

            //Toplama2(sayi1, sayi2);



            //Kullanıcıdan 2 sayı bir işlem alan ve alınan sayılara işlemi uygulayarak ekrana gösteren metodu yazınız

            //DortIslem();



            //Kullanıcıdan alınacak 2 üründen pahalı olana %30 indirim uygulayan metot

            //Indirim();


            #endregion

            #region DATA ACCESS MODIFIER - Erişim Belirteci
            /*
             public: Tanımlı yapının bütün SOLUTION altında erişilebilir olduğunu tanımlar.
             internal: Tanımlı yapının kendi PROJECT altında erişilebilir olduğunu tanımlar.
             private: Tanımlı yapının sadece kendi CLASS altında erişilebilir olduğunu tanımlar.
             */

            //Static Metot Çağırma
            //Matematik.Toplama();


            //Nonstatic Metot Çağırma
            //Matematik matematik = new Matematik(); //Instance(Örneklem)
            //matematik.Cikarma();


            #endregion

            #region DEĞER DÖNDÜREN METOTLAR

            // // void-değer döndürmeyen metotların aksine bu metotlar return keyword ile bize metodun işlem sonucu geri getirir. Yani metot çağrıldığı yere geri döndüğünde data getirir. Bunun amacı metot sonucunun programın akışında başka bir satırda kullanılmasını sağlamaktır.

            //int sonuc = Toplama();

            #region SORU1: kullanıcıdan alınacak 2 ürün fiyatından pahalı olana %30 indirim uygulayan metot ve 3.ürün almak isterse 3.ürüne %50 indirim uygulayarak metot ile kodlayınız

            //Indirim2();

            #endregion

            #region SORU2: Kullanıcıdan alınan aralıkta, kullanıcının istediği kadar rastgele sayı ile diziyi dolduran değer döndüren metot

            //int[] dizi = Doldur();

            //foreach (int item in dizi)
            //{
            //    Console.WriteLine(item);
            //}




            #endregion
            #region SORU3:Rastgele 1-100 arasında 15 değer tutan bir dizideki tek ve çiftleri ayrı ayrı dizilere atayan metot 

            //int[] sayilar = new int[15];

            //DiziDoldur(sayilar);

            //int[] teksayilar = new int[0];
            //int[] ciftsayilar = new int[0];

            //TekCiftKontrol(sayilar, teksayilar, ciftsayilar);



            #endregion
            #endregion

            #region OVERLOAD METOT
            //Overload metot(aşırı yüklenmiş) Aynı isimde farklı şekilde çalışan metotlara overload metot denir. Metotlar aynı isimde olmaları sebebiyle overload olmaları için metot imzaları farklı olmalıdır.
            //Metot imzası:Parametre sayısı veya parametrenin veri tipi metot imzasını belirler.

            //Toplama();

            //Toplama(11, 12);



            #endregion

            #region DEFAULT DEĞER
            // Parametreye default değer tanımlayarak, değer gönderilmem durumunda alacağı değeri vermiş olduk.
            //Toplama(12, 1);

            //Toplama(3);

            #endregion

            #region PARAMS,OUT,REF
            #region PARAMS
            //Params anahtar kelimesi, bir methoda değişken argümanın aynı tipte geçirilmesine olanak tanır.
            //params parametresi, metodun son parametresi olarak tanımlanmalıdır ve yalnızca bir params anahtar kelimesi kullanılabilir.
            //params ile belirtilen parametre bir dizi olarak işlenir, bu da metod içinde bir dizi erişilebileceği ve üzerinde işlem yapılabileceği anlamına gelir.

            //int[] rakams = { 1, 2, 3 };
            //int[] rakams2 = { 1, 2, 3, 4 };
            //int[] rakams3 = { 1, 2, 3, 4, 5 };

            //DiziYazdir(rakams);
            //DiziYazdir(rakams2);
            //DiziYazdir(rakams3);

            //DiziYazdir2(1, 2, 3, 4,5,6);

            //DiziYazdir3("Altan Emre", 1, 3, 4);


            #endregion

            #region OUT
            //parametre olarak gönderilen değişkenin metot içinde manipüle olmasını sağlar. Bu sayede metot dışarıdan(out) gelen değeri değiştirebilir.
            // ** out kullanılacak değişkene ilk tanımlama da değer atanması zorunlu değildir ama out kullanıldıysa metot içerisinde mutlaka değer atanmalıdır.


            //Console.WriteLine("1.Sayı:");
            //string s = Console.ReadLine(); // "15"
            //int sayi;

            //if (int.TryParse(s, out sayi))
            //{
            //    Console.WriteLine(sayi);
            //}
            //else
            //{

            //}




            //Console.WriteLine("1.Sayı:");
            //string s = Console.ReadLine();
            //int sayi;
            //if (TryPars(s, out sayi)) // //parametre olarak gönderilen değişkenin işlem sonucunda değişmesi için out veya ref keywordleri kullanılmalıdır.
            //{
            //}


            #endregion

            #region REF
            //Out dan farklı olarak ref değerin mutlaka başlangıç değeri olmalıdır.
            //Console.WriteLine("1.Sayı:");
            //string s = Console.ReadLine();
            //int sayi=5;

            //TryPars(s, ref sayi); //parametre olarak gönderilen değişkenin işlem sonucunda değişmesi için out veya ref keywordleri kullanılmalıdır.
            //Console.WriteLine("SAYİ:" + sayi);

            #endregion
            #endregion

            #region //klavyeden girilen değerler arasında rastgele sayı üreten  ve bu değerleri 10 elemanlı bir diziye atayan SayiUret() isimli bir metot yazın.
            //Bu dizinin elemanlarını yazan DiziYazdır() isimli bir metot daha yazarak elemanları listeleyin.
            //Daha sonra bu dizi içerisinde EnBuyukDeger() adında bir metot ile dizinin en büyük değerini bulan,
            //en küçük değerinin bulan EnKucukDeger() adından başka bir metot daha yazınız.
            //EnBuyukDeger ve EnKucukDeger metotlarında dönen değerleri ekranda gösteren programı yazınız
            //kullanıcının bütün hataları kontrol altına alınmalı

            #endregion


        }

        #region*** METOT TANIMLAMA ***
        //static void Toplama()
        //{
        //    Console.WriteLine("1.Sayı:");
        //    int sayi1 = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("2.Sayı:");
        //    int sayi2 = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("Toplam:" + (sayi1 + sayi2));

        //}


        ////Değer Döndürmeyen Parametreli Metot
        //static void Toplama2(int s1,int s2)
        //{
        //    Console.WriteLine("Toplam:"+(s1+s2));
        //}


        ////Değer Döndürmeyen Parametresiz Metot
        //static void DortIslem()
        //{
        //    Console.WriteLine("1.Sayı:");
        //    int sayi1 = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("2.Sayı:");
        //    int sayi2 = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("İşlem Seçiminiz(+,-,*,/):");
        //    string islem = Console.ReadLine();

        //    if (islem == "+")
        //    {
        //        Console.WriteLine(sayi1 + sayi2);
        //    }
        //    else if (islem == "-")
        //    {
        //        Console.WriteLine(sayi1 - sayi2);
        //    }
        //    else if (islem == "*")
        //    {
        //        Console.WriteLine(sayi1 * sayi2);
        //    }
        //    else if (islem == "/")
        //    {
        //        if (sayi2 > sayi1)
        //        {
        //            Console.WriteLine(sayi2 / sayi1);
        //        }
        //        else
        //        {
        //            Console.WriteLine(sayi1 / sayi2);
        //        }

        //    }
        //    else
        //    {
        //        Console.WriteLine("");
        //    }
        //}

        //static void Indirim()
        //{
        //    Console.WriteLine("1.Ürün Fiyatı:");
        //    double f1 = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("2.Ürün Fiyatı:");
        //    double f2 = Convert.ToDouble(Console.ReadLine());

        //    if (f1 > f2)
        //    {
        //        f1 = f1 * 0.7;
        //    }
        //    else
        //    {
        //        f2 = f2 * 0.7;
        //    }

        //    Console.WriteLine("Toplam Ödeme:"+(f1+f2));
        //}
        #endregion

        #region DEĞER DÖNDÜREN METOT TANIMLAMA

        //static int Toplama()
        //{
        //    Console.WriteLine("1.Sayı:");
        //    int sayi1 = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("2.Sayı:");
        //    int sayi2 = Convert.ToInt32(Console.ReadLine());

        //    return sayi1 + sayi2;

        //}


        //static void Indirim2()
        //{
        //    Console.WriteLine("1.Ürün Fiyatı:");
        //    double f1 = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("2.Ürün Fiyatı:");
        //    double f2 = Convert.ToDouble(Console.ReadLine());

        //    Console.WriteLine("3.Ürün ister misiniz?(E/H)");
        //    string cevap = Console.ReadLine().ToUpper();

        //    if (cevap == "H")
        //    {
        //        if (f1 > f2)
        //        {
        //            f1 = f1 * 0.7;
        //        }
        //        else
        //        {
        //            f2 = f2 * 0.7;
        //        }
        //        Console.WriteLine("Ödeme:"+(f1+f2));
        //    }
        //    else
        //    {
        //        if (f1 > f2)
        //        {
        //            f1 = f1 * 0.7;
        //        }
        //        else
        //        {
        //            f2 = f2 * 0.7;
        //        }

        //        double f3 = Indirim3();
        //        Console.WriteLine("Ödeme:" + (f1 + f2 + f3));
        //    }
        //}

        //static double Indirim3()
        //{
        //    Console.WriteLine("3.Ürün Fiyatı:");
        //    double f3 = Convert.ToDouble(Console.ReadLine());

        //    return f3 / 2;
        //}


        //static int[] Doldur()
        //{
        //    Console.WriteLine("Başlangıç Değeri:");
        //    int basla = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Bitiş Değeri:");
        //    int bitis = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("Kaç Adet Sayı:");
        //    int adet = Convert.ToInt32(Console.ReadLine());

        //    int[] sayilar = new int[adet];

        //    Random rnd = new Random();

        //    for (int i = 0; i < adet; i++)
        //    {
        //        sayilar[i] = rnd.Next(basla, bitis);
        //    }

        //    return sayilar;
        //}


        //static int[] DiziDoldur(int[] dizi)
        //{
        //    Random r = new Random();
        //    for (int i = 0; i < 15; i++)
        //    {
        //        dizi[i] = r.Next(1, 100);
        //    }

        //    return dizi;
        //}

        //static void TekCiftKontrol(int[] dizi, int[]tdizi, int[] cdizi)
        //{
        //    foreach (int sayi in dizi)
        //    {
        //        if (sayi % 2 == 0)
        //        {
        //            Array.Resize(ref cdizi, cdizi.Length + 1);
        //            cdizi[^1] = sayi;
        //            //cdizi[cdizi.Length - 1] = sayi;
        //        }
        //        else if (sayi % 2 != 0)
        //        {
        //            Array.Resize(ref tdizi, tdizi.Length + 1);
        //            tdizi[^1] = sayi;
        //        }
        //    }

        //    DiziYaz(tdizi);
        //    Console.WriteLine("**********");
        //    DiziYaz(cdizi);
        //}

        //static void DiziYaz(int[] dizi)
        //{
        //    foreach (int item in dizi)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}

        #endregion

        #region OVERLOAD METOT
        //static void Toplama()
        //{
        //    Console.WriteLine("1.Sayı:");
        //    int sayi1 = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("2.Sayı:");
        //    int sayi2 = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("Toplam:" + (sayi1 + sayi2));
        //}

        //static void Toplama(int sayi1, int sayi2)
        //{
        //    Console.WriteLine("Toplam:" + (sayi1 + sayi2));
        //}

        //static void Toplama(int sayi1, int sayi2, int sayi3)
        //{
        //    Console.WriteLine("Toplam:" + (sayi1 + sayi2 + sayi3));
        //}

        //static void Toplama(int sayi1, double sayi2)
        //{
        //    Console.WriteLine("Toplam:" + (sayi1 + sayi2));
        //}

        static void Toplama(double sayi1, int sayi2)
        {
            Console.WriteLine("Toplam:" + (sayi1 + sayi2));
        }
        #endregion

        #region DEFAULT

        //static void Toplama(int sayi1, int sayi2 = 15)
        //{
        //    Console.WriteLine("Toplama:"+(sayi1+sayi2));
        //}

        #endregion

        #region PARAMS
        static void DiziYazdir(int[] sayilar)
        {
            foreach (int item in sayilar)
            {
                Console.WriteLine(item);
            }
        }

        static void DiziYazdir2(params int[] sayilar)
        {
            foreach (int item in sayilar)
            {
                Console.WriteLine(item);
            }
        }

        static void DiziYazdir3(string ad, params int[] sayilar)
        {
            Console.WriteLine(ad);

            foreach (int item in sayilar)
            {
                Console.WriteLine(item);
            }
        }
        #endregion

        #region OUT

        //static bool TryPars(string s, out int sayi)
        //{
        //    try
        //    {
        //        sayi = Convert.ToInt32(s);
        //        return true;
        //    }
        //    catch
        //    {
        //        sayi = default;
        //        return false;
        //    }
        //}


        #endregion

        #region REF
        static bool TryPars(string s, ref int sayi)
        {
            try
            {
                sayi = Convert.ToInt32(s);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion
    }
}
