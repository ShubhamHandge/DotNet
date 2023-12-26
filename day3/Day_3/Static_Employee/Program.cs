

namespace Static_Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            
            Employee e = new Employee( "Rushikesh", 10000, 101);
            e.Display();


            Employee e1 = new Employee( "Shubh", 10000);
            e1.Display();

            Employee e2 = new Employee( "Rushikesh");
            e2.Display();

            Employee e3 = new Employee();
            e3.Display();

            Employee e4 = new Employee();
            Employee e5 = new Employee();
            Employee e6 = new Employee();

            Console.WriteLine();

            Console.WriteLine(e4.newempId);
            Console.WriteLine(e5.newempId);
            Console.WriteLine(e6.newempId);

            Console.WriteLine();

            Console.WriteLine(e6.newempId);
            Console.WriteLine(e5.newempId);
            Console.WriteLine(e4.newempId);


        }
    }

    public class Employee
    {
        

        public int newempId;
        /*public int EmpId
        {
            set
            {
                if (value > 0)
                {
                    empId = value;
                }

            }

            get
            {
                return empId;
            }
        }*/

        public static int empId1=1;
        public int EmpId1
        {
            set
            {
                empId1= value;
            }
         
            get
            {
                return empId1;
            }
        }

        public string name;
        public string Name
        {
            set
            {
                name = value;
            }

            get
            {
                return name;
            }
        }

        public decimal basic;
        public decimal Basic
        {
            set
            {
                if (value > 0 && value < 100000)
                {
                    basic = value;
                }
                else
                {
                    Console.WriteLine("Invalid Basics.");
                }

            }

            get
            {
                return basic;
            }
        }

        public short deptNo;
        public short DeptNo
        {
            set
            {
                if (value > 0)

                {
                    deptNo = value;
                }
                else
                {
                    Console.WriteLine("Invalid Dept Number");
                }
            }

            get
            {
                return deptNo;
            }
        }

        public decimal NetSalary(decimal basic)
        {
            decimal netsalary = basic-basic/18;
            decimal netsalary1 = Decimal.Round(netsalary, 5);
            return netsalary1;
        }

        decimal net;
        /*
        public Employee(int empId = 1, string name = "default", decimal basic = 100, short deptNo = 10)
        {
            this.EmpId = empId;
            this.Name = name;
            this.Basic = basic;
            this.DeptNo = deptNo;
            this.net = NetSalary(basic);


        }*/

        public Employee(string name="default",decimal basic=100,short deptNo=10)
        {
            //this.EmpId1 = empId1++;
            newempId=empId1++;
            this.Name = name;
            this.Basic = basic;
            this.DeptNo = deptNo;
            this.net = NetSalary(basic);
        }

        
        public void Display()
        {
            Console.WriteLine("EmpId:" +newempId+ "-- Name: " +name+ "-- Basic:" +basic+ "-- DeptNo: " +deptNo+ "-- NetSalary: "+NetSalary(basic));
        }
       
        /*
        public Employee(int empId = 0, string name = "default", decimal basic = 0)
        {
            this.empId = empId;
            this.name = name;
            this.basic = basic;
            this.net = NetSalary(basic);

            Console.WriteLine("EmpId: " + empId + "-- Name: " + name + "-- Basic: " + basic + "-- NetSalary: " + NetSalary(basic));
        }

        public Employee(int empId = 0, string name = "default")
        {
            this.empId = empId;
            this.name = name;
            this.net = NetSalary(basic);

            Console.WriteLine("EmpId: " + empId + "-- Name: " + name + "-- NetSalary: " + NetSalary(basic));
        }

        public Employee(int empId = 0)
        {
            this.empId = empId;
            this.net = NetSalary(basic);

            Console.WriteLine("EmpId: " + empId + "NetSalary: " + NetSalary(basic));
        }
        */
    }
}