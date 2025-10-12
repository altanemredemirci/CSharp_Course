namespace _04_DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tarih ve Zaman Veri Tipi

            DateTime dateTime = DateTime.Now;
            Console.WriteLine(dateTime);
            Console.WriteLine(dateTime.Year);
            Console.WriteLine(dateTime.Month);
            Console.WriteLine(dateTime.Day);
            Console.WriteLine(dateTime.DayOfYear);
            Console.WriteLine(dateTime.DayOfWeek);
            Console.WriteLine(dateTime.AddMonths(1));
            Console.WriteLine(dateTime.Date);
            Console.WriteLine(dateTime.ToLongTimeString());
            Console.WriteLine(dateTime.ToShortTimeString());
            Console.WriteLine(dateTime.ToLongDateString());
            Console.WriteLine(dateTime.ToShortDateString());
        }
    }
}
