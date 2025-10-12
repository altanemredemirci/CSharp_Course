namespace _03_TurDonusumleri_Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region TÜR DÖNÜŞÜMLERİ

            /*
             Kullanıcıdan bir data almak için Console.ReadLine() komutu kullanılır.
             Kullanıcıya bilgi vermek(konsole mesaj yazmak) için Console.WriteLine() komutu kullanılır.

             */
            //int yas1 = 35;
            //int yas2 = 15;
            //int toplam = yas1 + yas2;

            //Console.WriteLine(yas1);
            //Console.WriteLine(yas2);
            //Console.WriteLine(yas1+yas2);
            //Console.WriteLine(toplam);

            #region Kullanıcıdan adı ve soyadını alınız. Ekrana Ad ve Soyadı yazdırınız.

            //Console.WriteLine("Adınız:"); //Kullanıcıya mesaj verdik.
            //string ad = Console.ReadLine();

            //Console.WriteLine("Soyad:");
            //string soyad = Console.ReadLine();

            //Console.WriteLine(ad + " " + soyad);

            #endregion

            #region İki kardeşim yaşları toplamı
            /*
            1-Başla
            2-yas1=birinci kardeşin yaşı
            3-yas2=ikinci kardeşin yaşı
            4-toplam=yas1+yas2
            5-Ekrana Yaz(toplam)


            1-başla
            2-"1.kardeşin yaşı:"
            3-string yas1 = console oku
            4-yas1 int çevir            

            */

            //Console.WriteLine("1.Kardeşin Yaşı:");
            //int yas1 = Convert.ToInt32(Console.ReadLine());

            ////Console.WriteLine(yas2+5);

            //////int y1 = Convert.ToInt32(yas1); //yas1 değişkenindeki değeri sayısal veri tipine çevirmek


            //Console.WriteLine("2.Kardeşin Yaşı:");
            //int yas2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(yas1 + yas2);

            #endregion

            #region Kullanıcıdan alınan vize ve final notları üzerinden ortalamayı hesaplayarak ekrana yazdırınız.

            //Console.WriteLine("Vize notunuzu giriniz: ");
            //double vize = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Final notunuzu giriniz: ");
            //double final = Convert.ToDouble(Console.ReadLine());

            //double ortalama = (vize * 0.4) + (final * 0.6);
            //Console.WriteLine("Ortalama: " + ortalama);

            #endregion


            #region Tür Dönüşümü

            //string sayi = "566734676378463";
            //int s1 = Convert.ToInt32(sayi);
            //int sayi1 = int.Parse(sayi); // Convert komutunun alternatifi

            #endregion

            // *************** TÜR DÖNÜŞÜMLERİ - VERİ TİPİ DÖNÜŞÜMÜ ***************

            #region Bilinçli Tür Dönüşümü

            //*Sözel-Sayısal tipe dönüşüm
            //Console.WriteLine("Yaş:");
            //int yas = Convert.ToInt32(Console.ReadLine());

            //*Sayısal-Sözel tipe dönüşümü
            //int sayi = 12312;
            //string sayi2 = Convert.ToString(sayi);
            //string sayi3 = sayi.ToString(); //*** bu format çok popülerdir.

            #endregion


            #region Bilinçsiz Tür Dönüşümü

            //Küçük veri tipini Büyük veri tipine atama
            //int sayi = 10;
            //double sayi2 = sayi;

            //** BOXING()
            //Büyük veri tipini Küçük veri tipine atama
            //double sayi = 5;
            //int sayi2 = (int)sayi;


            //double sayi = 573654273654736;
            //long sayi2 = (long)sayi;

            //Console.WriteLine(sayi2);

            #endregion


            #region SCOPE
            //her tanım kendi {} içerisinde erişilebilir.
            //string tv = "LG";

            //{
            //    int sayi = 5;
            //    Console.WriteLine(tv);
            //}

            //{
            //    Console.WriteLine(sayi); //sayi tanımı farklı bir scope bulunduğu için erişilmezdir. 
            //    Console.WriteLine(tv);
            //}





            //string ad = "Altan";

            //{
            //    int sayi = 5;
            //    Console.WriteLine(ad);
            //}

            //Console.WriteLine(ad);

            //{
            //    Console.WriteLine(ad);
            //    int sayi2 = 10;

            //    {
            //        Console.WriteLine(ad);
            //        Console.WriteLine(sa);
            //    }
            //}




            #endregion


            #region CONSTANT

            //const: sabit değişken

            //int sayi = 5;
            //int sayi = 15; //Hata: Aynı sisimde bir tanımlama yapıldı.

            //sayi = 15; //sayi değişkenin değeri revize edildi.

            //int sayi2 = 10; // Farklı bir değeri tutmak için değişken tanımlandı.


            //const int sayi = 10;
            //sayi = 15;
            #endregion

            //Console.WriteLine("Hello World");

            //Console.WriteLine("klsmdmadsmdsd");

            #endregion

            #region OPERATÖRLER

            #region *** MATEMATİKSEL OPERATÖRLER (+,-,*,/,%)
            //int sayi = 5;
            //int sayi2 = 12;

            ////Mod Alma(%)

            //Console.WriteLine(sayi2 % sayi);


            //Bölme işleminde, işleme uğrayan sayılardan biri dahi ondalıklı ise sonuç ondalıklı ama her iki sayıda int ise sonuç TAM SAYI çıkar.
            //double sayi = 12;
            //int sayi2 = 5;

            //int sonuc = (int)(sayi / sayi2);

            //Console.WriteLine("Sonuç:"+sonuc);
            #endregion

            //int sayi = 12;
            //double sayi2 = 5;

            //int sonuc = (int)(sayi / sayi2);

            ////Console.WriteLine(sayi/sayi2);
            //Console.WriteLine(sonuc);


            #region  *** ATAMA(=) ve İŞLEMLİ ATAMA OPERATÖRLERİ ***
            //int sayi = 5;

            //sayi +=1;  //sayi = sayi + 1;
            //sayi -=1;  //sayi = sayi - 1;
            //sayi *=2;  //sayi = sayi * 2;
            //sayi /=2;  //sayi = sayi / 2;

            //BİR ARTTIRMA, BİR AZALTMA

            //int sayi = 5;
            //sayi++;  //sayi += 1;   //sayi = sayi + 1;
            //Console.WriteLine(sayi);

            //sayi--;  //sayi -= 1;   //sayi = sayi - 1;
            //Console.WriteLine(sayi);

            //Örnek:
            //int a = 5;
            //int b = a++; //a değerini b ye ata sonra a değerini 1 arttır.
            //int c = ++a; //a değerini 1 arttır sonra a değerini c ye ata.
            //int d = b + c;
            //double e = d / a;

            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //Console.WriteLine(d);
            //Console.WriteLine(e);
            #endregion

            #region *** KARŞILAŞTIRMA OPERATÖRLERİ ***

            //int sayi = 5;
            //int sayi2 = 6;

            //bool sonuc = sayi > sayi2;
            //bool sonuc2 = sayi < sayi2;
            //bool sonuc3 = sayi >= sayi2;
            //bool sonuc4 = sayi <= sayi2;
            //bool sonuc5 = sayi == sayi2; // sayi ile sayi2 eşit mi?
            //bool sonuc6 = sayi != sayi2; // sayi ile sayi2 eşit değil mi?

            //Console.WriteLine("Sonuç:" + sonuc);
            //Console.WriteLine($"Sonuç:{sonuc2}");
            //Console.WriteLine("Sonuç:{0}", sonuc3);
            //Console.WriteLine("Sonuç:" + sonuc4);
            //Console.WriteLine("Sonuç:" + sonuc5);
            //Console.WriteLine("Sonuç:" + sonuc6);
            #endregion

            #region *** KIYAS OPERATÖRÜ(?:) *** 
            // ? kıyas durumu TRUE ise atanacak değer 
            // : kıyas durumu FALSE ise atanacak değer
            //int sayi = 5;

            //string sonuc = 5 > 6 ? "Büyüktür" : "Küçüktür";
            //int sonuc2 = 5 > 6 ? 1 : 0;


            //Sayı 10'dan büyükse "SAYI 10'DAN BÜYÜKTÜR." yazsın. Değilse "SAYI 10'DAN KÜÇÜKTÜR."
            //int sayi = 6;
            ////bool sonuc = sayi > 10;

            //string sonuc = sayi > 10 ? "SAYI 10'DAN BÜYÜKTÜR." : "SAYI 10'DAN KÜÇÜKTÜR.";

            //Console.WriteLine(sonuc);




            #endregion

            #region *** ERİŞİM OPERATÖRÜ(.) ***

            //Console.WriteLine();

            //Console.ReadLine().ToString()

            #endregion

            #region *** MANTIKSAL OPERATÖRLERİ ***
            // 3 farklı operatör vardır. 
            // * && : AND operatörü. Birden fazla karşılaştırma işlemi yapılıyor ve sonucun TRUE olması için bütün karşılaştırmaların true olma şartı varsa kullanılır.

            //string username = "altanemre";
            //string password = "1";


            //Console.WriteLine("Kullanıcı Adı:");
            //string kullaniciAdi = Console.ReadLine();

            //Console.WriteLine("Şifre:");
            //string sifre = Console.ReadLine();

            //bool sonuc = kullaniciAdi == username && sifre == password;

            //string cevap = sonuc == true ? "Giriş Başarılı" : "Kullanıcı adı veya şifre hatalı!";

            //Console.WriteLine(cevap);

            // AND - &&
            //// Bir işlemin başarılı(true) olması için her şartın sağlanması gerekiyor ise && kullanılır.

            //string username = "muhammed";
            //string password = "1";

            //Console.WriteLine("Kullanıcı Adınız:");
            //string kullaniciAdi = Console.ReadLine();

            //Console.WriteLine("Şifreniz:");
            //string pass = Console.ReadLine();

            ////Oturum açma işleminin sağlnması için hem kullanıcıadı hemde şifresi uyuşmalıdır.

            //bool girisDurumu = username == kullaniciAdi && password==pass;

            //Console.WriteLine(girisDurumu);

            /* Çarpma işlemi mantığı ile çalışır.
             1  2   Sonuc
             0  0   0
             0  1   0
             1  0   0
             1  1   1 
             */



            // OR - ||
            //// Bir işlemin başarılı(true) olması için şartlardan herhangi birinin sağlanması gerekiyor ise || kullanılır.

            //string username = "muhammed";
            //string email = "altanemre@gmail.com";
            //string password = "1";

            //Console.WriteLine("Kullanıcı Adı/Email:");
            //string kullanici = Console.ReadLine();


            //Console.WriteLine("Şifreniz:");
            //string pass = Console.ReadLine();

            ////////Oturum açma işleminin sağlanması için (kullanıcıadı veya email'in uyuşması) ve şifrenin uyuşması gereklidir.

            //bool girisDurumu = (username == kullanici || email == kullanici) && pass == password;

            //Console.WriteLine(girisDurumu);

            /* Toplama işlemi mantığı ile çalışır.
             1  2   Sonuc
             0  0   0
             0  1   1
             1  0   1
             1  1   1 
             */



            // NOT - !


            #endregion

            #region Kullanıcıdan yaş, mezuniyet ve Cinsiyet bilgilerini alınız.  
            //Ehliyet alma koşulu: Yaş 18 den büyük ve mezuniyet Lise olamalı. veya cinsiyet erkek olmalı. 

            //Console.WriteLine("Yaşınız:");
            //int yas = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Mezuniyet:");
            //string mezuniyet = Console.ReadLine();

            //Console.WriteLine("Cinsiyet:");
            //string cinsiyet = Console.ReadLine();

            //string cevap = yas > 18 && (mezuniyet == "Lise" || cinsiyet == "Erkek") ? "Ehliyet alabilirsiniz." : "Ehliyet alamazsınız.";


            //Console.WriteLine("Cevap:"+cevap);


            #endregion


            #region Kullanıcıdan bir sayı alın ve bu sayının tek mi çift mi olduğunu kontrol edin. Sonucu ekrana yazdırın.

            //Console.WriteLine("Sayı giriniz:");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //string cevap = sayi % 2 == 0 ? "Çift" : "Tek";

            //Console.WriteLine(cevap);

            #endregion

            #endregion





        }
    }
}
