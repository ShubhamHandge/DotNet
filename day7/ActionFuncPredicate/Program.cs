namespace ActionFuncPredicate
{
    internal class Program
    {
        static void Main1()
        {
            Action o1 = Display;
            o1();

            Action<string> o2 = Display;
            o2("shubh");

            Action<string, int, bool> o3 = Display;
            o3("ramu", 1, true);

        }

        static void Main()
        {
            Func<string> o1 = GetTime;
            Console.WriteLine(o1());

            Func<int, int> o2 = GetDouble;
            Console.WriteLine(o2(10));

            Func<int, bool> o3 = IsEven;
            Console.WriteLine(o3(10));

            Employee e = new Employee { EmpNo = 1, Name = "a", Basic = 1200 };
            Func<Employee, bool> o4 = IsBasicGreaterThan10000;
            Console.WriteLine(o4(e));
            //Console.WriteLine(o4(new Employee { EmpNo = 1, Name = "a", Basic = 12000 }));

            Predicate<int> o5 = IsEven;
            Console.WriteLine(o5(10));

            Predicate<Employee> o6 = IsBasicGreaterThan10000;
            Console.WriteLine(o6(e));

        }
        static void Display() 
        {
            Console.WriteLine("Display called");
        }
        static void Display(string s)
        {
            Console.WriteLine("Display called" + s);
        }
        static void Display(string s, int i, bool b)
        {
            Console.WriteLine("Display called" + s + i + b);
        }
        //     --------      --------
        static string GetTime()
        {
            return DateTime.Now.ToLongTimeString();
        }
        static int GetDouble(int a)
        {
            return a * 2;
        }
        static bool IsEven(int a)
        {
            if (a % 2 == 0)
                return true;
            else
                return false;
        }

        static bool IsBasicGreaterThan10000(Employee obj)
        {
            if (obj.Basic > 10000)
                return true;
            else
                return false;
        }
    }
    public class Employee
    {
        public int EmpNo { get; set; }
        public string Name { get; set; }
        public decimal Basic { get; set; }
        public int DeptNo { get; set; }

    }
}