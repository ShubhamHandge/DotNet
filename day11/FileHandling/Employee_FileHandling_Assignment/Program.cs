namespace Employee_FileHandling_Assignment
{
    internal class Program
    {
        static void Main()
        {
            Create_Directory();
            WriteIntoEmployee();
            Console.WriteLine("File Read Successfully");
            Read_File();



        }
        private static void Create_Directory()
        {
            Directory.CreateDirectory(@"F:\.Net\day11\FileHandling\Employee_FileHandling");

        }
        private static void WriteIntoEmployee()
        {
            StreamWriter writer = File.CreateText("F:\\.Net\\day11\\FileHandling\\Employee_FileHandling\\Employee.txt");
            
            Employee obj;
            obj = AddDataIntoEmployee();
            writer.WriteLine($"Name:{obj.Name},EmpNo:{obj.EMPNO},Basic;{obj.BASIC},dept:{obj.DEPTNO}");
            Console.WriteLine("File Update Succesfully");
            writer.Close();

        }
        private static void Read_File()
        {
            string s;
            StreamReader reader = File.OpenText("F:\\.Net\\day11\\FileHandling\\Employee_FileHandling\\Employee.txt");
            while ((s = reader.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
            reader.Close();
        }

        private static Employee AddDataIntoEmployee()
        {
            Employee emp;

            int empNo;
            string name;
            decimal basic;
            short deptNo;

            Console.Write("Enter EmpNo:");
           empNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name:");
            name = Console.ReadLine();

            Console.Write("Enter Basics: ");
            basic = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter deptNo: ");
            deptNo = (short)Convert.ToInt32(Console.ReadLine());

            emp = new Employee(empNo,name,basic,deptNo);
            return emp;
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
                if (value > 0)
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
                if (value < 200000 && value > 100)
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

        


        public Employee(int empNo = 1, string name = "default", decimal basic = 200, short deptNo = 3)
        {
            this.EMPNO = empNo;
            this.Name = name;
            this.BASIC = basic;
            this.DEPTNO = deptNo;
           
        }

       

        public void Display()
        {
            Console.WriteLine(empNo + ", " + name + ", " + basic + ", " + deptNo + " ");
        }



    }
}