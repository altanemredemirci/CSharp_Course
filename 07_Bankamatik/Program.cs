namespace _07_Bankamatik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bakiye = 25000;
            string sifre = "ab18";

        KART:
            Console.WriteLine("1-Kartlı İşlem\n2-Kartsız İşlem\nSeçiminiz:");
            int kartSecim = Convert.ToInt32(Console.ReadLine());

            if (kartSecim == 1)
            {
                int hak = 3;
            SIFRE:
                if (hak > 0)
                {
                    hak--;
                    Console.WriteLine("Şifreniz:");
                    string sfr = Console.ReadLine();

                    if (sfr == sifre)
                    {
                        goto ANAMENU;
                    }
                    else
                    {
                        Console.WriteLine("Şifre hatalı!");
                        goto SIFRE;
                    }

                }
                if (hak == 0)
                {
                    Console.WriteLine("Hakkınız Bitti!");
                }

            ANAMENU:
                Console.WriteLine("1-Para Çekme\n2-Para Yatırma\n3-Para Transferi\n4-Eğitim Ödemeleri\n5-Fatura Ödemeleri\n6-Şifre Güncelle\n7-Çıkış\nSeçiminiz:");
                int anaSecim = Convert.ToInt32(Console.ReadLine());

                if (anaSecim == 1)
                {
                    Console.WriteLine("Çekilecek Miktar:");
                    int miktar = Convert.ToInt32(Console.ReadLine());

                    if (bakiye >= miktar)
                    {
                        bakiye -= miktar;
                        Console.WriteLine("Paranızı Alınız. Yeni bakiyeniz:" + bakiye);
                    }
                    else
                    {
                        Console.WriteLine("Yetersiz Bakiye!");
                    }

                    Console.WriteLine("9-Anamenü\n0-Çıkış\nSeçiminiz:");
                    int donus = Convert.ToInt32(Console.ReadLine());

                    if (donus == 9)
                        goto ANAMENU;
                    else
                        Environment.Exit(0);


                }
                else if (anaSecim == 2)
                {
                    Console.WriteLine("1-Kredi Kartı\n2-Kendi Hesabına\nSeçiminiz:");
                    int yatirmaSecim = Convert.ToInt32(Console.ReadLine());

                    if (yatirmaSecim == 1)
                    {
                        Console.WriteLine("12 haneli kredi kart numarası:");
                        string kartNo = Console.ReadLine();

                        if (kartNo.Length == 12)
                        {
                            long kartNumarasi;
                            //int.TryParse:string değeri int dönüştürmeyi dene
                            if (long.TryParse(kartNo, out kartNumarasi))
                            {
                                Console.WriteLine("Yatırılacak Miktar:");
                                int miktar = Convert.ToInt32(Console.ReadLine());

                                if (bakiye >= miktar)
                                {
                                    bakiye -= miktar;
                                    Console.WriteLine("Yatırma işlemi başarılı.Yeni bakiyeniz:" + bakiye);
                                }
                                else
                                {
                                    Console.WriteLine("Yetersiz Bakiye!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Kart numarası 12 haneli rakamlardan oluşmalıdır.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Kart numarası 12 haneli olmalıdır.");
                        }
                    }
                    else if (yatirmaSecim == 2)
                    {
                        Console.WriteLine("Yatırılacak Miktar:");
                        int miktar = Convert.ToInt32(Console.ReadLine());

                        bakiye += miktar;
                        Console.WriteLine("Yatırma işlemi başarılı.Yeni bakiyeniz:" + bakiye);
                    }
                    else
                    {
                        Console.WriteLine("Hatalı Tuşlama!");
                    }
                }
                else if (anaSecim == 3) 
                {
                    Console.WriteLine("1-EFT\n2-HAVALE\nSeçiminiz:");
                    int transferSecim = Convert.ToInt32(Console.ReadLine());

                    if (transferSecim == 1) 
                    {
                        Console.WriteLine("Başında TR olacak şekilde IBAN bilgisi giriniz.");
                        string IBAN = Console.ReadLine(); //TR12312312313121

                        //TR Kontrolü
                        string tr = IBAN.Substring(0, 2).ToUpper();

                        if (tr == "TR") 
                        {
                            string ibanNo = IBAN.Substring(2);
                            if (ibanNo.Length == 16)
                            {
                                long ibanNumarasi;
                                //int.TryParse:string değeri int dönüştürmeyi dene
                                if (long.TryParse(ibanNo, out ibanNumarasi))
                                {
                                    Console.WriteLine("Transfer Edilecek Miktar:");
                                    int miktar = Convert.ToInt32(Console.ReadLine());

                                    if (bakiye >= miktar)
                                    {
                                        bakiye -= miktar;
                                        Console.WriteLine("Transfer işlemi başarılı.Yeni bakiyeniz:" + bakiye);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Yetersiz Bakiye!");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("IBAN numarası 16 haneli rakamlardan oluşmalıdır.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("IBAN numarası 16 haneli olmalıdır.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Başında TR olack şekilde giriniz!");
                        }

                    }
                    else if (transferSecim == 2) 
                    {
                        Console.WriteLine("12 haneli hesap numarası:");
                        string hesapNo = Console.ReadLine();

                        if (hesapNo.Length == 12)
                        {
                            long hesapNumarasi;
                            //int.TryParse:string değeri int dönüştürmeyi dene
                            if (long.TryParse(hesapNo, out hesapNumarasi))
                            {
                                Console.WriteLine("Transfer Miktarı:");
                                int miktar = Convert.ToInt32(Console.ReadLine());

                                if (bakiye >= miktar)
                                {
                                    bakiye -= miktar;
                                    Console.WriteLine("Transfer işlemi başarılı.Yeni bakiyeniz:" + bakiye);
                                }
                                else
                                {
                                    Console.WriteLine("Yetersiz Bakiye!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Kart numarası 12 haneli rakamlardan oluşmalıdır.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Kart numarası 12 haneli olmalıdır.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Hatalı Tuşlama!");
                    }
                }
                else if (anaSecim == 4) 
                {
                    Console.WriteLine("Eğitim Ödemeleri Bölümü Arızalı");
                }
                else if (anaSecim == 5) 
                { 
                  //Fatura
                }
                else if (anaSecim == 6) 
                {
                    Console.WriteLine("Yeni Şifreniz:");
                    string sifre1 = Console.ReadLine();

                    Console.WriteLine("Tekrar Yeni Şifreniz:");
                    string sifre2 = Console.ReadLine();

                    if (sifre1 == sifre2)
                    {
                        sifre = sifre1;
                    }
                }
                else if (anaSecim == 7)
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Hatalı Anamenü Seçimi!!");
                    Thread.Sleep(3000);
                    Console.Clear();
                    goto ANAMENU;
                }
            }
            else if (kartSecim == 2) { }
            else
            {
                Console.WriteLine("Hatalı Tuşlama!");
                goto KART;
            }
        }
    }
}
