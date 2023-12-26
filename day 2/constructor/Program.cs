namespace constructor
{
    internal class Program
    {
        static void Main()
        {
            Class1 o = new Class1();
            Console.WriteLine(o.i);

            Class1 o2 = new Class1(20);
            Console.WriteLine(o2.i);

        }
    }
    public class Class1
    {

        public int i;
        //public Class1()
        //{
        //    Console.WriteLine("no parameter constructor called");
        //    i = 10;
        //}

        //public Class1(int i)
        //{
        //    Console.WriteLine("int construtor called");
        //    i = this.i;                             //this is a reference to the current object
        //}

        public Class1(int i = 10)
        {
            Console.WriteLine("cons called");
            this.i = i;                            //this is a reference to the current object
        }


    }
}