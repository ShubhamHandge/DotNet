namespace function
{
    internal class Program
    {
        static void Main1()
        {
            class1 o;                           //o is a reference of type Class1
            o = new class1();                   //new Class1() is an object of Class1
            
            
            o.Display();
            o.Display("Shubham");


            Console.WriteLine(o.Add(10,20));

            Console.WriteLine(o.Add1(10, 20,30));
            Console.WriteLine(o.Add1(c: 3, a: 10, b: 2));

            Console.WriteLine(o.Add2(10, 30));
            Console.WriteLine(o.Add2(c: 3, b: 2));


            Console.WriteLine(o.mul(2,4,2));
            Console.WriteLine(o.mul(4,5));      // it take 0 value for "C" due to default values
            Console.WriteLine(o.mul(c: 3, a: 10));

        }

        static void Main()
        {
            class1 o;                           //o is a reference of type Class1
            o = new class1();                   //new Class1() is an object of Class1

            o.DoSomething();
        }

    }

    public class class1       
    {
        public void Display()
        {
            Console.WriteLine("Display");
        }

        //overload a function - same function name, diff parameters
        public void Display(string s)
        {
            Console.WriteLine("Display" + s);
        }

        public int Add(int a,int b)
        {
            return a + b;  
        }

        public int Add1(int a, int b, int c)
        {
            return a + b + c;
        }

        //default values
        public int Add2(int a = 0, int b = 0, int c = 0)
        {
            return a + b + c;
        }

        //default values
        public int mul(int a = 0, int b = 0, int c = 0)
        {
            return a * b * c;
        }


        public void DoSomething()
        {
            int i = 100;
            //local function can access local variables defined in the outer function

            void DoSomething1()
            {
                Console.WriteLine("DoSometing1 called");
                i++;
                Console.WriteLine(i);
            }

            //local funcs cannot be overloaded
            //void DoSomething1(int a)
            //{
            //    Console.WriteLine("DS1 called");
            //    i++;
            //    Console.WriteLine(i);
            //}



            DoSomething1();
            Console.WriteLine(i);   



        }


    }


}