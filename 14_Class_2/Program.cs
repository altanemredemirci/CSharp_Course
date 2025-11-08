namespace _14_Class_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bir üyelik sistemi olsun.
            //üyelerden Username,FullName,Email,Password bilgileri alınarak bir listeye kaydedin.

            List<Uye> uyeler = new List<Uye>();

            Uye.Kayit(uyeler);

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
}
