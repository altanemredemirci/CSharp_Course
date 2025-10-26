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

            //Kullanıcıdan 2 sayı bir işlem alan ve alınan sayılara işlemi uygulayarak ekrana gösteren metodu yazınız

            DortIslem();




            #endregion
        }

        //*** METOT TANIMLAMA ***
        static void Toplama()
        {
            Console.WriteLine("1.Sayı:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayı:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Toplam:" + (sayi1 + sayi2));

        }
        static void DortIslem()
        {
            Console.WriteLine("1.Sayı:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayı:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İşlem Seçiminiz(+,-,*,/):");
            string islem = Console.ReadLine();

            if (islem == "+")
            {
                Console.WriteLine(sayi1 + sayi2);
            }
            else if (islem == "-")
            {
                Console.WriteLine(sayi1 - sayi2);
            }
            else if (islem == "*")
            {
                Console.WriteLine(sayi1 * sayi2);
            }
            else if (islem == "/")
            {
                if (sayi2 > sayi1)
                {
                    Console.WriteLine(sayi2 / sayi1);
                }
                else
                {
                    Console.WriteLine(sayi1 / sayi2);
                }
                    
            }
            else
            {
                Console.WriteLine("");
            }
        }
    }
}
