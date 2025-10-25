namespace _10_Otomat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] products = { "Kola", "Fanta", "Ayran" };
            double[] prices = { 50, 45.5, 30 };

            int count = 0;
            double total = 0;

            while (true)
            {
                for (int i = 0; i < products.Length; i++)
                {
                    Console.WriteLine(i + "-" + products[i] + ":" + prices[i]);
                }
                Console.WriteLine("Ürün No:");
                int urunNo = Convert.ToInt32(Console.ReadLine());

                if (urunNo == 100)
                {
                    Console.Clear();
                    Console.WriteLine("1-Ürün Ekle\n2-Ürün Güncelle\n3-Ürün Sil\n4-Ürün Listele\n5-Z Raporu\nSeçiminiz:");
                    int islem = Convert.ToInt32(Console.ReadLine());

                    if (islem == 1)
                    {
                        Console.WriteLine("Ürün Adı:");
                        string urunAd = Console.ReadLine();

                        Console.WriteLine("Ürün Fiyat:");
                        double fiyat = Convert.ToDouble(Console.ReadLine().Replace(".", ","));

                        bool Ekleme = false;
                        for (int i = 0; i < prices.Length; i++)
                        {
                            if (prices[i] == 0)
                            {
                                products[i] = urunAd;
                                prices[i] = fiyat;
                                Ekleme = true;
                                break;
                            }
                        }

                        if (!Ekleme) //(Ekleme == false)
                        {
                            Array.Resize(ref products, products.Length + 1);
                            Array.Resize(ref prices, prices.Length + 1);

                            products[products.Length - 1] = urunAd;
                            prices[prices.Length - 1] = fiyat;
                        }


                    }
                    else if (islem == 2)
                    {
                        for (int i = 0; i < products.Length; i++)
                        {
                            Console.WriteLine(i + "-" + products[i] + ":" + prices[i]);
                        }
                        Console.WriteLine("Güncellenecek urun numarası:");
                        int guncellenecekUrunNo = Convert.ToInt32(Console.ReadLine());

                        if (guncellenecekUrunNo >= 0 && guncellenecekUrunNo < products.Length)
                        {
                            Console.WriteLine("Yeni Ürün Adı:");
                            string urunAd = Console.ReadLine();

                            Console.WriteLine("Yeni Ürün Fiyat:");
                            double fiyat = Convert.ToDouble(Console.ReadLine().Replace(".", ","));

                            products[guncellenecekUrunNo] = urunAd;
                            prices[guncellenecekUrunNo] = fiyat;

                            Console.WriteLine("Ürün Güncellendi.");
                        }
                        else
                        {
                            Console.WriteLine("Ürün Bulunamadı.");
                        }
                    }
                    else if (islem == 3)
                    {
                        for (int i = 0; i < products.Length; i++)
                        {
                            Console.WriteLine(i + "-" + products[i] + ":" + prices[i]);
                        }
                        Console.WriteLine("Silinecek urun numarası:");
                        int silinecekUrunNo = Convert.ToInt32(Console.ReadLine());

                        if (silinecekUrunNo >= 0 && silinecekUrunNo < products.Length)
                        {
                            Array.Clear(products, silinecekUrunNo, 1);
                            Array.Clear(prices, silinecekUrunNo, 1);
                            Console.WriteLine("Ürün Silindi.");

                        }
                        else
                        {
                            Console.WriteLine("Ürün Bulunamadı.");
                        }



                    }
                    else if (islem == 4)
                    {
                        for (int i = 0; i < products.Length; i++)
                        {
                            Console.WriteLine(i + "-" + products[i] + ":" + prices[i]);
                        }
                    }
                    else if (islem == 5)
                    {
                        Console.WriteLine("Satılan Adet:" + count);
                        Console.WriteLine("Kazanç:" + total);
                        count = 0;
                        total = 0;
                    }
                }

                else
                {
                    if (urunNo >= 0 && urunNo < products.Length)
                    {
                        Console.WriteLine("Para Girişi:");
                        int bakiye = Convert.ToInt32(Console.ReadLine());

                        while (true)
                        {
                            if (bakiye >= prices[urunNo])
                            {
                                Console.WriteLine("Afiyet Olsun.Para Üstü:" + (bakiye - prices[urunNo]));
                                count++;
                                total += prices[urunNo]; //total = total+prices[urunNo]
                                break;

                            }
                            else
                            {
                                Console.WriteLine("Yeteriz bakiye!\n1-Para Ekle\n2-Para İade\nSeçiminiz:");
                                int secim = Convert.ToInt32(Console.ReadLine());

                                if (secim == 1)
                                {
                                    Console.WriteLine("Para Girişi:");
                                    bakiye += Convert.ToInt32(Console.ReadLine());

                                }
                                else
                                {
                                    bakiye = 0;
                                    Console.WriteLine("Paranız iade edildi.");
                                    break;
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ürün Bulunamadı.");
                    }
                }
            
            }


        }
    }
}
