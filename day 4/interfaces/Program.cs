namespace interfaces
{
    internal class Program
    {
        static void Main1()
        {
           Class1 o = new Class1();

            o.Display();
            //method 1
            o.Insert();
            o.Update();
            o.Delete();

            Console.WriteLine(); 

            //method 2
            IDbFuction OIDB;
            OIDB = o;
            OIDB.Insert();
            OIDB.Update();
            OIDB.Delete();

            Console.WriteLine();

            //method 3
            ((IDbFuction)o).Insert();
            ((IDbFuction)o).Update();
            ((IDbFuction)o).Delete();

            Console.WriteLine();

            //method 4                        // ""as" keyword is doing typecast in type3
            (o as IDbFuction).Insert();
            (o as IDbFuction).Update();
            (o as IDbFuction).Delete();


        }
    }

    public interface IDbFuction
    {
        
        void Insert();
        void Update();
        void Delete();
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
    }
}
namespace interfaces1
{
    internal class Program
    {
        static void Main6()
        {
            Class1 o = new Class1();

            o.Display();
            //method 1           
            o.Insert();
            o.Update();
            //o.Delete();
            
            Console.WriteLine();
            Console.WriteLine();


            //method 2
            IDbFuction OIDB;    //for 1st interface 
            OIDB = o;
            OIDB.Insert();
            OIDB.Update();
            OIDB.Delete();

            Console.WriteLine();

            IfileFuction Ifile;  //for 2nd interface
            Ifile = o;
            Ifile.Open();
            Ifile.Close();
            Ifile.Delete();

            Console.WriteLine();
            Console.WriteLine();


            //method 3
            ((IDbFuction)o).Insert();       //for 1st interface 
            ((IDbFuction)o).Update();
            ((IDbFuction)o).Delete();

            Console.WriteLine();

            ((IfileFuction)o).Open();      //for 2nd interface
            ((IfileFuction)(o)).Close();
            ((IfileFuction)(o)).Delete();


            Console.WriteLine();
            Console.WriteLine();


            //method 4                        // ""as" keyword is doing typecast in type3
            (o as IDbFuction).Insert();      //for 1st interface 
            (o as IDbFuction).Update();
            (o as IDbFuction).Delete();

            Console.WriteLine();

            (o as IfileFuction).Open();           //for 2nd interface
            (o as IfileFuction).Close();
            (o as IfileFuction).Delete();






        }
    }

    public interface IDbFuction
    {

        void Insert();
        void Update();
        void Delete();
    }
    public interface IfileFuction
    {

        void Open();
        void Close();
        void Delete();
    }
    public class Class1 : IDbFuction,IfileFuction
    {

        public void Display()
        {
            Console.WriteLine(" display from class1");
        }

         void IDbFuction.Delete()
         {
            Console.WriteLine("IDb delete from class1");
         }

        public void Insert()
        {
            Console.WriteLine("IDb insert from class1");
        }

        public void Update()
        {
            Console.WriteLine("IDb  update from class1");
        }

        void IfileFuction.Open()
        {
            Console.WriteLine("Ifile function  open from class1");
        }

        void IfileFuction.Close()
        {
            Console.WriteLine("Ifile function  close from class1");
        }

        void IfileFuction.Delete()
        {
            Console.WriteLine("Ifile function  delete from class1");
        }
    }
}
namespace interfaces2
{
    internal class Program
    {
        static void Mainj()
        {
            Class1 o = new Class1();
            Class2 o2 = new Class2();

            o.Display(); 

            //method 1
            o.Insert();
            o2.Insert();
           

            Console.WriteLine();

            //method 2
            IDbFuction OIDB;
            OIDB = o;
            OIDB.Insert();
            
            OIDB = o2;
            OIDB.Insert();

            Console.WriteLine();

            //method 3
            ((IDbFuction)o).Insert();
           
            ((IDbFuction)o2).Insert();

            Console.WriteLine();

            //method 4                        // ""as" keyword is doing typecast in type3
            (o as IDbFuction).Insert();
            
            (o2 as IDbFuction).Insert();


        }
    }

    public interface IDbFuction
    {

        void Insert();
        void Update();
        void Delete();
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
    }
    public class Class2 : IDbFuction
    {

        public void show()
        {
            Console.WriteLine("show from class2");
        }

        public void Delete()
        {
            Console.WriteLine("delete from class2");
        }

        public void Insert()
        {
            Console.WriteLine("insert from class2");
        }

        public void Update()
        {
            Console.WriteLine("update from class2");
        }
    }

}