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

        static int Toplama()
        {
            Console.WriteLine("1.Sayı:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayı:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            return sayi1 + sayi2;

        }


        static void Indirim2()
        {
            Console.WriteLine("1.Ürün Fiyatı:");
            double f1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2.Ürün Fiyatı:");
            double f2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("3.Ürün ister misiniz?(E/H)");
            string cevap = Console.ReadLine().ToUpper();

            if (cevap == "H")
            {
                if (f1 > f2)
                {
                    f1 = f1 * 0.7;
                }
                else
                {
                    f2 = f2 * 0.7;
                }
                Console.WriteLine("Ödeme:"+(f1+f2));
            }
            else
            {
                if (f1 > f2)
                {
                    f1 = f1 * 0.7;
                }
                else
                {
                    f2 = f2 * 0.7;
                }

                double f3 = Indirim3();
                Console.WriteLine("Ödeme:" + (f1 + f2 + f3));
            }
        }

        static double Indirim3()
        {
            Console.WriteLine("3.Ürün Fiyatı:");
            double f3 = Convert.ToDouble(Console.ReadLine());

            return f3 / 2;
        }


        #endregion
        #endregion
    }
}
