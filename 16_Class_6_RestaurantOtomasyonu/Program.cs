namespace _16_Class_6_RestaurantOtomasyonu
{
    internal class Program
    {
        static List<Masa> Masalar = new List<Masa>()
            {
                new Masa(){No=1},
                new Masa(){No=2},
                new Masa(){No=3},
                new Masa(){No=4},
                new Masa(){No=5}
            };

        static List<Menu> Menuler = new List<Menu>()
        {
            new Menu(){No=1,Ad="Çorbalar",Yemekler=new List<Yemek>()
                {
                    new Yemek(){No=1,Ad="Mercimek",Fiyat=100},
                    new Yemek(){No=2,Ad="Ezogelin",Fiyat=200},
                    new Yemek(){No=3,Ad="Yayla",Fiyat=150}
                }
            },
            new Menu(){No=2,Ad="Balıklar",Yemekler=new List<Yemek>()
                {
                    new Yemek(){No=1,Ad="Levrek",Fiyat=100},
                    new Yemek(){No=2,Ad="Kalamar",Fiyat=200},
                    new Yemek(){No=3,Ad="Karides",Fiyat=150}
                }
            },
            new Menu(){No=3,Ad="Salatalar",Yemekler=new List<Yemek>()
                {
                    new Yemek(){No=1,Ad="Sezar",Fiyat=100},
                    new Yemek(){No=2,Ad="Ton Balıklı",Fiyat=200},
                    new Yemek(){No=3,Ad="Mevsim",Fiyat=150}
                }
            },
            new Menu(){No=4,Ad="Etler",Yemekler=new List<Yemek>()
                {
                    new Yemek(){No=1,Ad="Pirzola",Fiyat=100},
                    new Yemek(){No=2,Ad="Biftek",Fiyat=200},
                    new Yemek(){No=3,Ad="Lokum",Fiyat=150}
                }
            },
            new Menu(){No=5,Ad="Makarnalar",Yemekler=new List<Yemek>()
                {
                    new Yemek(){No=1,Ad="Spagetti",Fiyat=100},
                    new Yemek(){No=2,Ad="Bolanezli",Fiyat=200},
                    new Yemek(){No=3,Ad="Köri Soslu",Fiyat=150}
                }
            },
            new Menu(){No=6,Ad="İçecekler",Yemekler=new List<Yemek>()
                {
                    new Yemek(){No=1,Ad="Kola",Fiyat=100},
                    new Yemek(){No=2,Ad="Rakı",Fiyat=200},
                    new Yemek(){No=3,Ad="Şalgam",Fiyat=150}
                }
            }

        };

        static List<Siparis> Siparisler = new List<Siparis>();

        static List<Yemek> siparisYemek = new List<Yemek>();

        static double kazanc = 0;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1-Sipariş Al\n2-Hesap Al\n3-Masa Durumu\n4-Günlük Kazanç\n5-Popüler Ürün\n6-Çıkış\nSeçiminiz:");
                int secim = Convert.ToInt32(Console.ReadLine());

                if (secim == 1)
                {
                    Console.WriteLine("Kaç kişi?");
                    int kisiSayisi = Convert.ToInt32(Console.ReadLine());

                    Masa musteriMasa = Masa.MasaDoldur(Masalar);
                    if (musteriMasa == null)
                    {
                        Console.WriteLine("Yerimiz Yok!");
                        continue;
                    }

                    Siparis siparis = new Siparis();
                    siparis.MasaNo = musteriMasa.No;

                    for (int i = 0; i < kisiSayisi; i++)
                    {
                        while (true)
                        {
                            Menu secilenMenu = Menu.MenuSec(Menuler);

                            if (secilenMenu == null)
                            {
                                Console.WriteLine("Hatalı Menü Seçimi!");
                                continue;
                            }
                            else
                            {
                                Yemek secilenYemek = Siparis.YemekSec(secilenMenu);

                                if (secilenYemek == null)
                                {
                                    Console.WriteLine("Hatalı Yemek Seçimi!");
                                    continue;
                                }
                                else
                                {
                                    siparis.Siparisler.Add(secilenYemek);
                                    siparisYemek.Add(secilenYemek);
                                    Console.WriteLine("Başka bir arzunuz var mı?(E/H)");
                                    string cevap = Console.ReadLine().ToUpper();

                                    if (cevap == "E")
                                    {
                                        continue;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                            }

                        }


                    }

                    Siparisler.Add(siparis);
                }
                else if (secim == 2) 
                {
                    Masa.MasaDurumu(Masalar);
                    int sonuc = Masa.HesapOde(Siparisler,Masalar,kazanc);
                    if (sonuc == 1)
                    {
                        Console.WriteLine("Yine Bekleriz");
                    }
                    else if (sonuc == -100)
                    {
                        Console.WriteLine("Hesap Ödenmedi.");
                    }
                    else if (sonuc == -101)
                    {
                        Console.WriteLine("Hatalı Masa Seçimi!");
                    }
                    else
                    {
                        Console.WriteLine("Bilinmeyen Hata!. Lütfen sistem yöneticiniz ile görüşünüz");
                    }

                    Thread.Sleep(5000);
                }
                else if (secim == 3)
                {
                    Masa.MasaDurumu(Masalar);
                    Thread.Sleep(3000);
                }

                else if (secim == 4)
                {
                    Console.WriteLine("Günlük kazanç:"+kazanc);
                    Thread.Sleep(3000);
                }

                else if (secim == 5)
                {
                   
                }
                else if (secim == 6)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı Tuşlama!");
                    Thread.Sleep(2000);
                }
            }
        }
    }
}

/*
          *** RESTAURANT OTOMASYONU ****
          * Toplam 5 masa olacak. Masalarda kişi sınırlaması YOK. Her masa kendinden önceki masa dolu     ise     müşteri oturtulacak
          * Çorbalar:Mercimek:40, Yayla: 45, Ezogelin:54.5 gibi 5 menü yazılacak.
          * Merhaba hoşgeldiniz ifadesi kaç müşteri olduğunu öğrenilecek. Her grupdaki müşterilere ayrı       ayrı    menüler listelenecek ve seçim sonrası başka arzunuz var mı? sorusu sorulacak. 
             * Evet ise yeniden menüler listlenecek ve seçim istenecek. 
             * Hayır cevabı alınırsa diğer müşteriye geçilecek.
          * Sipariş alma işlemi bittiğinde yeni müşteri var mı? veya Hesap Al

          * Z Raporu
          * En Fazla Tercih Edilen Ürün
*/

/*
Masa:No,Dolu,Hesap
Yemek:No,Ad,Fiyat
Menu:Ad,List<Yemek>
Siparis:MasaNo,List<Yemek>

 
 */