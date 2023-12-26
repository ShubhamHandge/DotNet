using System.Threading.Channels;

namespace ExpressionBodiedMember
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 cls = new Class1 ("Ram");
            cls.Display();
        }
    }
    public class Class1
    {
        //Methods

        public void Display() => Console.WriteLine($"Name{NAME}");
        public int Add(int a,int b)=> a+b;

        // property
        private string name;
        public string NAME
        {

            set =>  name = value;
            get => name; 
           
        }

        // read only property
        private string props1;
        private string Props1 => props1;


        //constructor
        //only single statement is allowed - so ideal for constructor with one parameter
        public Class1(string name) => this.NAME = name;

    }
}