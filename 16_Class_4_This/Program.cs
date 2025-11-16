namespace _16_Class_4_This
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //this anahtar değeri class'ı temsil eder.

            Customer customer = new Customer(1,"Altan Emre","Demirci");
        }
    }

    class Customer
    {
        public int Id;
        public string Name;
        public string Surname;

        public Customer(int Id,string Name,string Surname)
        {
            this.Id = Id;
            this.Name = Name;
            this.Surname = Surname;
        }
    }
}
