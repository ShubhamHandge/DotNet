namespace Employee
{
    internal class Program
    {
        static void Main()
        {
            Employee o1 = new Employee(1, "Amol", 123465, 10);
            o1.Display();
            Employee o2 = new Employee(1, "Amol", 123465);
            o2.Display();
            Employee o3 = new Employee(1, "Amol");
            o3.Display();
            Employee o4 = new Employee(1);
            o4.Display();
            Employee o5 = new Employee();
            o5.Display();
        }
    }


    public class Employee
    {
        public string name;
        public string Name
        {
            set
            {
                if (value != "")
                    name = value;
                else
                    Console.WriteLine("Invalid value for name");
            }
            get
            {
                return name;
            }
        }

        public int empNo;
        public int EMPNO
        {
            set
            {
                if (value>0)
                    empNo = value;
                else
                    Console.WriteLine("Invalid value for empNO");
            }
            get
            {
                return empNo;
            }
        }


        public decimal basic;
        public decimal BASIC
        {
            set
            {
                if (value<200000 && value>100)
                    basic = value;
                else
                    Console.WriteLine("Invalid value for basic");
            }
            get
            {
                return basic;
            }
        }

        public short deptNo;
        public short DEPTNO
        {
            set
            {
                if (value > 0)

                    deptNo = value;
                else
                    Console.WriteLine("Invalid value for deptNo");
            }
            get
            {
                return deptNo;
            }
        }

        decimal netsalary;             // declaring in constructor 
        public Employee(int empNo=0,string name="default",decimal basic=0, short deptNo=0)
        {
            this.EMPNO = empNo;
            this.Name = name;
            this.BASIC = basic;
            this.DEPTNO=deptNo;
            this.netsalary = GetNetSalary();
        }

        public decimal GetNetSalary()
        {
            decimal netSalary = basic * 12 + 1000;
            return netSalary;
        }

        public void Display()
        {
            Console.WriteLine(empNo+", "+name+", "+basic+", " +deptNo+", "+netsalary);
        }



    }
}
