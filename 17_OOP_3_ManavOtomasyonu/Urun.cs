using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_OOP_3_ManavOtomasyonu
{
    public enum Tur { Meyve, Sebze }
    class Urun
    {
        public string Ad { get; set; }
        public int Stok { get; set; }
        public int Fiyat { get; set; }
        public Tur Tur { get; set; }


    }
}
