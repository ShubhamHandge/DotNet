using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//call a func using oDel.BeginInvoke. Func runs on a separate thread
namespace AsyncCodeWithDelegates0
{
    internal class Program
    {
        static void Main1()
        {
            Action oDel = Display;
            Console.WriteLine("before");
            //oDel();
            oDel.BeginInvoke(null, null);

            Console.WriteLine("after");
            Console.ReadLine();
        }
        static void Display()
        {
            Thread.Sleep(5000);
            Console.WriteLine("Display called");
        }
    }
}

//call a func using oDel.BeginInvoke. Func runs on a separate thread
//parameter used
namespace AsyncCodeWithDelegates1
{
    internal class Program
    {
        static void Main2()
        {
            Action<string> oDel = Display;
            Console.WriteLine("before");
            oDel.BeginInvoke("passed value", null, null);
            Console.WriteLine("after");
            Console.ReadLine();
        }
        static void Display(string s)
        {
            Thread.Sleep(5000);
            Console.WriteLine("Display called" + s);
        }
    }
}

//call a func using oDel.BeginInvoke. Func runs on a separate thread
//parameter used
//callback function called after display
namespace AsyncCodeWithDelegates2
{
    internal class Program
    {
        static void Main3()
        {
            Func<string, string> oDel = Display;
            Console.WriteLine("before");
            //oDel.BeginInvoke("passed value", new AsyncCallback(CallbackFunc), null);
            oDel.BeginInvoke("passed value", CallbackFunc, null);

            Console.WriteLine("after");
            Console.ReadLine();
        }
        static string Display(string s)
        {
            Thread.Sleep(5000);
            Console.WriteLine("Display called" + s);
            return s.ToUpper();
        }
        static void CallbackFunc(IAsyncResult ar)
        {
            Console.WriteLine("callback function called");
        }
    }
}


//call a func using oDel.BeginInvoke. Func runs on a separate thread
//parameter used
//callback function called after display
namespace AsyncCodeWithDelegates3
{
    internal class Program
    {
        static void Main3()
        {
            Func<string, string> oDel = Display;
            Console.WriteLine("before");
            //oDel.BeginInvoke("passed value", new AsyncCallback(CallbackFunc), null);
            IAsyncResult ar2 = oDel.BeginInvoke("passed value", delegate (IAsyncResult ar)
            {
                Console.WriteLine("callback function called");
                string retval = oDel.EndInvoke(ar);
                Console.WriteLine(retval);
            }, null);



            Console.WriteLine("after");
            Console.ReadLine();
        }
        static string Display(string s)
        {
            Thread.Sleep(5000);
            Console.WriteLine("Display called" + s);
            return s.ToUpper();
        }

    }
}

//call a func using oDel.BeginInvoke. Func runs on a separate thread
//parameter used
namespace AsyncCodeWithDelegates4
{
    internal class Program
    {
        static void Main()
        {
            Func<string, string> oDel = Display;
            Console.WriteLine("before");
            IAsyncResult ar = oDel.BeginInvoke("passed value", null, null);
            Console.WriteLine("after");

            while (!ar.IsCompleted) ;
            string retval = oDel.EndInvoke(ar);
            Console.ReadLine();
        }
        static string Display(string s)
        {
            Thread.Sleep(5000);
            Console.WriteLine("Display called" + s);
            return s.ToUpper();
        }
    }
}