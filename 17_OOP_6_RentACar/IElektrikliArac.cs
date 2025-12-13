using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_OOP_6_RentACar
{
    internal interface IElektrikliArac
    {
        public double BataryaKapasitesi{ get; set; }
        public double MaksimumMenzil { get; set; }
        public void BataryaDurumunuGoster();
        public double SarjSuresiHesapla();
    }
}
