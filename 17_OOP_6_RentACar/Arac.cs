using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_OOP_6_RentACar
{
    public abstract class Arac
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Yil { get; set; }
        public string Plaka { get; set; }
        public int GunlukKiraBedeli { get; set; }

        public Arac(string marka,string model,int yil,string plaka,int gunlukKiraBedeli)
        {
            Marka = marka;
            Model = model;
            Yil = yil;
            Plaka = plaka;
            GunlukKiraBedeli = gunlukKiraBedeli;
        }

        public abstract double KiraUcretiHesapla(int gun);
        public abstract void AracBilgileriGoster();
        public abstract string AracTipiGoster();

        public virtual void GenelBilgi()
        {
            Console.WriteLine(Marka);
            Console.WriteLine(Model);
            Console.WriteLine(Yil);
            Console.WriteLine(Plaka);
            Console.WriteLine(GunlukKiraBedeli);
        }
    }
}
