using ExceptionHandling2;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main0()
        {
            Class1 obj = new Class1();
            obj = null;
            int x = Convert.ToInt32(Console.ReadLine());
            obj.P1 = 100 / x;
            Console.WriteLine(obj.P1);

        }
        static void Main1() //simple try block with catch
        {
            Class1 obj = new Class1();
            try
            {
                //obj = null;
                int x = Convert.ToInt32(Console.ReadLine());
                obj.P1 = 100 / x;
                Console.WriteLine(obj.P1);
                Console.WriteLine("No Exceptions");
            }
            catch
            {
                Console.WriteLine("Exception occurred");
            }
        }
        static void Main2()//try with multiple catch blocks
        {
            Class1 obj = new Class1();
            try
            {
                obj = null;
                int x = Convert.ToInt32(Console.ReadLine());
                obj.P1 = 100 / x;
                Console.WriteLine(obj.P1);
                Console.WriteLine("No Exceptions");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("DBException occurred");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("NRException occurred");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("FormatException occurred");
            }
            Console.WriteLine("after catch");
        }

        static void Main3()// catching base class exceptions
        {
            Class1 obj = new Class1();
            try
            {
                obj = null;
                int x = Convert.ToInt32(Console.ReadLine());
                obj.P1 = 100 / x;
                Console.WriteLine(obj.P1);
                Console.WriteLine("No Exceptions");
            }

            //catch (SystemException ex)
            catch (FormatException ex)
            {
                Console.WriteLine("FormatException occurred");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("NRException occurred");
            }
            //catch (DivideByZeroException ex)
            //catch (ArithmeticException ex) 
            catch (SystemException ex) //base class exception has to caught after derived class exceptions
            {
                Console.WriteLine("DBException occurred");
            }
            catch (Exception ex) //catches all unhandled exceptions
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
        static void Main4()// finally block
        {
            Class1 obj = new Class1();
            try
            {
                //obj = null;
                int x = Convert.ToInt32(Console.ReadLine());
                obj.P1 = 100 / x;
                Console.WriteLine(obj.P1);
                Console.WriteLine("No Exceptions");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("FormatException occurred");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("NRException occurred");
            }
            catch (DivideByZeroException ex)
            //catch (ArithmeticException ex) 
            //catch (SystemException ex) //base class exception has to caught after derived class exceptions
            {
                Console.WriteLine("DBException occurred");
            }
            catch (Exception ex) //catches all unhandled exceptions
            {
                Console.WriteLine(ex.Message);
            }
            //finally runs when Exception does not occur, 
            //or Exception occurs and is handled or 
            //Exception occurs and is NOT handled 
            finally
            {
                Console.WriteLine("finally");

            }
            Console.WriteLine("after finally");
        }

        static int F1()// finally block
        {
            Class1 obj = new Class1();
            try
            {
                //obj = null;
                int x = Convert.ToInt32(Console.ReadLine());
                obj.P1 = 100 / x;
                Console.WriteLine(obj.P1);
                Console.WriteLine("No Exceptions");

            }
            catch (FormatException ex)
            {
                Console.WriteLine("FormatException occurred");
                return 1;
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("NRException occurred");
            }
            catch (DivideByZeroException ex)
            //catch (ArithmeticException ex) 
            //catch (SystemException ex) //base class exception has to caught after derived class exceptions
            {
                Console.WriteLine("DBException occurred");
                return 2;

            }
            catch (Exception ex) //catches all unhandled exceptions
            {
                Console.WriteLine(ex.Message);
                return 3;

            }
            //finally runs when Exception does not occur, 
            //or Exception occurs and is handled or 
            //Exception occurs and is NOT handled 
            finally
            {
                Console.WriteLine("finally");

            }
            Console.WriteLine("after finally");
            return 0;
        }

        static void Main9()// nested try block
        {
            Class1 obj = new Class1();
            try
            {
                //obj = null;
                int x = Convert.ToInt32(Console.ReadLine());
                obj.P1 = 100 / x;
                Console.WriteLine(obj.P1);
                Console.WriteLine("No Exceptions");
            }

            catch (FormatException ex)
            {
                try
                {
                    Console.WriteLine("FormatException occurred. Enter only numbers");
                    int x = Convert.ToInt32(Console.ReadLine());
                    obj.P1 = 100 / x;
                    Console.WriteLine(obj.P1);
                }
                catch
                {
                    Console.WriteLine("nested try catch example");
                }
                finally
                {
                    Console.WriteLine("nested try finally example");
                }
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("NRException occurred");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("DBException occurred");
            }
            catch (Exception ex) //catches all unhandled exceptions
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("outer finally");

            }
            Console.ReadLine();
        }
    }

    public class Class1
    {
        private int p1;
        public int P1
        {
            get { return p1; }
            set
            {
                p1 = value;
            }
        }
    }
}
namespace ExceptionHandling2
{
    class Program
    {
        static void Main6()
        {
            Class1 obj = new Class1();
            try
            {
                int x = Convert.ToInt32(Console.ReadLine());
                obj.P1 = x;
                Console.WriteLine(obj.P1);
                Console.WriteLine("No Exceptions");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("FormatException occurred");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("NRException occurred");
            }

            catch (InvalidP1Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ApplicationException ex) //all user defined exceptions that have not been handled before
            {
                Console.WriteLine(ex.Message);
            }
            catch (SystemException ex) //all .net exceptions that have not been handled before
            {
                Console.WriteLine(ex.Message); 
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }

    public class Class1
    {
        private int p1;
        public int P1
        {
            get
            {
                return p1;
            }
            set
            {
                if (value < 100)
                    p1 = value;
                else
                {
                    //dont do this
                    //Console.WriteLine("invalid P1"  );

                    //throw an object of the Exception class or any of its derived classes
                    //Exception ex = new Exception();
                    //Exception ex = new Exception("Invalid P1");
                    //throw ex;
                    //throw new Exception("Invalid P1");

                    //throw new InvalidP1Exception();
                    throw new InvalidP1Exception("Invalid P1");

                }
            }
        }
    }

    public class InvalidP1Exception : ApplicationException
    {
        public InvalidP1Exception(string message) : base(message)
        {

        }
    }


}

// using exception in Employee Example 
namespace Employee
{
    internal class Program
    {
        static void Main()
        {   int eno;
            string? cname;
            Employee employee = new Employee();
            try
            {
                //Employee employee = new Employee(0,"ram",39463,10);       //or

                eno = Convert.ToInt32(Console.ReadLine());
                employee.EMPNO = eno;

                cname = Console.ReadLine();
                employee.Name = cname!;

                employee.Display();
            }
            catch(InvalidEmployeeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
            finally
            {
                Console.WriteLine("finally ");
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
                {
                    throw new InvalidEmployeeException("Invalid Name");      // exception
                     // Console.WriteLine("Invalid value for name");
                }
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
                    throw new InvalidEmployeeException("Invalid EmpNo");
                //Console.WriteLine("Invalid value for empNO");

                // exception
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
        public Employee(int empNo = 1, string name = "default", decimal basic = 0, short deptNo = 0)
        {
            this.EMPNO = empNo;
            this.Name = name;
            this.BASIC = basic;
            this.DEPTNO = deptNo;
            this.netsalary = GetNetSalary();
        }

        public decimal GetNetSalary()
        {
            decimal netSalary = basic * 12 + 1000;
            return netSalary;
        }

        public void Display()
        {
            Console.WriteLine(empNo + ", " + name + ", " + basic + ", " + deptNo + ", " + netsalary);
        }



    }
    public class InvalidEmployeeException : Exception
    {
        public InvalidEmployeeException(string message) : base(message)
        {

        }
    }
   
}
