namespace LinqExample 
{
    internal class Program
    {
        static List<Employee> lstEmp = new List<Employee>();
        static List<Department> lstDept = new List<Department>();
        public static void AddRecs()
        {
            lstDept.Add(new Department { DeptNo = 10, DeptName = "SALES" });
            lstDept.Add(new Department { DeptNo = 20, DeptName = "MKTG" });
            lstDept.Add(new Department { DeptNo = 30, DeptName = "IT" });
            lstDept.Add(new Department { DeptNo = 40, DeptName = "HR" });

            lstEmp.Add(new Employee { EmpNo = 1, Name = "Vikram", Basic = 10000, DeptNo = 10, Gender = "M" });
            lstEmp.Add(new Employee { EmpNo = 2, Name = "Vishal", Basic = 11000, DeptNo = 10, Gender = "M" });

            lstEmp.Add(new Employee { EmpNo = 3, Name = "Abhijit", Basic = 12000, DeptNo = 20, Gender = "M" });
            lstEmp.Add(new Employee { EmpNo = 4, Name = "Mona", Basic = 11000, DeptNo = 20, Gender = "F" });
            lstEmp.Add(new Employee { EmpNo = 5, Name = "Shweta", Basic = 12000, DeptNo = 20, Gender = "F" });

            lstEmp.Add(new Employee { EmpNo = 6, Name = "Sanjay", Basic = 11000, DeptNo = 30, Gender = "M" });
            lstEmp.Add(new Employee { EmpNo = 7, Name = "Arpan", Basic = 10000, DeptNo = 30, Gender = "M" });

            lstEmp.Add(new Employee { EmpNo = 8, Name = "Shraddha", Basic = 11000, DeptNo = 40, Gender = "F" });
        }
        static void Main0()
        {
            AddRecs();

            //var returnvalue = from single_object in collection select something;

            var emps = from emp in lstEmp select emp;
            //IEnumerable<Employee> emps = from emp in lstEmp select emp;

            foreach (var item in emps)
            {
                // Console.WriteLine(item.Name);
                //Console.WriteLine(item.EmpNo);
                Console.WriteLine(item);
            }
        }
        static void Main1()
        {
            AddRecs();

            //var emps = from emp in lstEmp select emp.Name;
            var emps = from emp in lstEmp select emp.EmpNo;

            foreach (var item in emps)
            {
                Console.WriteLine(item);
            }
        }
        static void Main3()
        {
            AddRecs();

            //var emps = from emp in lstEmp select emp.Name;
            //var emps = from emp in lstEmp select emp.EmpNo;

            var emps = from emp in lstEmp select new { emp.Name, emp.EmpNo };


            foreach (var item in emps)
            {
                Console.WriteLine(item.EmpNo);
                Console.WriteLine(item.Name);
            }
        }
        static void Main4()
        {
            AddRecs();
            var emps = from emp in lstEmp
                       where emp.Basic > 10000
                       select emp;

            //var emps = from emp in lstEmp
            //           where emp.Basic > 10000 && emp.Basic < 12000
            //           select emp;

            //var emps = from emp in lstEmp
            //           where emp.Name.StartsWith("V")
            //           select emp;
            foreach (var emp in emps)
            {
                Console.WriteLine(emp);
            }

            Console.ReadLine();

        }
        static void Main5()
        {
            AddRecs();


            //var emps = from emp in lstEmp
            //               //where emp.Basic > 10000
            //           orderby emp.Name
            //           select emp;
            //var emps = from emp in lstEmp
            //           orderby emp.Name descending
            //           select emp;

            var emps = from emp in lstEmp
                       orderby emp.DeptNo ascending, emp.Name descending
                       select emp;


            foreach (var emp in emps)
            {
                Console.WriteLine(emp);
            }

            Console.ReadLine();

        }
        static void Maina()
        {
            AddRecs();
            //var emps = from emp in lstEmp
            //           join dept in lstDept
            //                 on emp.DeptNo equals dept.DeptNo
            //           select emp;

            //var emps1 = from emp in lstEmp
            //            join dept in lstDept
            //                  on emp.DeptNo equals dept.DeptNo
            //            select dept;

            var emps2 = from emp in lstEmp
                        join dept in lstDept
                              on emp.DeptNo equals dept.DeptNo
                        select new { emp, dept };



            //var emps3 = from emp in lstEmp
            //            join dept in lstDept
            //                  on emp.DeptNo equals dept.DeptNo
            //            select new { emp.Name, dept.DeptName };
            foreach (var item in emps2)
            {
                Console.WriteLine(item.emp.Name);
                Console.WriteLine(item.dept.DeptName);
            }
            foreach (var item in emps2)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }

    public class Employee
    {
        public int EmpNo { get; set; }
        public string Name { get; set; }
        public decimal Basic { get; set; }
        public int DeptNo { get; set; }
        public string Gender { get; set; }
        public override string ToString()
        {
            string s = Name + "," + EmpNo.ToString() + "," + Basic.ToString() + "," + DeptNo.ToString();
            return s;
        }
    }
    public class Department
    {
        public int DeptNo { get; set; }
        public string DeptName { get; set; }
    }
}


namespace LinqExample2
{
    internal class Program
    {
        static List<Employee> lstEmp = new List<Employee>();
        static List<Department> lstDept = new List<Department>();
        public static void AddRecs()
        {
            lstDept.Add(new Department { DeptNo = 10, DeptName = "SALES" });
            lstDept.Add(new Department { DeptNo = 20, DeptName = "MKTG" });
            lstDept.Add(new Department { DeptNo = 30, DeptName = "IT" });
            lstDept.Add(new Department { DeptNo = 40, DeptName = "HR" });

            lstEmp.Add(new Employee { EmpNo = 1, Name = "Vikram", Basic = 10000, DeptNo = 10, Gender = "M" });
            lstEmp.Add(new Employee { EmpNo = 2, Name = "Vishal", Basic = 11000, DeptNo = 10, Gender = "M" });

            lstEmp.Add(new Employee { EmpNo = 3, Name = "Abhijit", Basic = 12000, DeptNo = 20, Gender = "M" });
            lstEmp.Add(new Employee { EmpNo = 4, Name = "Mona", Basic = 11000, DeptNo = 20, Gender = "F" });
            lstEmp.Add(new Employee { EmpNo = 5, Name = "Shweta", Basic = 12000, DeptNo = 20, Gender = "F" });

            lstEmp.Add(new Employee { EmpNo = 6, Name = "Sanjay", Basic = 11000, DeptNo = 30, Gender = "M" });
            lstEmp.Add(new Employee { EmpNo = 7, Name = "Arpan", Basic = 10000, DeptNo = 30, Gender = "M" });

            lstEmp.Add(new Employee { EmpNo = 8, Name = "Shraddha", Basic = 11000, DeptNo = 40, Gender = "F" });
        }

        static Employee GetEmployee1(Employee emp)
        {
            return emp;
        }
        static void Main0()
        {
            AddRecs();

            //var returnvalue = from single_object in collection select something;
            // Query
            var emps = from emp in lstEmp select emp;
            foreach (var item in emps)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            //Function
            var emps_func = lstEmp.Select(GetEmployee1);
            foreach (var item in emps_func)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //Anonymous 
            var emps_anon = lstEmp.Select(delegate (Employee emp)
            {
                return emp;
            });
            foreach (var item in emps_anon)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //Lambda
            var emps_lambda = lstEmp.Select(e => e);
            foreach (var item in emps_lambda)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();


        }

        static string GetEmployee2(Employee emp)
        {
            return emp.Name;
        }
        static void Main1() //trying to pass single column 
        {
            AddRecs();

            //var returnvalue = from single_object in collection select something;
            // Query
            var emps = from emp in lstEmp select emp;
            foreach (var item in emps)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            //Function will not avail/work in single column passing 
            var emps_func = lstEmp.Select(GetEmployee1);
            Console.WriteLine();

            //Anonymous 
            var emps_anon = lstEmp.Select(delegate (Employee emp)
            {
                return emp.Name;
            });
            foreach (var item in emps_anon)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //Lambda
            var emps_lambda = lstEmp.Select(e => e.Name);
            foreach (var item in emps_lambda)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();


        }

        static void Main3() //trying to pass multiple column 
        {
            AddRecs();

            //var returnvalue = from single_object in collection select something;

            // Query
            //var emps = from emp in lstEmp select emp;
            //foreach (var item in emps)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();

            //Function  will not avail/work in mulyiple column passing 
            var emps_func = lstEmp.Select(GetEmployee1);


            //Anonymous 
            var emps_anon = lstEmp.Select(delegate (Employee emp)
            {
                return new { emp.Name, emp.EmpNo };
            });
            foreach (var item in emps_anon)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //Lambda
            var emps_lambda = lstEmp.Select(e => new { e.Name, e.EmpNo });
            foreach (var item in emps_lambda)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();


        }

        static bool IsBasicGreaterThan10000(Employee emp)
        {
            if (emp.Basic > 10000)
                return true;
            else
                return false;
            //OR
            //return emp.Basic > 10000;
        }
        static void Main()
        {
            AddRecs();

            //var emps = from emp in lstEmp where emp.Basic > 10000 select emp;
            //Function 
            var emps = lstEmp.Where(IsBasicGreaterThan10000);
            var emps1 = lstEmp.Where(e => e.Basic > 10000);
            var emps2 = lstEmp.Where(e => e.Basic > 10000).Select(e => e);
            var emps3 = lstEmp.Select(e => e).Where(e => e.Basic > 10000);


            //var emps = from emp in lstEmp where emp.Basic > 10000 select emp.Basic;
            //where part function returns Iennumerable of employee and select part outer function takes where part return as input
            //and returns Iennumerable of Decimal to emps 
            var emps2a = lstEmp.Where(e => e.Basic > 10000).Select(e => e.Basic);
            //where part function returns Iennumerable of basic and select part outer function takes where part return as input
            //and returns Iennumerable of Employee to emps so taking a column as input cant return a whole object so ERROR
            //var emps3a = lstEmp.Select(e => e.Basic).Where(e => e.Basic > 10000); // ERROR 
            // OR
            var emps4a = lstEmp.Select(e => e.Basic).Where(e => e > 10000);


            //var emps = from emp in lstEmp where emp.Basic > 10000 select emp.Name;
           // var emps4aa = lstEmp.Select(e => e.Name).Where(e => e > 10000);  //ERROR 


            foreach (var item in emps)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //Anonymous will be the same as writing a function so
            var emps_anon = lstEmp.Select(delegate (Employee emp)
            {
                return new { emp.Name, emp.EmpNo };
            });
            foreach (var item in emps_anon)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //Lambda
            var emps_lambda = lstEmp.Select(e => new { e.Name, e.EmpNo });
            foreach (var item in emps_lambda)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();


        }
    }

    public class Employee
    {
        public int EmpNo { get; set; }
        public string Name { get; set; }
        public decimal Basic { get; set; }
        public int DeptNo { get; set; }
        public string Gender { get; set; }
        public override string ToString()
        {
            string s = Name + "," + EmpNo.ToString() + "," + Basic.ToString() + "," + DeptNo.ToString();
            return s;
        }
    }
    public class Department
    {
        public int DeptNo { get; set; }
        public string DeptName { get; set; }
    }
}