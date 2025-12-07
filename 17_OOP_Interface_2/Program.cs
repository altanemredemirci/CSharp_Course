namespace _17_OOP_Interface_5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
        }
    }

    interface IInsan
    {
        void BoyAl();
        void AgirlikAl();
    }

    interface IVatandas : IInsan //Interface interface'e miras alınabilir.
    {
        void TCAl();
    }

    class Ogretmen : IVatandas //Interface class'a inheritance edilmez. Implement edilir.
    {
        public void AgirlikAl()
        {
            throw new NotImplementedException();
        }

        public void BoyAl()
        {
            throw new NotImplementedException();
        }

        public void TCAl()
        {
            throw new NotImplementedException();
        }
    }
}
