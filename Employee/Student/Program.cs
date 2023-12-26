namespace Student
{
    internal class Program
    {
        static void Main()
        {
            Student o1 = new Student(1,"shubh",55,35,76);
            o1.Display();
            Student o2 = new Student(2, "ram", 45, 5, 66);
            o2.Display();
            Student o3 = new Student(3, "shan", 32, 23, 76);
            o3.Display();
            Student o4 = new Student(4, "dhan", 11, 12, 76);
            o4.Display();
            Student o5 = new Student(5, "ganman", 90, 43, 17);
            o5.Display();


        }
    }

    public class Student
    {
        public string name;
        public string NAME
        {
            set
            {
                if (value.Length <= 50)
                    name = value;
                else
                    Console.WriteLine("Invalid value for name");
            }

            get
            {
                return name;
            }

        }

        public int rollNo;
        public int ROLLNO
        {

            set
            {
                if (value > 0)
                    rollNo = value;
                else
                    Console.WriteLine("Invalid value for rollno");

            }
            get
            {
                return rollNo;
            }
        }

        public decimal subject1marks;
        public decimal SUBJECT1MARKS
        {
            set
            {
               if(value > 0 && value<100)
                    subject1marks = value;
                else
                    Console.WriteLine("invalid marks");
            }
            get
            { 
               return subject1marks; 
            }

            
            
        }

        public decimal subject2marks;
        public decimal SUBJECT2MARKS
        {
            set
            {
                if (value > 0 && value < 100)
                    subject2marks = value;
                else
                    Console.WriteLine("invalid marks");
            }
            get
            {
                return subject2marks;
            }

        }

        public decimal subject3marks;
        public decimal SUBJECT3MARKS
        {
            set
            {
                if (value > 0 && value < 100)
                    subject3marks = value;
                else
                    Console.WriteLine("invalid marks");
            }
            get
            {
                return subject3marks;
            }

        }
        decimal per;
        public Student(int rollNo,string name,decimal subject1marks,decimal subject2marks, decimal subject3marks)
        {
            this.ROLLNO = rollNo;
            this.NAME = name;
            this.SUBJECT1MARKS = subject1marks;
            this.SUBJECT2MARKS = subject2marks;
            this.SUBJECT3MARKS = subject3marks;
            this.per = percentage();
        }

        public decimal percentage()
        {
            decimal per =( subject1marks + subject2marks + subject3marks) / 3;
            return per;
        }

        public void Display()
        {
            Console.WriteLine(rollNo + ", " + name + ", " + subject1marks + ", " + subject2marks + ", " + subject3marks+", "+per);
        }






    }
}