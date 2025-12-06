namespace _17_OOP_4_Abstract_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            E-TİCARET
            Product  => Create(),Update(),Delete(),List(),Find(int id),List(filter)
            Category => Create(),Update(),Delete(),List(),Find(int id),List(filter)
            Brand    => Create(),Update(),Delete(),List(),Find(int id),List(filter)
            User     => Create(),Update(),Delete(),List(),Find(int id),List(filter)
            Cart     => Create(),Update(),Delete(),List(),Find(int id),List(filter)
            Order    => Create(),Update(),Delete(),List(),Find(int id),List(filter)

             */

            Product product = new Product();
            product.Create();
        }
    }

    abstract class Base
    {
        public abstract void Create();
        public abstract void Update();
        public abstract void Delete();
        public abstract void List();
        public abstract void Find(int id);
        public abstract void List(string filter);

        public void Insert()
        {
            Console.WriteLine();
        }
       
    }

    class Product : Base
    {
        public override void Create()
        {
            throw new NotImplementedException();
        }

        public override void Delete()
        {
            throw new NotImplementedException();
        }

        public override void Find(int id)
        {
            throw new NotImplementedException();
        }

        public override void List()
        {
            throw new NotImplementedException();
        }

        public override void List(string filter)
        {
            throw new NotImplementedException();
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }
    }

    class Category : Base
    {
        public override void Create()
        {
            throw new NotImplementedException();
        }

        public override void Delete()
        {
            throw new NotImplementedException();
        }

        public override void Find(int id)
        {
            throw new NotImplementedException();
        }

        public override void List()
        {
            throw new NotImplementedException();
        }

        public override void List(string filter)
        {
            throw new NotImplementedException();
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }
    }

    class Brand : Base
    {
        public override void Create()
        {
            throw new NotImplementedException();
        }

        public override void Delete()
        {
            throw new NotImplementedException();
        }

        public override void Find(int id)
        {
            throw new NotImplementedException();
        }

        public override void List()
        {
            throw new NotImplementedException();
        }

        public override void List(string filter)
        {
            throw new NotImplementedException();
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }
    }
}
