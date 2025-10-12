namespace _02_Degiskenler_VeriTipleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            #region VERİ TİPLERİ

            /*
             ********* VERİ TİPLERİ (DATA TYPES) *********
            Sayısal Tipler:
                Tam Sayı Tipleri(INTEGER) : sbyte,byte,short,ushort,int,uint,long,ulong
                    short yas = 34;
                    int sayi = 121342331;
                    long sayi2 = 12345678909;

            Ondalıklı Sayı Tipleri(FLOAT): float,double
            DECIMAL : decimal
               //Değer atama işleminde = sağ ve sol tarafını karşılaştırır.

                    // = 150.50 tanım double bir ondalıklı sayıdır eğer float tipde bir değişkene atanacak ise sonuna 'F' konularak değerin float olduğu belirtilmelidir.
                    float bakiye = 150.50f;
                    double bakiye1 = 150.55;

            Console.WriteLine(bakiye+bakiye1);


            decimal sayi = 13242342432423;
            // = 150.50 tanım double bir ondalıklı sayıdır eğer decimal tipde bir değişkene atanacak ise sonuna 'M' konularak değerin decimal olduğu belirtilmelidir.
            decimal sayi2 = 150.50M;

            Sözel Tipler(STRING):
                char: Tek bir karakter ' tek tırnak ile tanımlanır.
                string: Ram bellek boyutunda karakter alır ve " çift tırnak ile tanımlanır.
                       //string bir değer '+' operatorü yardımıyla sayısal bir değer ile yanyana yazılırsa birleştirme(Concat) işlemi yapar. 
                       //string bir değer '+' operatorü yardımıyla string bir değer ile yanyana     yazılırsa birleştirme(Concat) işlemi yaar. 
                       //string rakam2 = "12";
                       //Console.WriteLine(12+rakam2);

                        //string ad = "Altan";
                        //string soyad = "Emre";
                        //Console.WriteLine(ad+" "+soyad);
            Mantıksal Tipler(BOOLEAN):
                bool: Sadece TRUE ve FALSE değerleri alır.
             */


            //bool cevap = true;
            //bool cevap2 = false;

            //bool sonuc = 5 > 3;

            #endregion


            #region KAPSAM - SCOPE
            //int b = 10;
            //{
            //    int a = 5;
            //    b = 15;
            //    Console.WriteLine(b); //15
            //}
            //{
            //    Console.WriteLine(b); // 15
            //}







            //{
            //    int a;
            //    {
            //        int b;
            //    }

            //    a = 20;
            //    b = 10;
            //}


            #endregion


            // CONSTANT - Sabit değişken: Tanımlandıktan sonra revizeye kapalı.

            const int sayi = 5;
            //sayi = 19;


            decimal sayi = 21.5m;


        }
    }
}
