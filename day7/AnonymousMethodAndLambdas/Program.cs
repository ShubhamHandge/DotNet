namespace AnonymousMethodAndLambdas
{
    internal class Program
    {
        static void Mainr()

         // Anonymous Method allows you to access local variable declared in calling  code(outside function)

            // 
        {
            Action o1 = delegate ()   // call Display
            {
                Console.WriteLine("anonymous Display called");
            };
            o1 ();


            Func<int,int,int> o2= delegate(int a, int b)
            {
                return a + b;
            };
            Console.WriteLine(o2(1,5));



            Func<string> o3 = delegate ()
            {
                return DateTime.Now.ToLongTimeString();
            };

            Func<int ,int> o4= delegate(int a)
            {
                return a * 2;
            };
            Console.WriteLine(o4(10));


            Predicate<int> o5 = delegate (int a)
            {
                if (a % 2 == 0)
                    return true;
                else
                    return false;
            };
            Console.WriteLine(o5(10));

        }


        static void Main(string[] args)
        {

            //Func<int, int> o2 = GetDouble;           //  by delegate
            //Console.WriteLine(o2(10));


            Func<int, int> o7 = delegate (int a)          // by anonymous method from function 
            {
                return a * 2;
            };
            Console.WriteLine(o7(10));


            Func<int, int> o8 = (a) => a * 2;       // by lambda
            Console.WriteLine(o8(10));


            //---
            Predicate<int> o5 = delegate (int a)  // by anonymous method from function 
            {
                if (a % 2 == 0)
                    return true;
                else
                    return false;
            };
            Console.WriteLine(o5(10));


            Predicate<int> o1 = (a) => a % 2 == 0;    // by lambda
            Console.WriteLine(o1(10));

            //-

            //Func<int, int, int> o6 = Add;             //  by delegate
            //Console.WriteLine(o6(10,19));

            Func<int, int, int>o = delegate (int a, int b)       // by anonymous method from function 
            {
                return a + b;
            };
            Console.WriteLine(o(4,4));


            Func<int, int, int> o4 = (a,b) => a + b;         //lambda
            Console.WriteLine(o(4, 4));
        }


        //static void Display()                        //accessing in main via delegate
        //{
        //    Console.WriteLine("Display called");
        //}


        //static int Add(int a, int b)
        //{
        //    return a + b;
        //}


        //static string GetTime()
        //{
        //    return DateTime.Now.ToLongTimeString();
        //}


        //static int GetDouble(int a)
        //{
        //    return a * 2;
        //}

        //static bool IsEven(int a)
        //{
        //    if (a % 2 == 0)
        //        return true;
        //    else
        //        return false;
        //}

        //static int GetDouble(int a)
        //{
        //    return a * 2;
        //}

        //static bool IsEven(int a)
        //{
        //    if (a % 2 == 0)
        //        return true;
        //    else
        //        return false;
        //}
        //static int Add(int a, int b)
        //{
        //    return a + b;
        //}





    }

}