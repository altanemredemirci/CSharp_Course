namespace _16_Class_3_Enum
{
    enum Markalar { Honda, Mazda, Ford, Mercedes, Renault, Toyota, Tofaş, Lamborghini, Ferrari, Scania, Volvo }
    enum Vitesler { Otomatik,Yarı_Otomatik,Manuel}

    enum Renkler { Kırmızı, Beyaz, Siyah, Turuncu, Yeşil, Mavi, Mor }
    internal class Program
    {
        static void Main(string[] args)
        {
            Otomobil oto = new Otomobil(Markalar.Ferrari,Vitesler.Otomatik,Renkler.Kırmızı,5000,2,"F350",true,false);

            oto.OtomobilBilgiYaz();
        }
    }
    class Otomobil
    {
        public Markalar Marka;
        public Vitesler Vites;
        public Renkler Renk;
        public int MotorHacmi;
        public int KapiSayisi;
        public string Model;
        public bool Ceker4;
        public bool ParkSensoru;

        public Otomobil(Markalar marka,Vitesler vites,Renkler renk,int motorHacmi,int kapiSayisi,string model,bool ceker4,bool parkSensoru)
        {
            Marka = marka;
            Vites = vites;
            Renk = renk;
            MotorHacmi = motorHacmi;
            KapiSayisi = kapiSayisi;
            Model = model;
            Ceker4 = ceker4;
            ParkSensoru = parkSensoru;
        }

        public void OtomobilBilgiYaz()
        {
            Console.WriteLine("Marka:"+Marka);
            Console.WriteLine("Model:"+Model);
            Console.WriteLine("Vites:"+Vites);
            Console.WriteLine("Renk:"+Renk);
            Console.WriteLine("Motor Hacmi:"+MotorHacmi);
            Console.WriteLine("Çeker:"+Ceker4);
            Console.WriteLine("Kapı Sayısı:"+KapiSayisi);
            Console.WriteLine("Park Sensörü:"+ParkSensoru);
        }
    }

    class Ticari
    {
        public Markalar Marka;
        public Vitesler Vites;
        public Renkler Renk;
        public int TasimaKapasitesi;
        public bool Ceker4;
        public int YolcuKapasitesi;
    }
}

#region SORU
/*
 SORU: Aşağıdaki sınıfları tanımlayınız. 
Otomobil ve Ticari sınıfları Arac sınıfından türetilecektir.
Her sınıfa ait tüm sınıf özelliklerine atama yapan yapıcı(Constructor)
metotlar tanımlanacaktır.
Main içinden 2 nesne ile örneklendiriniz.
Nesneler sadece türetilen sınıfların yapıcı metotları kullanılarak
oluşturulacak.
Sabit veri tipleri:(enum)
----------------------
Marka:
Honda,Mazda,Ford,Mercedes,Renault,Toyota,Tofaş,Lamborghini,Ferrari,Sca
nia,Volvo
Vites: Manuel, Otomatik, Yarı_Otomatik
Renk: Kırmızı,Beyaz,Siyah,Turuncu,Yeşil,Mavi,Mor
Sınıf Adı: Arac
-------------------
Marka,
Vites,
Renk,
protected MotorHacmi,
SınıfAdı: Otomobil
-------------------------
KapiSayisi,
Model,
Ceker4, (4x4 mü?)
ParkSensoru, (Park sensörü var mı?)
public void OtomobilBilgiYaz() => Araca ait tüm bilgileri ekrana
yazdırsın.
SınıfAdi: Ticari
-------------------------
TasimaKapasitesi,
Ceker4, (4x4 mü?)
YolcuKapasitesi
public void TicariBilgiYaz() => Araca ait tüm bilgileri ekrana
yazdırsın

*/
#endregion