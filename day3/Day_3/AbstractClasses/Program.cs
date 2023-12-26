namespace AbstractClasses
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            DerivedClass derivedClass = new DerivedClass();
            derivedClass.Display();

        }
    }

    public abstract class AbsClass1
    {
        public void Display()
        {
            Console.WriteLine("This is Abs Display");
        }
    }

    public class DerivedClass : AbsClass1
    {
        public void Display()
        {
            Console.WriteLine("This is Derived Class");
        }
    }
}

namespace AbstractClasses1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            DerivedClass derivedClass = new DerivedClass();
            derivedClass.Display();
            derivedClass.show();

        }
    }

    public abstract class AbsClass2
    {
        public abstract void Display();

        public abstract void show();
       
    }

    public class DerivedClass : AbsClass2
    {
        public override void Display()
        {
            Console.WriteLine("Display_1");
        }

        public override void show()
        {
            Console.WriteLine("Show");
        }
    }
}