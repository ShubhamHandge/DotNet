using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Arrays
{
    internal class Program
    {
        static void Mainj()
        {
            int[] arr = new int[5];
            //arr[0]....arr[4]
            for(int i = 0; i < arr.Length; i++)
            {
                //arr[i] = int.Parse(Console.ReadLine()!);
                //arr[i] = int.Parse(Console.ReadLine());

                //Console.WriteLine("Enter value for arr[0]:");  // just printing

                //  string concentration
                //Console.Write("Enter value for arr[" + i.ToString() + "]:");

                //placeholder
                //Console.WriteLine("Enter value for arr[{0}]:",i);

                //string interpolation
                Console.Write($"Enter value for arr[{i}]:");  // use variable inside directly

                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            //for (int i = 0; i < arr.Length; i++)            // normal for loop
            //{
            //    Console.WriteLine(arr[i]);
            //}

            foreach(int i in arr)          // for printing 
            {
                Console.WriteLine(i);
            }


        }
    }
}

namespace Arrays2D
{
    internal class Program
    {
        static void Mainy()
        {
            int[,] arr = new int[3,5];
            
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                   Console.Write($"Enter value for arr[{i},{j}]:");
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());

                }
                Console.WriteLine();

            }

            for (int i = 0; i < arr.GetLength(0); i++)            // normal for loop -> for printing
            {
               for(int j = 0; j < arr.GetLength(1); j++)
               {
                    Console.WriteLine($"Value Of Arr[{i},{j}] is:->  {arr[i, j]}");
               }
                Console.WriteLine();
            }

           


        }
    }
}



namespace Arrays3
{
    internal class Program
    {

        static void Main8()
        {
            int[] arr = { 10, 20, 30, 40, 50, 30 };
            int[] arr2 = new int[3] { 1, 2, 3 };

            int pos = Array.IndexOf(arr, 30);
            //- 1 if not found
            Console.WriteLine(pos);

            pos = Array.LastIndexOf(arr, 30);
            Console.WriteLine(pos);

            pos = Array.BinarySearch(arr, 30); //returns a neg number if not found
            Console.WriteLine(pos);
            //Array.Clear(arr);
            // Array.Copy(arr, arr2, arr.Length);
            //Array.ConstrainedCopy
            Array.Reverse(arr);
            Array.Sort(arr);
        }
        static void Main5()
        {
            int[,] arr = new int[4, 3];
            //arr[0,0] arr[0,1] arr[0,2]
            //arr[1,0] arr[1,1] arr[1,2]
            //arr[2,0] arr[2,1] arr[2,2]
            //arr[3,0] arr[3,1] arr[3,2]

            //Console.WriteLine(arr.Rank);  //no of dimensions  - 2
            //Console.WriteLine(arr.Length); //12
            //Console.WriteLine(arr.GetLength(0));  //4 -no of elements in 0th dimension
            //Console.WriteLine(arr.GetLength(1));  //3 - no of elements in 1th dimension

            //Console.WriteLine(arr.GetUpperBound(0));  //3
            //Console.WriteLine(arr.GetUpperBound(1));  //2

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"Enter value for arr[{i},{j}]:");

                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"arr[{i},{j}] is {arr[i, j]}");
                    
                }
                Console.WriteLine();
            }
        }
        static void Mainm()
        {
            //jagged
            int[][] arr = new int[4][];
            int x;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Enter value of X in arr[{i}]: ");
                x = Convert.ToInt32(Console.ReadLine());
                arr[i] = new int[x];
            }

            //arr[0] = new int[3]; // arr[0][0] arr[0][1] arr[0][2]
            //arr[1] = new int[4]; // arr[1][0] arr[1][1] arr[1][2] arr[1][3]
            //arr[2] = new int[2];//  arr[2][0] - arr [2][1]
            //arr[3] = new int[3];//  arr[3][0] arr[3][1] arr[3][2]

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write("enter value for subscript [{0}][{1}] : ", i, j);
                    arr[i][j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.WriteLine("value for subscript {0},{1} is {2}  ", i, j, arr[i][j]);

                }
                Console.WriteLine();
            }
        }
        //static void Mainp()
        //{
        //    Employee[] arrEmps = new Employee[4];

        //    //arrEmps[0] = new Employee();
        //    //arrEmps[1] = new Employee();
        //    //arrEmps[2] = new Employee();
        //    //arrEmps[3] = new Employee();
        //    for (int i = 0; i < arrEmps.Length; i++)
        //    {
        //        arrEmps[i] = new Employee();
        //        //arrEmps[i].Name = Console.ReadLine();   
        //    }
        //}


        //Q.1.- - CDAC YCP has certain number of batches.each batch has certain number of students
        // accept number of batches. for each batch accept number of students.
        // create an array to store mark for each student (1 student has only 1 subject mark)
        //accept the marks.
        //display the marks.
                                 // jagged array example
        static void Mainl()
        {
            int batch, student;
            Console.Write("Enter no of batches: ");
            batch=Convert.ToInt32(Console.ReadLine());

            int[][] arrcdac = new int[batch][];

            for (int i = 0;i < arrcdac.Length;i++)
            {
                Console.Write($"Enter no student in batch[{i+1}]: ");
                student=Convert.ToInt32(Console.ReadLine());
                arrcdac[i]=new int[student];

            }
            Console.WriteLine();

            Console.WriteLine("Enter Marks of each Student: "); 
            for(int i = 0; i<arrcdac.Length; i++) 
            { 
                for(int j = 0;j < arrcdac[i].Length;j++)
                {
                    Console.Write($"Enter marks of student[{j + 1}] of Batch[{i + 1}]: ");
                    arrcdac[i][j]= Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine();
            }

            for (int i = 0; i < arrcdac.Length; i++)
            {
                for (int j = 0; j < arrcdac[i].Length; j++)
                {
                    Console.WriteLine($"Marks of student[{j + 1}] of Batch[{i + 1}] is {arrcdac[i][j]} ");
                    
                }

                Console.WriteLine();
            }

        }

        
    }
}



    //2. Create an array of Employee class objects
    //Accept details for all Employees
    //Display the Employee with highest Salary
    //Accept EmpNo to be searched.Display all details for that employee.


namespace Employee
{
    internal class Program
    {
        static void Main()
        {
            Employee[]arrEmp = new Employee[2];

            for(int i = 0;i<arrEmp.Length ; i++)
            {
                arrEmp[i]=new Employee();

                Console.WriteLine("Enter Employee ID: ");
                arrEmp[i].EMPNO=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Enter Employee Name:-> ");
                arrEmp[i].Name = Convert.ToString(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Enter Employee Basic:-> ");
                arrEmp[i].BASIC = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Enter Employee DeptNo:-> ");
                arrEmp[i].DEPTNO = Convert.ToInt16((Console.ReadLine()));



            }
            Console.WriteLine();
            Console.WriteLine("Details of employees: ");
            for (int i = 0; i < arrEmp.Length; i++)
            {
                arrEmp[i].Display();
            }

            Console.WriteLine();
            //for finding max salary
            Employee tempEmp;
            tempEmp = arrEmp[0];

            for( int i = 1;i<arrEmp.Length; i++) 
            {
                if (arrEmp[i].GetNetSalary()>tempEmp.GetNetSalary())
                {
                    tempEmp = arrEmp[i];
                }
            }
            Console.WriteLine("Highest salary of employee is");
            tempEmp.Display();


            //for search employee through empid

            Console.WriteLine();

            int empid;
            Console.WriteLine("Enter employee ID to search; ");
            empid = Convert.ToInt32(Console.ReadLine());
            for( int i = 0; i<arrEmp.Length; i++)
            {
                if (arrEmp[i].EMPNO==empid)
                {
                    arrEmp[i].Display();
                }
            }

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

        decimal netsalary;             // declaring in constructor 
        //public Employee(int empNo = 0, string name = "default", decimal basic = 0, short deptNo = 0)
        //{
        //    this.EMPNO = empNo;
        //    this.Name = name;
        //    this.BASIC = basic;
        //    this.DEPTNO = deptNo;
        //    this.netsalary = GetNetSalary();
        //}

        public decimal GetNetSalary()
        {
            decimal netSalary = BASIC * 12 + 1000;
            return netSalary;
        }

        public void Display()
        {
            Console.WriteLine(EMPNO + ", " + Name + ", " + BASIC + ", " + DEPTNO + ", " + GetNetSalary());
        }



    }
}
