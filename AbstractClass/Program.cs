namespace AbstractClass1
{
    internal class Program
    {
        static void Main()
        {
           //AbsClass1 o = new AbsClass1();
           //error-can  not instantiated
           DerivedClass1 o = new DerivedClass1();
            o.Display();

        }
    }

    public abstract class AbsClass1
    {
        public void Display()
        {
            Console.WriteLine("display called");
        }
    }

    public  class  DerivedClass1: AbsClass1
    {

    }
}

namespace AbstractClass2
{
    internal class Program
    {
        static void Main8()
        {
            //AbsClass1 o = new AbsClass1();
            //error-can  not instantiated
            DerivedClass1 o = new DerivedClass1();
            o.Display();



        }
    }

    public abstract class AbsClass1
    {
        public abstract void Display(); 
        public abstract void Show();

    }

    public class DerivedClass1 : AbsClass1
    {
        public override void Display()
        {
            throw new NotImplementedException();
        }
         
        public override void Show()
        {
            throw new NotImplementedException();
        } 
    }
}