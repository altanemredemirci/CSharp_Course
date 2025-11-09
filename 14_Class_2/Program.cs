namespace _14_Class_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bir üyelik sistemi olsun.
            //üyelerden Username,FullName,Email,Password bilgileri alınarak bir listeye kaydedin.

            //List<Uye> uyeler = new List<Uye>();

            //Uye.Kayit(uyeler);


            //Product sınıfı oluşturunuz. Product sınıfının özellikleri Id,Name,Price ve Stock olsun. Bir Kayıt() metodu yazınız.

            List<Product> products = new List<Product>();

            //Product.Kayit(products);

            //products.Add(Product.Kayit2());

            //Product product = Product.Kayit2();
            //products.Add(product);

            #region 1. Yöntem
            Product p = new Product();
            p.Id = 1;
            p.Price = 1000;
            p.Name = "Gömlek";
            p.Stock = 100;

            Product p2 = new Product();
            p2.Id = 2;
            p2.Price = 2000;
            p2.Name = "Tshirt";
            p2.Stock = 100;

            products.Add(p);
            products.Add(p2);
            #endregion

            #region 2. Yöntem
            Product p3 = new Product()
            {
                Id = 3,
                Name = "Etek",
                Price = 1500,
                Stock = 100
            };


            products.Add(p3);
            #endregion

            #region 3. Yöntem
            products.Add(new Product()
            {
                Id = 4,
                Name = "Pantolon",
                Price = 1500,
                Stock = 100

            });
            #endregion

            Product.Sil(products);
        }
    }

    class Uye
    {
        internal string Username;
        internal string Fullname;
        internal string Email;
        internal string Password;

        internal static void Kayit(List<Uye> uyes)
        {
            Uye uye = new Uye();
            Console.WriteLine("Username:");
            uye.Username = Console.ReadLine();
            Console.WriteLine("FullName:");
            uye.Fullname = Console.ReadLine();
            Console.WriteLine("Email:");
            uye.Email = Console.ReadLine();
            Console.WriteLine("Password");
            uye.Password = Console.ReadLine();

            uyes.Add(uye);
        }

    }

    class Product
    {
        internal int Id;
        internal string Name;
        internal double Price;
        internal int Stock;

        internal static void Kayit(List<Product> list)
        {
            Product p = new Product();
            Console.WriteLine("Id:");
            p.Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Name:");
            p.Name = Console.ReadLine();

            Console.WriteLine("Price:");
            p.Price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Stock:");
            p.Stock = Convert.ToInt32(Console.ReadLine());

            list.Add(p);

            Console.WriteLine("Kayıt Başarılı");
        }

        internal static Product Kayit2() //Product döndüren metot
        {
            Product p = new Product();
            Console.WriteLine("Id:");
            p.Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Name:");
            p.Name = Console.ReadLine();

            Console.WriteLine("Price:");
            p.Price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Stock:");
            p.Stock = Convert.ToInt32(Console.ReadLine());

            return p;
        }

        internal static void Sil(List<Product> list)
        {
           Listele(list);

            Console.WriteLine("Silinecek Ürün Numarası:");
            int silinecekId = Convert.ToInt32(Console.ReadLine());

            foreach (Product item in list)
            {
                if (item.Id == silinecekId)
                {
                    list.Remove(item);
                    Console.WriteLine("Ürün Silindi");
                    break;
                }
            }

            Listele(list);
        }

        internal static void Listele(List<Product> list)
        {
            foreach (Product item in list)
            {
                Console.WriteLine(item.Id + "-" + item.Name + ":" + item.Price);
            }
        }
    }
}
