namespace Static_Employee1_Check
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            Employee o1=new Employee();
            Employee o2=new Employee();
            Employee o3= new Employee();



            Console.WriteLine(o1.EmpId);
            Console.WriteLine(o2.EmpId);
            Console.WriteLine(o3.EmpId);

            Console.WriteLine();

            Console.WriteLine(o3.EmpId);
            Console.WriteLine(o2.EmpId);
            Console.WriteLine(o1.EmpId);

        }
    }

    public class Employee
    {
        public static int empId=1;
        public int EmpId
        {

            get
            {
                return empId++;
            }
        }

    }
}