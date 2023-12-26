namespace IDisposableExample
{
    class Program
    {
        static void Main1()
        {
            Class1 o = new Class1();
            o.Display();
            //o = null;
            o.Dispose();  //use this rather than o = null;
            //o.Display();
        }
        static void Main2()
        {
            using (Class1 o = new Class1())
            {
                o.Display();
            }


        }


        static void Main()
        {
            Class2 o = new Class2();
            o.Display();
            o.Dispose();  //use this rather than o = null;
            o.Display();
            o.Dispose();
            Console.ReadLine();
        }
    }
    public class Class1 : IDisposable
    {
        public Class1()
        {
            //open file here
            //open db here
            Console.WriteLine("cons");
        }
        public void Display()
        {
            Console.WriteLine("Display called");
        }


        public void Dispose()
        {
            //close file
            //close db conn
            Console.WriteLine("Dispose code called. Write code here instead of Destructor");
        }

        //do not write a destructor
        //~Class1()
        //{
        //    Console.WriteLine("des");
        //}

    }

    public class Class2 : IDisposable
    {
        public Class2()
        {
            //open file here
            //open db here
        }
        bool isDisposed;
        public void Display()
        {
            CheckForDisposed();
            Console.WriteLine("Display called");
        }
        public void Dispose()
        {
            CheckForDisposed();
            //close file
            //close db conn
            Console.WriteLine("Dispose code called. Write code here instead of Destructor");
            isDisposed = true;
        }
        private void CheckForDisposed()
        {
            if (isDisposed)
                throw new ObjectDisposedException("Class1");
        }
    }
}