namespace WorkingWithTasks
{
    internal class Program
    {
        static void Maino()
        {
            //Task t1a = new Task(new Action( Func1));
            Task t1 = new Task(Func1);

            t1.Start();
            Console.ReadLine();
        }
        static void Func1()
        {
            Console.WriteLine("func1 called");
        }
    }
}

//calling a method with void return type using taskobj.Start
namespace Example1
{
    class Program
    {
        static void Maink()
        {
            Task t1 = new Task(Func1);

            //Action objAction1 = Func1;
            //Task t1 = new Task(objAction1);


            //Task t3 = new Task(new Action(Func1));

            Action objAction2 = Func2;
            Task t2 = new Task(objAction2);

            t1.Start();
            t2.Start();

            Console.ReadLine();
        }
        static void Func1()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("first Func called from {0},{1}", Thread.CurrentThread.ManagedThreadId, i);
            }
        }
        static void Func2()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("second Func called from {0},{1}", Thread.CurrentThread.ManagedThreadId, i);
            }
        }
    }
}

//calling a method with void return type using Task.Run and Task.Factory.StartNew
namespace Example2
{
    class Program
    {
        static void Main1()
        {
            //Action objAction1 = Func1;
            //Task t1 = Task.Run(objAction1); 
            Task t1 = Task.Run(Func1);


            //Action objAction2 = Func2;
            //Task t2 = Task.Factory.StartNew(objAction2);
            Task t2 = Task.Factory.StartNew(Func2);

            Console.ReadLine();
        }
        static void Func1()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("first Func called from {0},{1}", Thread.CurrentThread.ManagedThreadId, i);
            }
        }
        static void Func2()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("second Func called from {0},{1}", Thread.CurrentThread.ManagedThreadId, i);
            }
        }
    }
}


//calling a method with void return type and parameters 
namespace Example3
{
    class Program
    {

        static void Mainj()
        {
            //Action<object> objAction1 = Func1;
            //Task t1a = new Task(objAction1, "aaa");

            Task t1 = new Task(Func1, "aaa");
            t1.Start();


            //Task.Run - cannot be used with parameters. 
            //use anonymous methods instead to access variables declared in calling code

            string s = "ccc";

            Task.Run(delegate () { Console.WriteLine(s); });
            Task.Run(() => { Console.WriteLine(s); });

            //Action<object> objAction2 = Func2;
            //Task t2 = Task.Factory.StartNew(objAction2, "bbb");
            Task t2 = Task.Factory.StartNew(Func2, "bbb");


            Console.ReadLine();
        }
        static void Func1(object obj)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("first Func called {0}{1}", i, obj.ToString());
            }
        }
        static void Func2(object obj)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("second Func called {0},{1}", i, obj.ToString());
            }
        }
    }
}


//calling methods with return type 
namespace Example4
{
    class Program
    {
        static void Main11111()
        {
            //Task<int> t1 = new Task<int>(new Func<int>(Func1));
            Task<int> t1 = new Task<int>(Func1);
            t1.Start(); 

            Console.WriteLine("after t1 start");
            //if (!t1.IsCompleted)
            //    t1.Wait();
            int ans = t1.Result;

            Console.WriteLine(ans);
            Console.WriteLine(t1.Result);

            //Task<int> t2 = new Task<int>(new Func<object, int>(Func2), "data"); 
            Task<int> t2 = new Task<int>(Func2, "data");
            //-----
            Task<int> t3 = Task<int>.Run(Func1);

        }
        static void Mainm()
        {


            //Task<int> t1 = new Task<int>(new Func<int>(Func1));


            //Func<int> objFunc1 = Func1;
            //Task<int> t1 = new Task<int>(objFunc1);
            Task<int> t1 = new Task<int>(Func1);
            t1.Start();



            //Func<object, int> objFunc2 = Func2;
            //Task<int> t2 = new Task<int>(objFunc2, "bbb");
            Task<int> t2 = new Task<int>(Func2, "bbb");

            t2.Start();



            //to do
            //try calling func with return value with Task.Run and Task.Factory.StartNew

            //Task<int> t5 = Task.Run<int>(Func1);

            //Task<int> t3 = Task.Factory.StartNew<int>(Func1);
            //Task<int> t4 = Task.Factory.StartNew<int>(Func2, "aaa");



            //if (!t1.IsCompleted)
            //    t1.Wait();
            Console.WriteLine(t1.Result);

            //if (!t2.IsCompleted)
            //    t2.Wait();
            Console.WriteLine(t2.Result);

            //Console.ReadLine();
        }
        static int Func1()
        {
            int i;
            for (i = 0; i < 1000; i++)
            {
                Console.WriteLine("first Func called {0}", i);
            }
            return i;
        }
        static int Func2(object obj)
        {
            int i;
            for (i = 0; i < 2000; i++)
            {
                Console.WriteLine("second Func called {0},{1}", i, obj.ToString());
            }
            return i;
        }
    }
}
 