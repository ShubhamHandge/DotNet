using System.Collections.Concurrent;

namespace StaticMembers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 o1=new Class1();
            //Console.WriteLine("Hello, World!");
            Class1.s_i = 50;
            Class1.s_Display();


            // Calling Non-Static Member Function
            Class1 o=new Class1();
            o.i=100;
            o.Display();

            // Calling Static Member Function.
            Class1.s_i = 101010;
            Class1.s_Display();


            // Calling Non-Static Property.
            o.P1= 10;
            Console.WriteLine(o.P1);


            // calling Static Property.
            Class1.P2= 20;
            Console.WriteLine(Class1.P2);


            Console.WriteLine("Doing Something Different.");
            Console.WriteLine();


        }
    }

    public class Class1
    {
        public int i;

        //Static Variable s_i.
        public static int s_i;
        public void Display()
        {
            Console.WriteLine("This is Non-Static Function.");
            Console.WriteLine(i);
        }

        // Static Member Function.
        public static void s_Display()
        {
            Console.WriteLine("This is Static Function.");
            Console.WriteLine(s_i);
        }

        // Non_Static Property.
        public int p1;
        public int P1
        {
            get {return p1;}
            set 
            {

                if (value < 100)
                {
                    Console.WriteLine("This is Non_Static Property.");
                    p1 = value;
                }
                else
                    Console.WriteLine("Invalid Number");
            }
        }

        // Static Property.
        public static int p2;
        public static int P2
        {
            set
            {
                if(value < 100)
                {
                    Console.WriteLine("This is Static Property.");
                    p2 = value;
                }
            }
            get
            {
                return p2;
            }
        }

        // Non-Static Constructor.

        public Class1()
        {
            Console.WriteLine("This is Non Parametrised Constructor.");
        }

        // Static Constructor 
        static Class1()
        {
            Console.WriteLine("This is Static Constructor.");
        }
    }
}