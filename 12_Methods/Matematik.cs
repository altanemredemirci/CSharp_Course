using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Methods
{
    //class a bir erişim belirteci verilmez ise default INTERNAL alır.
    internal class Matematik
    {
        //metoda bir erişim belirteci verilmez ise default PRIVATE alır.

        //Static Method
        internal static void Toplama()
        {
            Console.WriteLine("1.Sayı:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayı:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Toplam:" + (sayi1 + sayi2));
        }

        //Nonstatic Method
        internal void Cikarma()
        {
            Console.WriteLine("1.Sayı:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayı:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Çıkarma:" + (sayi1 - sayi2));
        }
    }
}
