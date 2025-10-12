namespace _05_StringMetotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Concat()

            //string ad = "Altan";
            //string soyad = "Demirci";

            //string adSoyad = string.Concat(ad, soyad);

            //Console.WriteLine(adSoyad);
            //Console.WriteLine(ad+soyad);


            #endregion

            #region Length

            //string ad = "Altan";
            //int uzunluk = ad.Length;
            //Console.WriteLine(uzunluk);


            #endregion


            #region Index Of()
            //index numaraları 0'dan başlar ve 1 1 artar. IndexOf ilk bulunduğu index numarasını getirir
            //string ad = "ALTAN EMRE DEMİRCİ";
            //int indexNo = ad.IndexOf("E");
            //Console.WriteLine(indexNo);
            #endregion

            #region Last Index Of()
            ////index numaraları 0'dan başlar ve 1 1 artar. IndexOf son bulunduğu index numarasını getirir
            //string ad = "ALTAN EMRE DEMİRCİ";
            //int indexNo = ad.LastIndexOf("E");
            //Console.WriteLine(indexNo);
            #endregion


            #region StartsWith()
            ////Belirtilen karakterle başlıyor mu?
            //string ad = "ALTAN EMRE DEMİRCİ";
            //bool cevap = ad.StartsWith("ALTA");
            //Console.WriteLine(cevap);
            #endregion

            #region EndsWith()
            ////Belirtilen karakterle bitiyor mu?
            //string ad = "ALTAN EMRE DEMİRCİ";
            //bool cevap = ad.EndsWith("Cİ");
            //Console.WriteLine(cevap);
            #endregion

            #region Trim()
            ////Metnin başındaki ve sonundaki boşlukları silinir.
            //string ad = "     ALTAN EMRE DEMİRCİ      ";
            //ad=ad.Trim();
            //Console.WriteLine(ad);
            #endregion

            #region ToUpper()
            ////Metni büyük harfe çevirir.
            //string ad = "altan emre";
            //ad = ad.ToUpper();
            //Console.WriteLine(ad);
            #endregion

            #region ToLower()
            ////Metni büyük harfe çevirir.
            //string ad = "ALTAN EMRE";
            //ad = ad.ToLower();
            //Console.WriteLine(ad);


            //Console.WriteLine("Mezuniyet:");
            //string mezun = Console.ReadLine().ToUpper();


            //string cevap = mezun=="LİSE" ? ""

            #endregion


            #region Replace()
            ////Metinde karakter değiştirmeye yarar.
            //string ad = "altan emre";
            //ad = ad.Replace("a","o");
            //Console.WriteLine(ad);
            #endregion


            #region Substring()
            ////Metini belirli bir index değerinden bölmeye yarar.
            string ad = "altan emre";
            //ad = ad.Substring(2);
            ad = ad.Substring(2,5);
            Console.WriteLine(ad);
            #endregion

        }
    }
}
