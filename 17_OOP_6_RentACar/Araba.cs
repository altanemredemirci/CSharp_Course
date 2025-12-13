using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_OOP_6_RentACar
{
    internal class Araba : Arac
    {
        public int KapiSayisi { get; set; }
        public string VitesTipi { get; set; }
        public Araba(string marka,string model,int yil,string plaka,int gunlukKiraBedeli,int kapiSayisi,string vitesTipi):base(marka,model,yil,plaka,gunlukKiraBedeli)
        {
            KapiSayisi = kapiSayisi;
            VitesTipi = vitesTipi;
        }

        public override void AracBilgileriGoster()
        {
            Console.WriteLine(Marka);
            Console.WriteLine(Model);
            Console.WriteLine(Yil);
            Console.WriteLine(Plaka);
            Console.WriteLine(GunlukKiraBedeli);
            Console.WriteLine(KapiSayisi);
            Console.WriteLine(VitesTipi);
        }

        public override string AracTipiGoster()
        {
            return "Araba";
        }

        public override double KiraUcretiHesapla(int gun)
        {
            return GunlukKiraBedeli * gun * 1.1;
        }
    }
}
