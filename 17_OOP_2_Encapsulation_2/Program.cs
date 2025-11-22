namespace _17_OOP_2_Encapsulation_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bir Üniversite sınav sonuçlarının  vize ve final property leri ile alındığı  vize'nin %40 final'ın %60 ile ortalamayı hesaplayan bir metot tanımlayınız.
            //vize ve final notlarının 0-100 aralığında olmasına dikkat ediniz.

            Ogrenci ogrenci = new Ogrenci();


            //1.Yöntem
            Console.WriteLine("Vize:");
            ogrenci._vize = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Final:");
            ogrenci._final = Convert.ToInt32(Console.ReadLine());

            ogrenci.Ortalama();
        }
    }

    internal class Ogrenci
    {
        private int vize;
        private int final;


        #region 1.Yöntem
        public int _vize
        {
            get { return vize; }
            set
            {
                if (value >= 0 && value < 101)
                {
                    vize = value;
                }
                else
                {
                    while (true)
                    {
                        Console.WriteLine("Vize 0-100 aralığında olmalıdır.!");

                        Console.WriteLine("Vize:");
                        _vize = Convert.ToInt32(Console.ReadLine());

                        if (_vize >= 0 && _vize < 101)
                        {
                            vize = _vize;
                            break;
                        }
                    }
                }
            }
        }
        #endregion

        public int _final
        {
            get { return final; }
            set
            {
                if (value >= 0 && value < 101)
                {
                    final = value;
                }
                else
                {
                    while (true)
                    {
                        Console.WriteLine("Final 0-100 aralığında olmalıdır.!");

                        Console.WriteLine("Final:");
                        _final = Convert.ToInt32(Console.ReadLine());

                        if (_final >= 0 && _final < 101)
                        {
                            final = _final;
                            break;
                        }
                    }
                }
            }
        }

        public void Ortalama()
        {
            Console.WriteLine("Ortalama:"+( vize*0.4+ final*0.6));
        }
    }
}
