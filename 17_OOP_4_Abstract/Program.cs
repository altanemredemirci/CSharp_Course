namespace _17_OOP_4_Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* *** ABSTRACT - SOYUTLAMA ***
             ** ABSTRACT NEDİR?
             *Abstract özelliği bir classın base class olarak tanımlanmasını ve Instance alınmaması sağlar.
             *Abstract tanımlı property miras alınan sınıfta çağrılmak zorundadır.
             * C#’da bu fonksiyonaliteyi sağlamak için abstract anahtar sözcüğünü kullanmak yeterlidir.
             * Abstract tanımlı bir metot sadece abstract tanımlı sınıfta olabilir.
             * Abstract tanımlı sınıflar abstract metotlar gibi normal tanımlı metotlarda barındırabilir.
            
               ***** Abstract Sınıfların Normal Sınıflardan Farkı Nedir? *****
     Fark 1: Normal sınıflar içerisinde metot bildirimi yapılamazken, Abstract sınıflar içerisinde tıpkı arayüzler de olduğu gibi metot bildirimi yapılabilir. 
     Bildirimi yapılan metotlar, Abstract sınıftan türeyen sınıflar içerisinde tanımlanmak zorundadır.

     Fark 2: Normal sınıflardan “new()” anahtar sözcüğü ile nesneler oluşturulabilir ancak Abstract sınıflar tamamen kalıtım amaçlı geliştirildiğinden Abstract sınıflardan nesne oluşturulamaz.
             
             
             */




            //Insan insan = new Insan(); //**Abstract class olması sebebiyle Instance alınamaz.

            //IK ik = new IK();
            //ik.
        }
    }

    abstract class Insan //Tanımlanma amacı IK,MUH sınıflarının ortak özelliklerini barındıran bir base class olması.
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public abstract void Konus(); //Bu metodu miras alan her sınıf kullanmak zorundadır.
    }

    class IK : Insan
    {
        public int PersonelSayisi { get; set; }

        public override void Konus()
        {
            Console.WriteLine("Ben bir Insan Kaynakları personeliyim.");
        }   
       
    }

    class MUH : Insan
    {
        public int HesapSayisi { get; set; }

        public override void Konus()
        {
            Console.WriteLine("Ben bir Muhasebe personeliyim.");
        }
    }

    class IT : Insan
    {
        public int ProgramSayisi { get; set; }

        public override void Konus()
        {
            Console.WriteLine("Ben bir IT personeliyim");
        }
    }
}
