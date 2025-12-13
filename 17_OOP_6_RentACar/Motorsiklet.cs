using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_OOP_6_RentACar
{
    internal class Motorsiklet : Arac
    {       
        public int MotorHacmi { get; set; }
        public bool YanCantaVarMi { get; set; }

        public Motorsiklet(string marka, string model, int yil, string plaka, int gunlukKiraBedeli,int motorHacmi,bool yanCantaVarMi) : base(marka, model, yil, plaka, gunlukKiraBedeli)
        {
            MotorHacmi = motorHacmi;
            YanCantaVarMi = yanCantaVarMi;
        }


        public override void AracBilgileriGoster()
        {
            Console.WriteLine(Marka);
            Console.WriteLine(Model);
            Console.WriteLine(Yil);
            Console.WriteLine(Plaka);
            Console.WriteLine(GunlukKiraBedeli);
            Console.WriteLine(MotorHacmi);
            string yanCanta = YanCantaVarMi == true ? "Yan Çanta Var" : "Yan Çanta Yok";
            Console.WriteLine(yanCanta);
        }

        public override string AracTipiGoster()
        {
            return "Motorsiklet";
        }

        public override double KiraUcretiHesapla(int gun)
        {
            if (YanCantaVarMi)
            {
                GunlukKiraBedeli += 50;
            }
            return GunlukKiraBedeli * gun;
        }
    }
}
