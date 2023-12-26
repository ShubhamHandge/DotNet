using System.Collections;

namespace Indexers
{
    internal class Program
    {
        static void Main()
        {
            ArrayList obj = new ArrayList();

            Class1 o1 = new Class1();
            o1[0] = 100; //set
            Console.WriteLine(o1[0]); //get
        }
    }
    public class Class1
    {
        private int[] arr = new int[3];
        public int this[int index]
        {
            get
            {
                return arr[index];
            }
            set
            {
                arr[index] = value;
            }
        }

    }
}
namespace Indexer2
{
    class Program
    {
        static void Main2()
        {
            Class1 o = new Class1(5, 3000);
            //o[0]=100;
            o[3000] = 100;
            o[3001] = 100;
            o[3002] = 100;
            o[3003] = 100;
            o[3004] = 100;
            Console.WriteLine(o[3000]);
            Console.ReadLine();
        }
    }
    public class Class1
    {
        private int[] arr;
        int start;
        public Class1(int Size, int start)
        {
            this.start = start;
            arr = new int[Size];
        }
        public int this[int index]
        {
            get
            {
                return arr[index - start];
            }
            set
            {
                arr[index - start] = value;
            }
        }

    }
}
