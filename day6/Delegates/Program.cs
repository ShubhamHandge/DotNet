namespace DelegateExample
{
    //step 1 : create a delegate class having the same signature as the function to call
    public delegate void Del1();

    public delegate int DelAdd(int a, int b);
    //Object
    //Delegate
    //MultiCastDelegate
    //Del1
    internal class Program
    {
        static void Main1()
        {
            //step 2 :  create a delegate object and make the delegate reference point to the object.
            //the object will contain the function to call as a parameter

            Del1 oDel = new Del1(Display);

            //step 3 : call the function with the delegate reference
            oDel();//Display
        }

        static void Main2()
        {
            Del1 oDel = Display;
            oDel();

            oDel = Show;
            oDel();
        }

        static void Main3()
        {
            Del1 oDel = Display;
            oDel();

            Console.WriteLine();
            oDel += Show;
            oDel();

            Console.WriteLine();
            oDel += Display;
            oDel();

            Console.WriteLine();
            oDel -= Display;
            oDel();


        }
        static void Main4()
        {
            DelAdd oDel = Add;
            //Console.WriteLine(oDel(10,5));

            Console.WriteLine();
            oDel += Subtract;
            Console.WriteLine(oDel(10, 5));

            int ans = 0;
            ans = Add(10, 5);
            ans = Subtract(10, 5);
            Console.WriteLine(ans);
        }
        static void Main()
        {
            //Del1 oDel = Display;
            //oDel += Show;

            Del1 oDel = (Del1)Delegate.Combine(new Del1(Display), new Del1(Show), new Del1(Display));
            oDel();

            Console.WriteLine();
            //oDel = (Del1)Delegate.Remove(oDel, new Del1(Display));
            oDel = (Del1)Delegate.RemoveAll(oDel, new Del1(Display));
            oDel();

        }
        static void Display()
        {
            Console.WriteLine("Display");
        }
        static void Show()
        {
            Console.WriteLine("Show");
        }
        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Subtract(int a, int b)
        {
            return a - b;
        }
    }
}