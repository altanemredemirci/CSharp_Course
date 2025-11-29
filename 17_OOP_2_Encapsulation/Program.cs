namespace _17_OOP_2_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Data Access Modifier
            /*
             public:Solution geneline erişilebilir.
             internal:Proje geneline erişilebilir.
             private:Class geneline erişilebilir.
             protected:Miras alınan sınfta erişilebilir.
             */

            //********* ENCAPSULATION **********
            //Belirli bir property gizli tanımlayarak kullanıcının erişimine kapatılır. Gizli property proje için önemli bilgi barındıracağı için kullanıcının direk kullanımına kapanır. Kullanıcıdan public tanımlı başka bir property data girmesi istenir ve girilen data belirli kontrollerden geçirildikten sonra gizli property e atanır.

            //Mesela bir tc kimlik numarası girişinde 11 haneli rakamlardan oluşma kuralı vardır.Bu sebeple kullanıcıdan bir data alındıktan sonra kontroller yapılarak class'ın TC property sine atama yapılır.

            //Gizli property e data atamak için set metot, gizli property okunmak için get metot kullanılır.

            Vatandas vatandas = new Vatandas();
            vatandas.Ad = "Altan Emre";
            
            //set metot kullanılır.
            vatandas._TC = "12345678920"; //value

            //get metot kullanılır
            Console.WriteLine(vatandas._TC);

        }
    }

    class Vatandas
    {
        public string Ad;
        private string TC; //girilen tc bilgisinin doğruluğu sağlanmalıdır.

        public string _TC
        {
            get //değeri okumak için kullanılır.
            {
                return TC;
            }
            set//değer atamak için kullanılır.
            {
                if (value.Length == 11)
                {
                    TC = value;
                }
                else
                {
                    Console.WriteLine("11 haneli olmalıdır.");
                }
            }
        }
    }





}
