namespace OperatorOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 o1 = new Class1 { i = 10 };
            Class1 o2 = new Class1 { i = 5 };


            //o1 = o1 + 5;
            //o1 = Class1.operator+(o1,5)

            Console.WriteLine(o1.i);
            o1 = o1 - o2;

            Console.WriteLine(o1.i);
        }
    }

    public class Class1
    {
        public int i;
        public static Class1 operator +(Class1 o1, int i)
        {
            Class1 retval = new Class1();
            retval.i = o1.i + i;
            return retval;
        }
        public static Class1 operator -(Class1 o1, Class1 o2)
        {
            Class1 retval = new Class1();
            retval.i = o1.i - o2.i;
            return retval;
        }
    }
}
//https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/operator-overloading