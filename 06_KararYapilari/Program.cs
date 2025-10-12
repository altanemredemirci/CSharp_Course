using System.Threading.Channels;

namespace _06_KararYapilari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region KARAR YAPILAR 
            /*
             IF ELSE
             SWITCH CASE

            Birden fazla koşul olması durumunda ilk koşul if bloğu ile kontrol edilir, alternatif her koşul için else if bloğu kullanılır.
            Koşullar dışında kalan her durum için else bloğu kullanılır. 
                ** Geri kalan her durum else bloğu ile kontrol edilir bu sebeple KOŞUL TANIMLANMAZ.

             */

            #region Örnek 1: Girilen sayının pozitif, negatif veya nötr olduğunu bulan program

            /*
            1-başla
            2-sayi=sayı giriniz
            3-Eğer sayi>0 ise Ekrana "Pozitif" yaz
            4-Değilse Eğer sayi==0 ise Ekrana "Nötr" yaz
            5-Değilse Ekrana "Negatif" yaz
            6-Bitti
            //  */
            //Console.WriteLine("Sayı giriniz:");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //if (sayi > 0)
            //{
            //    Console.WriteLine("Pozitif");
            //}
            //else if (sayi == 0)
            //{
            //    Console.WriteLine("Nötr");
            //}
            //else 
            //{
            //    Console.WriteLine("Negatif");
            //}
            #endregion

            #region Kullanıcı yaşı 18 den büyük ise "Yetişkin" bilgisi ekrana yazdırılsın

            //Console.WriteLine("Yaş:");
            //int yas = Convert.ToInt32(Console.ReadLine());

            //if (yas > 18) 
            //{
            //    Console.WriteLine("Yetişkin");
            //}
            #endregion


            #region Kullanıcıya haftanın kaçıncı günü olduğunu soralım ve girilen rakama göre gün adını ekrana yazdıralım.

            //Console.WriteLine("Haftanın kaçıncı günündeyiz?");
            //int gun = Convert.ToInt32(Console.ReadLine());

            //if (gun == 1)
            //{
            //    Console.WriteLine("Pazartesi");
            //}
            //else if (gun == 2)
            //{
            //    Console.WriteLine("Salı");
            //}
            //else if (gun == 3)
            //{
            //    Console.WriteLine("Çarşamba");
            //}
            //else if (gun == 4)
            //{
            //    Console.WriteLine("Perşembe");
            //}
            //else if (gun == 5)
            //{
            //    Console.WriteLine("Cuma");
            //}
            //else if (gun == 6)
            //{
            //    Console.WriteLine("Cumartesi");
            //}
            //else if (gun == 7)
            //{
            //    Console.WriteLine("Pazar");
            //}

            //else
            //{
            //    Console.WriteLine("Hata! Hafta 7 günden oluşur.");
            //}



            //if(gun<1 || gun > 7)
            //{
            //    Console.WriteLine("Hata! Hafta 7 günden oluşur.");
            //}
            //else
            //{
            //    if (gun == 1)
            //    {
            //        Console.WriteLine("Pazartesi");
            //    }
            //    else if (gun == 2)
            //    {
            //        Console.WriteLine("Salı");
            //    }
            //    else if (gun == 3)
            //    {
            //        Console.WriteLine("Çarşamba");
            //    }
            //    else if (gun == 4)
            //    {
            //        Console.WriteLine("Perşembe");
            //    }
            //    else if (gun == 5)
            //    {
            //        Console.WriteLine("Cuma");
            //    }
            //    else if (gun == 6)
            //    {
            //        Console.WriteLine("Cumartesi");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Pazar");
            //    }
            //}



            #endregion





            #region Kullanıcıdan bir sayı alınız. Alınan sayının 1-10, 11-20, 21-30 veya üzerinde olduğunu ekrana yazdırınız.

            //Console.WriteLine("Sayı:");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //if(sayi>=1 && sayi < 11)
            //{
            //    Console.WriteLine("1-10 aralığında");
            //}
            //else if(sayi>10 && sayi <= 20)
            //{
            //    Console.WriteLine("11-20 aralığında");
            //}
            //else if (sayi > 20 && sayi <= 30)
            //{
            //    Console.WriteLine("21-30 aralığında");
            //}
            //else
            //{
            //    Console.WriteLine("Büyük sayıdır.");
            //}
            #endregion

            #region Kullanıcıdan iki ürün fiyatı isteyin, ürün fiyat toplamları 2500 tl geçerse ucuz ürüne  % 25 indirim uygulayınız

            //Console.WriteLine("1.Ürün Fiyatı:");
            //double fiyat1 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("2.Ürün Fiyatı:");
            //double fiyat2 = Convert.ToDouble(Console.ReadLine());


            //double toplam = fiyat1 + fiyat2;

            //if (toplam > 2500)
            //{
            //    if (fiyat1 > fiyat2)
            //    {
            //        fiyat2 = fiyat2 * 0.75;
            //    }
            //    else
            //    {
            //        fiyat1 = fiyat1 * 0.75;
            //    }
            //}

            //Console.WriteLine("Toplam Ödeme:"+(fiyat1+fiyat2));

            #endregion

            #region Aylık geliri 40000 üstünde ise %12 vergi kesilecek,
            //40000 ve altında ise %9 vergi kesintisi yapılarak
            //Kullanıcıya yeni aylık gelirini yazdırınız.

            //Console.WriteLine("Aylık Geliriniz:");
            //double gelir = Convert.ToDouble(Console.ReadLine());

            //if (gelir > 40000)
            //{
            //    gelir = gelir * 0.88; //gelir - (gelir*12/100)
            //}
            //else
            //{
            //    gelir = gelir * 0.91;
            //}

            //Console.WriteLine("Vergisiz geliriniz:"+gelir);
            #endregion
            #endregion

            #region GOTO KOMUTU

            //Goto komutu kendisine verilen etiketin olduğu yere programı geri taşır

            //DON:
            //Console.WriteLine("Sayı giriniz:");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //goto DON;

            //    string sifre = "123";
            //    int hak = 3;

            //TEKRAR:
            //    Console.WriteLine("Password:");
            //    string pass = Console.ReadLine();
            //    hak--;

            //    if (pass == sifre)
            //    {
            //        Console.WriteLine("Tebrikler! Giriş Başarılı");
            //    }

            //    else if(hak>0)
            //    {
            //        Console.WriteLine("Hata! Lütfen giriş bilgilerinizi kontrol ediniz");
            //        goto TEKRAR;
            //    }

            #endregion

            #region SWITCH CASE
            //Switch Case yapısı birden fazla koşulun olduğu durumlarda kullanılır.

            #region Kullanıcıya haftanın kaçıncı günü olduğunu soralım ve girilen rakama göre gün adını ekrana yazdıralım.

            //Console.WriteLine("Haftanın kaçıncı günündeyiz?");
            //int gun = Convert.ToInt32(Console.ReadLine());

            //switch (gun) // ==
            //{
            //    case 1:
            //        Console.WriteLine("Pazartesi");
            //        break;
            //    case 2:
            //        Console.WriteLine("Salı");
            //        break;
            //    case 3:
            //        Console.WriteLine("Çarşamba");
            //        break;
            //    case 4:
            //        Console.WriteLine("Perşembe");
            //        break;
            //    case 5:
            //        Console.WriteLine("Cuma");
            //        break;
            //    case 6:
            //        Console.WriteLine("Cumartesi");
            //        break;
            //    case 7:
            //        Console.WriteLine("Pazar");
            //        break;

            //    default: //else
            //        Console.WriteLine("Hafta 7 günden oluşur.!!!");
            //        break;
            //}


            #endregion
            #region Klavyeden iki sayı, bir işlem(+,-,*,/) girilecek. Sayılar girilen işleme göre sonucu ekrana yazdıran switch case.

            //Console.WriteLine("1.Sayı:");
            //double s1 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("2.Sayı:");
            //double s2 = Convert.ToDouble(Console.ReadLine());


            //Console.WriteLine("İşlem(+,-,*,/):");
            //string islem = Console.ReadLine();

            //switch (islem)
            //{
            //    case "+":
            //        Console.WriteLine(s1+s2);
            //        break;
            //    case "-":
            //        Console.WriteLine(s1 - s2);
            //        break;
            //    case "*":
            //        Console.WriteLine(s1 * s2);
            //        break;
            //    case "/":
            //        Console.WriteLine(s1 / s2);
            //        break;
            //    default:
            //        Console.WriteLine("Hatalı İşlem!!");
            //        break;
            //}


            #endregion
            #region   
            /*
            kullanıcıdan alınan cinsiyet bilgisine göre
            ==> ERKEK ise
            yaşı 60 ve üstü ise maaşının 10 katı kadar ikramiye alaral emekli edilecek, yaş 60'ın altında ise çalıştığı gün sayısına göre eğer 6000 ve üstü ise maaşının 11 katı kadar ikramiye alarak emekli edilecek,    6000 altında ise emekli edilmeyecek bilgisi kullanıcıya gösterilecek
            ==> KADIN ise
             yaşı 58 ve üstü ise maaşının 10 katı kadar ikramiye alarak emekli edilecek, yaş 58'ın altında ise çalıştığı gün sayısına göre eğer 3600 ve üstü ise maaşının 11 katı kadar ikramiye alarak emekli edilecek, 3600 altında ise emekli edilmeyecek bilgisi kullanıcıya gösterilecek
            ==> cinsiyet bilgisi switch-case ile sorgulanacak
             */


            Console.WriteLine("Cinsiyet:");
            string cinsiyet = Console.ReadLine().ToUpper();

            switch (cinsiyet)
            {
                case "ERKEK":
                    Console.WriteLine("Yaşınız:");
                    int yas = Convert.ToInt32(Console.ReadLine());

                    if (yas >= 60)
                    {
                        Console.WriteLine("Maaş:");
                        int maas = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("İkramiye:"+(maas*10));
                    }
                    else
                    {
                        Console.WriteLine("Prim Günü:");
                        int prim = Convert.ToInt32(Console.ReadLine());

                        if (prim >= 6000)
                        {
                            Console.WriteLine("Maaş:");
                            int maas = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("İkramiye:" + (maas * 11));
                        }
                        else
                        {
                            Console.WriteLine("Çalışmaya Devam..");
                        }
                    }
                        break;

                case "KADIN":
                    Console.WriteLine("Yaşınız:");
                    int yas2 = Convert.ToInt32(Console.ReadLine());

                    if (yas2 >= 58)
                    {
                        Console.WriteLine("Maaş:");
                        int maas = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("İkramiye:" + (maas * 10));
                    }
                    else
                    {
                        Console.WriteLine("Prim Günü:");
                        int prim = Convert.ToInt32(Console.ReadLine());

                        if (prim >= 3600)
                        {
                            Console.WriteLine("Maaş:");
                            int maas = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("İkramiye:" + (maas * 11));
                        }
                        else
                        {
                            Console.WriteLine("Çalışmaya Devam..");
                        }
                    }
                    break;
            }



            #endregion
            #endregion

        }
    }
}
