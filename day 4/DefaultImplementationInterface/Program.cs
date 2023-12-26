namespace DefaultImplementationInterface
{
    internal class Program
    {
        static void Main()
        {
            Class1 o = new Class1();
            o.Insert();
            //o.Select();

            //for default implementation accessing 
            IDbFuction OID;
            OID = o;
            OID.Select();
        }

         
    }
    
    public interface IDbFuction
    {
        void Insert();
        void Update();
        void Delete();
        void Select()
        {
             Console.WriteLine("default implementation of select");
        }
    } 
    public class Class1 : IDbFuction
    {

        public void Display()
        {
            Console.WriteLine("display from class1");
        }

        public void Delete()
        {
           Console.WriteLine("delete from class1");
        }

        public void Insert()
        {
           Console.WriteLine("insert from class1");
        }

        public void Update()
        {
           Console.WriteLine("update from class1");
        }
        //public void Select()
        //{
        //   Console.WriteLine("select from class1");
        //}


         void IDbFuction.Select()
         {
            Console.WriteLine("default implementation of explicit from class1");
         }




    }
}