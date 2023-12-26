namespace ThreadingExamples1
{
    internal class Program
    {
        static void Maink()
        {
            Thread t1 = new Thread(new ThreadStart(Func1));
            t1.Start();

            Thread t2 = new Thread(Func2);
            t2.Start();

            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Main : " + i);
            }
        }

        static void Main1()
        {
            Thread t1 = new Thread(new ThreadStart(Func1));
            t1.IsBackground = true;                                //Isbackground-- after main execute it can not wait for other functions execution
            t1.Start();

            Thread t2 = new Thread(Func2);
           // t2.IsBackground = true;
            t2.Start();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Main : " + i);
            }
        }
        static void Main2()
        {
            Thread t1 = new Thread(new ThreadStart(Func1));
            t1.Start();

            Thread t2 = new Thread(Func2);
            t2.Start();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Main : " + i);
            }

            t1.Join(); //join is a waiting call. next line will run only after func1 is over
            Console.WriteLine("this code should run only after func1 is over");
        }
        static void Main3()
        {
            Thread t1 = new Thread(new ThreadStart(Func1));
            t1.Priority = ThreadPriority.Highest;            // prints first i.e priority highest 

            t1.Start();

            Thread t2 = new Thread(Func2);
            t2.Priority = ThreadPriority.Lowest;
            t2.Start();

            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Main : " + i);
            }
        }
        static void Main4()
        {
            Thread t1 = new Thread(new ThreadStart(Func1));

            t1.Start();

            //t1.Abort();                                    // terminate the thread permanently
            //t1.Suspend();                                    //temperorily pauses thread
            //t1.Resume();                                      //resume suspended thread


            //if(t1.ThreadState == ThreadState.)

            Thread t2 = new Thread(Func2);
            t2.Start();
            //t2.Abort();

            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Main : " + i);
            }
        }
        static void Main5()
        {

            Thread t1 = new Thread(new ThreadStart(Func1));
            t1.Start();

            Thread t2 = new Thread(Func2);
            t2.Start();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Main : " + i);
                Thread.Sleep(1000);
            }
        }

        static void Main6()
        {
            AutoResetEvent wh = new AutoResetEvent(false);
            Thread t1 = new Thread(delegate ()
            {
                for (int i = 0; i < 200; i++)
                {
                    Console.WriteLine("f1:" + i);
                    if (i % 50 == 0)
                    {
                        //instead of Suspend, use this
                        Console.WriteLine("waiting");
                        wh.WaitOne();
                    }
                }
            });
            t1.Start();

            Thread.Sleep(5000);
            Console.WriteLine("resuming 1....");
            wh.Set();

            Thread.Sleep(5000);
            Console.WriteLine("resuming 2....");
            wh.Set();

            Thread.Sleep(5000);
            Console.WriteLine("resuming 3....");
            wh.Set();

            Thread.Sleep(5000);
            Console.WriteLine("resuming 4....");
            wh.Set();
        }
        static void Func1()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("First : " + i);
                //Thread.Sleep(1000);
            }
        }
        static void Func2()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Second : " + i);
               // Thread.Sleep(1000);
            }

        }
    }
}


//calling func with parameter
namespace ThreadingExamples2
{
    internal class Program
    {
        static void Mainq()
        {
            //Thread t1 = new Thread(new ThreadStart(Func1));
            Thread t1 = new Thread(new ParameterizedThreadStart(Func1));      // it  must be 'obejct' type parameter in parameterize thread

            int x = 10;
            t1.Start(x);


            Thread t2 = new Thread(Func2);        // it  must be 'obejct' type parameter in parameterize thread
            string s = "passed value";
            t2.Start(s);


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Main : " + i);
            }
        }
        //TO DO : PASS MULTIPLE VALUES TO THE FUNC
        //1 - create an array/collection. pass it
        //2 - create a class/struct with properties. pass an object of the class/struct
        //3 - write an anon method/ local funct. anon/loc func can access outer variables directly


        static void Func1(object obj)
        {
            int x = (int)obj;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("First : " + i+ "-" + x);
            }
        }
        static void Func2(object obj)
        {
            string s = obj.ToString();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Second : " + i +"-"+ s);
            }

        }
    }
}


//ThreadPool
namespace ThreadingExamples3
{
    class MainClass
    {
        static void PoolFunc1(object o)    
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("First Thread " + i.ToString() + o.ToString());
            }
        }
        static void PoolFunc2(object o)
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Second Thread " + i.ToString());
            }
        }
        static void Mainh()
        {
            //ThreadPool.QueueUserWorkItem(new WaitCallback(PoolFunc1), "aaa");
            ThreadPool.QueueUserWorkItem(PoolFunc1, "aaa");

            //ThreadPool.QueueUserWorkItem(new WaitCallback(PoolFunc2));
            ThreadPool.QueueUserWorkItem(PoolFunc2);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Main Thread " + i.ToString());
            }
            int workerthreads, iothreads;

            ThreadPool.GetAvailableThreads(out workerthreads, out iothreads);
            //ThreadPool.SetMinThreads
            //ThreadPool.SetMaxThreads
            //ThreadPool.GetMinThreads(
            Console.WriteLine(workerthreads);
            Console.WriteLine(iothreads);

            Console.ReadLine();
        }
    }
}

//synchronization
namespace ThreadingExamples4
{
    class MainClass
    {
        static object lockObject = new object();
        static int i = 0;
        static void Main()
        {
            Thread t1 = new Thread(new ThreadStart(FuncLock));
            Thread t2 = new Thread(new ThreadStart(FuncMonitor));
            //Thread t3 = new Thread(new ThreadStart(FuncInterlocked));
            t1.Start();
            t2.Start();
            //t3.Start();

            //t1.Join();
            //t2.Join();
            //t3.Join();

            Console.WriteLine("Finished Main");
            Console.ReadLine();
        }
        static void FuncLock()
        {
            lock (lockObject) //Monitor.Enter(lockObject)
            {
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                //--------------------------
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;


                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                //--------------------------
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;


                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);

            }
        }

        static void FuncMonitor()
        {
            Monitor.Enter(lockObject);
            //{
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            // }
            Monitor.Exit(lockObject);

        }

        static void FuncInterlocked()
        {

            Interlocked.Add(ref i, 10);   //i+=10
            Console.WriteLine("Third Interlocked " + i.ToString());

            Interlocked.Increment(ref i); //++i;
            Console.WriteLine("Third Interlocked " + i.ToString());

            Interlocked.Decrement(ref i); //--i;
            Console.WriteLine("Third Interlocked " + i.ToString());

            Interlocked.Exchange(ref i, 100); //i = 100;
            Console.WriteLine("Third Interlocked " + i.ToString());
        }

    }
}