using System.Collections;

namespace _11_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array: veri tipi ve uzunluk tanımlanmalı.
            //int[] sayilar = new int[10];
            //string[] sehirler = { "İstanbul", "Ankara" };

            //ArrayList: veri tipi ve uzunluk tanımlanmaz.
            //ArrayList arrayList = new ArrayList();


            ////***Eleman Ekleme
            //arrayList.Add("Altan");
            //arrayList.Add(35);
            //arrayList.Add(45.50);
            //arrayList.Add('K');
            //arrayList.Add(50.5f);
            //arrayList.Add(50.5m);


            //***Index ile Eleman Çağırma
            //Console.WriteLine(arrayList[1]);

            //***ArrayList Elemanlarını Yazdırma
            //var:variable - tipsiz

            //var sayi = "10";
            //int sayi2 = 10;
            //Console.WriteLine(sayi+sayi2);

            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}


            //***Istenilen Index e Eleman Ekleme
            //arrayList.Insert(2, "Emre");

            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            //*** COUNT ve CAPACITY

            //ArrayList sayilar = new ArrayList(){ 11,22,33,44,55,66,77,88,99 };

            //Console.WriteLine("Count:"+sayilar.Count);
            //Console.WriteLine("Capacity:"+sayilar.Capacity);

            //*** CLEAR()

            //ArrayList sayilar = new ArrayList() { 11, 22, 33, 44, 55, 66, 77, 88, 99 };

            //sayilar.Clear(); //Bütün değerleri siler.


            //*** CLONE()
            ArrayList sayilar = new ArrayList() { 11, 22, 33 };

            //ArrayList sayilar2 = sayilar; //Ram adresleri eşitlenir. bu sebeple birine bir işlem yapıldığında diğeride etkilenir.

            /*
            ArrayList sayilar2 = (ArrayList)sayilar.Clone();


            sayilar.Add(44);


            foreach (var item in sayilar)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("********************");
            foreach (var item in sayilar2)
            {
                Console.WriteLine(item);
            }
            */

            //*** ADDRANGE()

            //ArrayList list = new ArrayList() { 1, 2, 3 };
            ////list.Add(4);
            //list.AddRange(new ArrayList() { 4, 5, 6 });

            //ArrayList list2 = new ArrayList() { 7, 8, 9 };

            //list.AddRange(list2);

            #region  Kullanıcıdan aile bireylerinin isimlerini alıp bir ArrayListe atınız ve işlem bittiğimde ekrana yazdırınız

            //Console.WriteLine("Aile Kaç kişidir?");
            //int kisiSayisi = Convert.ToInt32(Console.ReadLine());

            //ArrayList aile = new ArrayList();

            //for (int i = 0; i < kisiSayisi; i++)
            //{
            //    Console.WriteLine("Ad:");
            //    string ad = Console.ReadLine();
            //    aile.Add(ad);
            //}

            //foreach (string item in aile)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
        }
    }
}
