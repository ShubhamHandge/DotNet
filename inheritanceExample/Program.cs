using System.Threading.Channels;

namespace inheritanceExample

{
    internal class Program
    {
        static void Main2()
        {
           
            Baseclass o1 = new Baseclass();
            o1.a = 1;

            Derivedclass o2 = new Derivedclass();
            o2.b = 2;
        }
    }

    public class Baseclass //:object
    {
        public int a;

    }
    
    public class Derivedclass : Baseclass
    {
        public int b;
    }

}

namespace inheritanceExample2

{
    internal class Program
    {
        static void Main2()
        {
         
            Baseclass o1 = new Baseclass();
            //o1.

            TestAccessSpecifier.Baseclass o2 = new TestAccessSpecifier.Baseclass();
            //o2.
               
        }
    }

    public class Baseclass //:object
    {


        //public - available everywhere
        //private- same class
        //protected- same class ,derived class
        //internal- same class, same assembly(same project)
        //protected internal- same class, derived class, same assembly(same project)
        //private protected- same class, derived class that is in same assembly


        public int PUBLIC;
        private int PRIVATE;
        protected int PROTECTED;
        internal int INTERNAL;
        protected internal int PROTECTED_INTERNAL;
        private protected int PRIVATE_PROTECTED;

    }

    public class Derivedclass : TestAccessSpecifier.Baseclass
    {
        void DoNothing()
        {
            //this.
        }
    }

}

namespace inheritanceExample3

{
    internal class Program
    {
        static void Main1()
        {

            Derivedclass o1 = new Derivedclass();
            Derivedclass o2 = new Derivedclass(123,456);
            

           

        }
    }

    public class Baseclass
    {
        public int i;
        public Baseclass()
        {
            Console.WriteLine("Base class no parameter const");
            i = 10;
        }

        public Baseclass(int i)
        {
            Console.WriteLine("Base class int const");
            this.i = i;
        }

      
    }

    public class Derivedclass :Baseclass
    {
       public int j;
        public Derivedclass() 
        {
            Console.WriteLine("derived class no para const");
            //i= 10;  base class member should only be initialized 
            j = 20;

        }

        public Derivedclass(int i,int j):base(i)
        {
            Console.WriteLine("derived class int, int const");
            this.j= j;
        }


    }

}

namespace inheritanceExample4

{
    internal class Program
    {
        static void Main23()
        {

            Derivedclass o1 = new Derivedclass();
            o1.display1();
        }

        static void Main()
        {
            Baseclass o;
            o = new Baseclass();
            //o.display2();  //non virtual , early bounding (compile time binding)
            o.display3();  //virtual method, late bound (run time bounding)

            Console.WriteLine();

            o =new Derivedclass();
           //o.display2();  //non virtual , early bounding (compile time binding)  
            o.display3();    //virtual method, late bound (run time bounding)


            Console.WriteLine();

            o = new SubDerivedClass();
           o.display2();  //non virtual , early bounding (compile time binding)  
            o.display3();    //virtual method, late bound (run time bounding)
           
            Console.WriteLine();
            o = new SubSubDerivedClass();
            //o.display2();  //non virtual , early bounding (compile time binding)  
            o.display3();    //virtual method, late bound (run time bounding)

        }


        static void Mainq()
        {
            Baseclass o1 = new Baseclass();
            Derivedclass o2 = new Derivedclass();
            CallDisplay3(o1);
            CallDisplay3 (o2);
        }

        static void CallDisplay3(Baseclass o)
        {
            o.display3();
        }
    }



    public class Baseclass
    {
        
        public void display1()
        {
            Console.WriteLine("Base display1");
          
        }

        public void display2()
        {
            Console.WriteLine("Base display2");

        }

        public virtual void display3()
        {
            Console.WriteLine("Base display3");

        }

    }

    public class Derivedclass : Baseclass
    {
       //overload
        public void display1(string s)
        {
            Console.WriteLine("derived display1");
          
        }

        //hiding
        public new void display2()
        {
            Console.WriteLine("derived display2");

        }

        //override
        public override void display3()
        {
            Console.WriteLine("derived display3");

        }





    }
    public class SubDerivedClass : Derivedclass
    {

        public sealed override void display3()    //sealed that stop overridden from that point
        {
            Console.WriteLine("subDerived display3");
             
        }
    }

    public class SubSubDerivedClass : SubDerivedClass
    {  
        public new void display3()
        {
            Console.WriteLine("subsubDerived display3");

        }
    }



}