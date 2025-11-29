using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_OOP_3_Inheritance_3
{
    internal class C:B
    {
        public int c { get; set; }

        public C()
        {
            Console.WriteLine("C sınıfının yapıcı metodu");
        }
    }
}
