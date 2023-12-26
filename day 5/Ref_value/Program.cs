using RefAndValue;

namespace RefAndValue
{
    internal class Program
    {
        static void Main1()
        {
            Class1 o1 = new Class1();
            Class1 o2 = new Class1();
            o1.i = 100;
            o2.i = 200;
            o1 = o2;
            o2.i = 300;
            Console.WriteLine(o1.i);
            Console.WriteLine(o2.i);
        }

        static void Main8()
        {
            int o1, o2;
            o1 = 100;
            o2 = 200;
            o1 = o2;
            o2 = 300;
            Console.WriteLine(o1);
            Console.WriteLine(o2);
            Console.ReadLine();
        }
        static void Main7() 
        {
            string o1, o2;
            o1 = "100";
            o2 = "200";
            o1 = o2;
            o2 = "300";
            Console.WriteLine(o1);
            Console.WriteLine(o2);
            Console.ReadLine();
        }

        static void DataTypes()
        {
            byte by; //Byte 
            sbyte by2; //SByte 

            short sh; //Int16 - 2
            ushort ush; //UInt16

            int i; //Int32  - 4
            uint ui;  //UInt32 - 4

            long l; //Int64 - 8
            ulong ul; //UInt64 - 8

            float f;   //Single
            double d;  //Double
            decimal c; //Decimal

            char ch; //Char
            bool b; //Boolean

            object o; //Object
            string s; //String
        }
        static void Boxing()
        {
            int i = 100;

            object o;
            o = i;  //boxing
            int j;
            j = (int)o; //unboxing

        }
    }
    public class Class1
    {
        public int i;
    }
}

namespace RefAndValue2
{
    // ref , out , in 
    internal class Program
    {
        static void Main0()
        {
            int i=10, j=20;
           Init(out i, out j);
            //Swap(ref i, ref j);

            Print(in i);
            Print(j);

            //Console.WriteLine(i);
            //Console.WriteLine(j);
        }
        static void Swap(ref int a, ref int b) 
        {
            int temp = a;
            a = b;
            b = temp;
        }
        //out is similar to ref - changes made in function  reflect back in calling code
        //the initial value is discarded
        //out variables MUST be initialized in the function 
        static void Init(out int a, out int b)
        {
            //Console.WriteLine(a); //error - loses its initial value
            a = 1000;
            b = 2000;
        }
        static void Print(in int x)
        {
            //x is a readonly value 
            //x = 100; //error
            Console.WriteLine(x);

        }

        
    }
    


}

namespace RefAndValue3 //passing reference types



{
    class Program
    {
        static void Mainy()
        {
            Class1 o = new Class1();
            o.i = 100;
            //DoSomething1(o);
            //DoSomething2(o);
            //DoSomething3(ref o);
            //DoSomething4(out o);
            DoSomething5(in o);
            Console.WriteLine(o.i);
        }
        static void DoSomething1(Class1 obj)
        {
            //changes made in func (changing value of properties) is reflected in calling code o
            obj.i = 200;
        }
        static void DoSomething2(Class1 obj)
        {
            //changes made in func (obj pointing to some other block) is NOT reflected in calling code o

            obj = new Class1();
            obj.i = 200;
        }
        static void DoSomething3(ref Class1 obj)
        {
            //changes made in func (obj pointing to some other block) is reflected in calling code o

            obj = new Class1();
            obj.i = 200;
        }
        static void DoSomething4(out Class1 obj)
        {
            //obj MUST be initialized
            //changes made in func (obj pointing to some other block) is reflected in calling code o

            obj = new Class1();
            obj.i = 200;
        }
        static void DoSomething5(in Class1 obj)//obj = o
        {
            //obj CANNOT be initialized
            //obj = new Class1();

            //changes made in func (changing value of properties) is reflected in calling code o
            obj.i = 200;
        }
    }
    public class Class1
    {
        public int i;
    }
}

namespace ValueTypes1
{
    internal class Program
    {
        static void Maink()
        {
            MyPoint p = new MyPoint();
            Console.WriteLine(p.X);
        }
    } 
    public struct MyPoint
    {
        public int A
        {
            get; set;
        }
        public int X;
        private int b;
        public int B
        {
            get { return b; }
            set { b = value; }
        }
        public MyPoint()
        {
            //this.X = 10;
            //this.A = 30;
            //this.b = 0; 
            //this.B = 40;
        }

    }
}

namespace ValueTypes2
{
    class Program
    {
        static void Main4()
        {
            //Display1(0);
            Display2(TimeOfDay.Afternoon);
            Console.ReadLine();
        }
        static void Display1(int t)
        {
            if (t == 0)
                Console.WriteLine("Good Morning");
            else if (t == 1)
                Console.WriteLine("Good Afternoon");
            else if (t == 2)
                Console.WriteLine("Good Evening");
            else if (t == 3)
                Console.WriteLine("Good Night");
        }
        static void Display2(TimeOfDay t)
        {
            if (t == TimeOfDay.Morning)
                Console.WriteLine("Good Morning");
            else if (t == TimeOfDay.Afternoon)
                Console.WriteLine("Good Afternoon");
            else if (t == TimeOfDay.Evening)
                Console.WriteLine("Good Evening");
            else if (t == TimeOfDay.Night)
                Console.WriteLine("Good Night");
        }
    }


    public enum TimeOfDay //: long
    {
        Morning,
        Afternoon = 30,
        Evening,
        Night
    }
}