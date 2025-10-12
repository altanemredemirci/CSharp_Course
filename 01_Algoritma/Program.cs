namespace _01_Algoritma
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Compiler(Derleyici):Yazılım aşamasında veya kodu çalıştırdığımız aşamada girilen değerlerin C# komudu olup olmadığını kontrol eder. Visual Studio



            //Framework: Yazılımcılar tarafında geliştirilmiş ve diğer yazılımcılara sunulan kod kütüphanesidir.



            //Mobile App -> React Native
            //Web App -> C# asp.net
            //Games -> Unreal engine
            //ERP -> Python
            //.Net: Farklı proje şablonlarının ortak bir platform üzerinden çalışmasını sağlar.

            //Comment(Yorum) satırı için satır başına // konulur.

            /*
             Çoklu 
                yorum-comment 
                    satırı 
             */

            //DEBUG İŞLEMİ ADIMLARI
            /*
             1-Kod build (derlenir). Yazı hatası var mı?
             2-Kodu çalıştıracak donanıma sahip mi?
             3-Compile -> kodu makinenin anlayacağı hale getirir.
             4-Execute
             5-Result
             */

            //Console.WriteLine("Altan Emre"); 

            /*ALGORİTMA 
            //Belirli bir problemin çözüme giden mantıklı çözüm adımlarıdır.
             * BAŞLANGIÇ - BİTİŞ 
             * SIRALI
             * SONLULUK
             * KESİNLİK
             * MODULER-GENELLEBİLİR
             
             Algoritma Yapılma Amacı 
             * Maliyet tasarrufu
             * Zaman tasarufu
             * Performans yükseltme

            */

            /*EVDE ÇAY DEMLEME 
            1-Başla
            2-Mutfağa Git
            3-Çaydanlığa Su Koy
            4-Ocağı Yak
            5-Çaydanlığı Ocağa Git
            6-Su Kaynadı Mı? T->8 F->7
            7-Bekle 1dk ->6
            8-Demliğe Çay Koy
            9-Çaydanlığa Su Koy
            10-Çay Demlendi Mi? T->12 F->11
            11-Bekle 1dk ->10
            12-Servis Et
            13-Bitti
             
            //Su Yok
            //Çay Yok
            //Bakkal Kapalı


            1-Başla
            2-Mutfağa Git
            3-Su ve Çay Var Mı? T->10 F->4
            4-Bakkala Git
            5-Bakkal Açık Mı? T->7 F->6
            6-Başka Bakkala Git ->5
            7-Eksikleri Al
            8-Eve Dön 
            9-Mutfağa Git
            10-Çaydanlığa Su Koy
            11-Ocağı Yak
            12-Çaydanlığı Ocağa Git
            13-Su Kaynadı Mı? T->15 F->14
            14-Bekle 1dk ->13
            15-Demliğe Çay Koy
            16-Çaydanlığa Su Koy
            17-Çay Demlendi Mi? T->19 F->18
            18-Bekle 1dk ->17
            19-Servis Et
            20-Bitti
             */

            //Ekrana birşey yazma komutu Console.WriteLine()
            //Dışarıdan sayısal değer alma komutu Convert.Toınt32(Console.ReadLine())
            //Sayısal değer tutma int sayi

            //Kullanıcıdan alınan 2 sayının toplamını ekrana yazdıran program?
            /*
            1-Başla
            2-1.sayıyı yaz
            3-2.sayıyı yaz
            4-1.sayi+2.sayi
            5-Toplamı ekrana yaz
            6-Bitti
             */

            //Console.WriteLine("1.sayıyı yaz");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("2.sayıyı yaz");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(sayi1+sayi2);


            //Evden Çıkıp Kursa Gelme Algoritması
            /*
            1-Başla
            2-Asansör Mü Merdiven Mi? A->3 M->10
            3-Asansör Katta Mı? T->5 F->4
            4-Asansör Çağır -> 3
            5-Asansöre Bin
            6-İstenilen Kat Tuşuna Bas
            7-Asansör İstenilen Katta Mı? T->9 F->8
            8-Bekle->7
            9-Asansörden İn
            10-Bir Kat Hareket
            11-İstenilen Katta Mıyız? F->10 T->12
            12-Binadan Çık
            
            13-Akbil Dolu Mu? T->15 F->14
            14-Akbil Doldur
            15-Durağa Git
            16-Toplu Taşıma Geldi Mi? T->18 F->17
            17-Bekle ->16
            18-Toplu Taşımaya Bin
            19-Akbil Bas
            20-Boş Yer Var Mı? T->22 F->21
            21-Ayakta Git ->23
            22-Otur
            23-İstenilen Durağına Geldi Mi? T->25 F->24
            24-Bekle -> 23
            25-Toplu Taşımadan İn
            26-Kuruma Yürü
            27-Bitti
             */

        }
    }
}
