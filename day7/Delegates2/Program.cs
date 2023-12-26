namespace Delegates2
{
    public delegate int MathDel(int a, int b);
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine(MathOperation(Add, 10, 5));
            Console.WriteLine(MathOperation(Subtract, 3, 2));
        }


        //function to call is being passed as a paratmeter
        //enables late binding
        static int MathOperation(MathDel oMath, int a, int b)  //oMath = Subtract
        {
            return oMath(a, b);
        }
        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Subtract(int a, int b)
        {
            return a - b;
        }
        static int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}