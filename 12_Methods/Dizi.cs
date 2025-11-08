using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Methods
{
    internal class Dizi
    {
        internal static void SayiUret(int[] ints)
        {
            Console.WriteLine("Başlangıç Değeri:");
            int basla = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Bitiş Değeri:");
            int bitis = Convert.ToInt32(Console.ReadLine());


            Random r = new Random();

            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = r.Next(basla, bitis);
            }            

        }

        internal static void DiziYazdir(int[] ints)
        {
            foreach (int item in ints)
            {
                Console.WriteLine(item);
            }
        }

        internal static void EnBuyukEnKucuk(int[] ints)
        {
            int enBuyuk = ints[0];
            int enKucuk = ints[0];
            
            foreach (int item in ints)
            {
                if (item > enBuyuk)
                {
                    enBuyuk = item;
                }
                if (item < enKucuk)
                {
                    enKucuk = item;
                }
            }

            Console.WriteLine("En Büyük:"+enBuyuk);
            Console.WriteLine("En Küçük:"+enKucuk);

        }

    }
}
