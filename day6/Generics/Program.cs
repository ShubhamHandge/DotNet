namespace GenericsExample
{
    internal class Program
    {
        static void Main4(string[] args)
        {
            IntegerStack o1 = new IntegerStack(3);
            o1.Push(1);
            o1.Push(2);
            o1.Push(3);

            Console.WriteLine(o1.Pop());
            Console.WriteLine(o1.Pop());
            Console.WriteLine(o1.Pop());

            StringStack o2 = new StringStack(3);
            o2.Push("aa");
            o2.Push("ba");
            o2.Push("pa");

            Console.WriteLine(o2.Pop());
            Console.WriteLine(o2.Pop());
            Console.WriteLine(o2.Pop());

        }
        static void Main()
        {
            MyStack<int> o1 = new MyStack<int>(3);
            o1.Push(1);
            o1.Push(2);
            o1.Push(3);
            Console.WriteLine(o1.Pop());
            Console.WriteLine(o1.Pop());
            Console.WriteLine(o1.Pop());

            MyStack<string> o2 = new MyStack<string>(3);
            o2.Push("aa");
            o2.Push("ba");
            o2.Push("pa");

            Console.WriteLine(o2.Pop());
            Console.WriteLine(o2.Pop());
            Console.WriteLine(o2.Pop());
        }
    }

    class IntegerStack
    {
        int[] arr;
        public IntegerStack(int Size)
        {
            arr = new int[Size];
        }
        int Pos = -1;
        public void Push(int i)
        {
            if (Pos == (arr.Length - 1))
                throw new Exception("Stack full");
            arr[++Pos] = i;
        }
        public int Pop()
        {
            if (Pos == -1)
                throw new Exception("Stack Empty");
            return arr[Pos--];
        }
    }
    class StringStack
    {
        string[] arr;
        public StringStack(int Size)
        {
            arr = new string[Size];
        }
        int Pos = -1;
        public void Push(string i)
        {
            if (Pos == (arr.Length - 1))
                throw new Exception("Stack full");
            arr[++Pos] = i;
        }
        public string Pop()
        {
            if (Pos == -1)
                throw new Exception("Stack Empty");
            return arr[Pos--];
        }
    }

    class MyStack<T>
    //where T : class  //- T must be a reference type
    //where T : struct - T must be a value type
    //where T : ClassName - T must be either ClassName or a derived class
    //where T : InterfaceName - T must be a class that implements InterfaceName
    //where T : new() //- T must have a no parameter constructor

    //constraints can be combined. new() must appear at the end if new() is used
    //where T : ClassName, InterfaceName
    //where T : ClassName, InterfaceName, new()
    {
        T[] arr;
        public MyStack(int Size)
        {
            arr = new T[Size];

        }
        int Pos = -1;
        public void Push(T i)
        {
            if (Pos == (arr.Length - 1))
                throw new Exception("Stack full");
            arr[++Pos] = i;
        }
        public T Pop()
        {
            if (Pos == -1)
                throw new Exception("Stack Empty");
            return arr[Pos--];
        }
    }
}