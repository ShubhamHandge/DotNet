namespace InheritanceExamples
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            BaseClass b1= new BaseClass();
            b1.a = 1;
            Console.WriteLine("Base Class: "+b1.a);

            DerivedClass b2 = new DerivedClass();
            b2.a = 2;
            b2.b = 3;
            Console.WriteLine("Derived Class: "+b2.a+","+b2.b);


        }
    }
    public class BaseClass
    {
        public int a;
    }
    public class DerivedClass:BaseClass
    {
        public int b;
    }
}

namespace InheritanceExamples1
{
    internal class Program
    {
        static void Main2(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            TestAccessSpecifiers.BaseClass baseClass = new TestAccessSpecifiers.BaseClass();
            //baseClass;



        }
    }
    public class BaseClass
    {
        public int i;

        public int PUBLIC;
        private int PRIVATE;
        protected int PROTECTED;
        internal int INTERNAL;
        protected internal int PROTECTED_INTERNAL;
        private protected int PROTECTED_INTERNAL_INTERNAL;
    }
    public class DerivedClass : TestAccessSpecifiers.BaseClass
    {
        void Display()
        {
            //this
        }
    }
}



namespace InheritanceExamples2
{
    internal class Program
    {
        static void Main3(string[] args)
        {
            //Console.WriteLine("Hello, World!");
           
            DerivedClass derivedClass = new DerivedClass();
            Console.WriteLine(derivedClass.i);

            //DerivedClass derivedClass2 = new DerivedClass(123,456);
            //Console.WriteLine(derivedClass2.i+ ","+ derivedClass2.j);

        }
    }
    public class BaseClass
    {
        public int i;
        public BaseClass()
        {
            Console.WriteLine("This is Base Class With No Parameter.");
            i = 10;
        }

        public BaseClass(int i)
        {
            Console.WriteLine("This is Base Class With One Parameter.");
            this.i = i;
        }
    }

    public class DerivedClass : BaseClass
    {
        public int j;

        public DerivedClass()
        {
            Console.WriteLine("This is Derived Class With No Parameter");
            j = 20;
        }

        public DerivedClass(int i, int j) : base(i)
        {
            Console.WriteLine("This is Derived Class With 2 Parameter.");
            //this.i = i;
            this.j = j;
            
        }
    }

}




namespace InheritanceExamples3
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            DerivedClass baseClass = new DerivedClass();
            //baseClass.Display1();
            //baseClass.Display1("Rushikesh");
            baseClass.Display2();
            baseClass.Display3();


        }

        static void Main5(string[] args)
        {
            // for base class object
           BaseClass baseClass = new BaseClass();
            baseClass.Display2();
            baseClass.Display3();

            Console.WriteLine();

            // for derived class object
            baseClass =new DerivedClass();
            baseClass.Display2();
            baseClass.Display3();



        }

        static void Main6()
        {
            BaseClass baseClass=new BaseClass();
            DerivedClass baseClass2 = new DerivedClass();
            CallDisplay(baseClass);
            CallDisplay(baseClass2);
        }

        static void CallDisplay(BaseClass b)
        {
            b.Display3();
        }
    }



    public class BaseClass
    {
        public void Display1()
        {
            Console.WriteLine("Base Display_1");
        }

        public void Display2()
        {
            Console.WriteLine("Base Display_2");
        }

        public virtual void Display3()
        {
            Console.WriteLine("Base Display_3");
        }
    }
    public class DerivedClass : BaseClass
    {
        public void Display1(string s)
        {
            Console.WriteLine("Derived Display-1");
        }

        public new void Display2()
        {
            Console.WriteLine("Derived Display-2");
        }

        public override void Display3()
        {
            Console.WriteLine("Derived Display-3");
        }
    }
}



namespace InheritanceExamples4
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            BaseClass baseClass = new BaseClass();
            //baseClass.Display2();
            baseClass.Display3();

            Console.WriteLine();

            // for derived class object
            baseClass = new DerivedClass();
            //baseClass.Display2();
            baseClass.Display3();

            //for sub derived class object
            //
            baseClass = new SubDerivedClass();
            baseClass.Display3();


        }

        static void Main3()
        {
            BaseClass baseClass = new BaseClass();
            DerivedClass derivedClass = new DerivedClass(); 
            SubDerivedClass subDerivedClass = new SubDerivedClass();

            NewDisplay(baseClass);
            NewDisplay(derivedClass);
            NewDisplay(subDerivedClass);

        }

        static void NewDisplay(BaseClass b)
        {
            b.Display3();
        }
    }

    public class BaseClass
    {
        public void Display1()
        {
            Console.WriteLine("Base Display_1");
        }

        public void Display2()
        {
            Console.WriteLine("Base Display_2");
        }

        public virtual void Display3()
        {
            Console.WriteLine("Base Display_3");
        }
    }
    public class DerivedClass : BaseClass
    {
        public void Display1(string s)
        {
            Console.WriteLine("Derived Display-1");
        }

        public new void Display2()
        {
            Console.WriteLine("Derived Display-2");
        }

        public override void Display3()
        {
            Console.WriteLine("Derived Display-3");
        }
    }

    public class SubDerivedClass:DerivedClass
    {
        public override void Display3()
        {
            Console.WriteLine("Sub-Derived Display->3");
        }
    }
}


namespace InheritanceExamples5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseClass baseClass = new BaseClass();
            //baseClass.Display2();
            baseClass.Display3();

            Console.WriteLine();

            // for derived class object
            baseClass = new DerivedClass();
            //baseClass.Display2();
            baseClass.Display3();

            //for sub derived class object
            //
            baseClass = new SubDerivedClass();
            baseClass.Display3();

            // for sub sub derived class object
            baseClass = new SubSubDerivedClass();
            baseClass.Display3();


        }

        static void Main3()
        {
            BaseClass baseClass = new BaseClass();
            DerivedClass derivedClass = new DerivedClass();
            SubDerivedClass subDerivedClass = new SubDerivedClass();

            NewDisplay(baseClass);
            NewDisplay(derivedClass);
            NewDisplay(subDerivedClass);

        }

        static void NewDisplay(BaseClass b)
        {
            b.Display3();
        }
    }

    public class BaseClass
    {
        public void Display1()
        {
            Console.WriteLine("Base Display_1");
        }

        public void Display2()
        {
            Console.WriteLine("Base Display_2");
        }

        public virtual void Display3()
        {
            Console.WriteLine("Base Display_3");
        }
    }
    public class DerivedClass : BaseClass
    {
        public void Display1(string s)
        {
            Console.WriteLine("Derived Display-1");
        }

        public new void Display2()
        {
            Console.WriteLine("Derived Display-2");
        }

        public override void Display3()
        {
            Console.WriteLine("Derived Display-3");
        }
    }

    public class SubDerivedClass : DerivedClass
    {
        public sealed override void Display3()
        {
            Console.WriteLine("Sub-Derived Display->3");
        }
    }

    public class SubSubDerivedClass : SubDerivedClass
    {
        public new void Display3()
        {
            Console.WriteLine("Sub-Sub-Derived Display-3");
        }
    }
}

