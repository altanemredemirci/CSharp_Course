using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Class_6_RestaurantOtomasyonu
{
    internal class Menu
    {
        public int No { get; set; }
        public string Ad { get; set; }
        public List<Yemek> Yemekler { get; set; }

        public Menu()
        {
            Yemekler = new List<Yemek>();
        }

        public static Menu MenuSec(List<Menu> Menuler)
        {
            foreach (Menu item in Menuler)
            {
                Console.WriteLine(item.No + "-" + item.Ad);
            }

            Console.WriteLine("Menü No:");
            int menuNo = Convert.ToInt32(Console.ReadLine());

            return Menuler.FirstOrDefault(i => i.No == menuNo);
        }
    }
}
