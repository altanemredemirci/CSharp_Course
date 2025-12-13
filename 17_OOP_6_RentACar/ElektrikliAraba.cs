using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_OOP_6_RentACar
{
    internal class ElektrikliAraba : Araba, IElektrikliArac
    {
        public ElektrikliAraba(string marka, string model, int yil, string plaka, int gunlukKiraBedeli, int kapiSayisi, string vitesTipi) : base(marka, model, yil, plaka, gunlukKiraBedeli, kapiSayisi, vitesTipi)
        {
        }

        public double BataryaKapasitesi { get ; set ; }
        public double MaksimumMenzil { get; set; }

        public void BataryaDurumunuGoster()
        {
            Console.WriteLine(BataryaKapasitesi);
        }

        public double SarjSuresiHesapla()
        {
            return BataryaKapasitesi / 10;
        }

        public override double KiraUcretiHesapla(int gun)
        {
            return GunlukKiraBedeli * gun * 0.95;
        }
    }
}
