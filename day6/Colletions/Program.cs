
using System.Collections;

namespace CollectionsExample
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            ArrayList objArrayList = new ArrayList();
            objArrayList.Add(10);
            objArrayList.Add("shubham");
            objArrayList.Add(1.2345);
            objArrayList.Add(true);

            ArrayList objArrayList2 = new ArrayList();
            objArrayList2.Add(10);

            objArrayList.AddRange(objArrayList2);

            objArrayList.Insert(0, "new");
            objArrayList.InsertRange(0, objArrayList2);

            Console.WriteLine(objArrayList.Count);

            objArrayList.Remove(10); //object to remove
            objArrayList.RemoveAt(0); //index
            objArrayList.RemoveRange(0, 2);

            ArrayList o2 = objArrayList.GetRange(0, 3);

            //objArrayList.SetRange(0, o2);
            //Console.WriteLine(objArrayList.this[0]);
            Console.WriteLine(objArrayList[0]);



            foreach (object item in objArrayList)
            {
                Console.WriteLine(item);
            }
        }

        static void Main()
        {
            ArrayList objArrayList = new ArrayList();
            Console.WriteLine($"count is {objArrayList.Count}, capacity is {objArrayList.Capacity}");

            objArrayList.Add(10);
            Console.WriteLine($"count is {objArrayList.Count}, capacity is {objArrayList.Capacity}");

            objArrayList.Add(10);
            Console.WriteLine($"count is {objArrayList.Count}, capacity is {objArrayList.Capacity}");

            objArrayList.Add(10);
            Console.WriteLine($"count is {objArrayList.Count}, capacity is {objArrayList.Capacity}");

            objArrayList.Add(10);
            Console.WriteLine($"count is {objArrayList.Count}, capacity is {objArrayList.Capacity}");

            objArrayList.Add(10);
            Console.WriteLine($"count is {objArrayList.Count}, capacity is {objArrayList.Capacity}");

            objArrayList.Add(10);
            Console.WriteLine($"count is {objArrayList.Count}, capacity is {objArrayList.Capacity}");

            objArrayList.Add(10);
            Console.WriteLine($"count is {objArrayList.Count}, capacity is {objArrayList.Capacity}");

            objArrayList.Add(10);
            Console.WriteLine($"count is {objArrayList.Count}, capacity is {objArrayList.Capacity}");

            objArrayList.Add(10);
            Console.WriteLine($"count is {objArrayList.Count}, capacity is {objArrayList.Capacity}");

            objArrayList.TrimToSize();

            //objArrayList.Add(10);
            Console.WriteLine($"after Trim - count is {objArrayList.Count}, capacity is {objArrayList.Capacity}");

            objArrayList.Add(10);
            Console.WriteLine($"count is {objArrayList.Count}, capacity is {objArrayList.Capacity}");


        }

        static void Main3()
        {
            // 

            //Hashtable objDictionary = new Hashtable();
            SortedList objDictionary = new SortedList();
            objDictionary.Add(10, "Arshan");
            objDictionary.Add(2, "Izhar");
            objDictionary.Add(3, "Mayuri");
            objDictionary.Add(30, "Shivani");

            objDictionary[5] = "new value";
            objDictionary[2] = "changed value";

            //objDictionary.Remove(key);
            //objDictionary.RemoveAt(index);

            //
            //bool retval =objDictionary.ContainsKey(key)

            IList keyList = objDictionary.GetKeyList();
            //objDictionary.GetValueList

            ICollection keys = objDictionary.Keys;
            //objDictionary.Values;

            foreach (DictionaryEntry item in objDictionary)
            {
                Console.WriteLine($"key is {item.Key}, value is {item.Value}");
            }

        }
        static void Main4()
        {
            Stack s = new Stack();
            s.Push(1);
            Console.WriteLine(s.Peek());
            Console.WriteLine(s.Pop());

            Queue q = new Queue();
            q.Enqueue(1);
            Console.WriteLine(q.Peek());
            Console.WriteLine(q.Dequeue());
        }
        static void Main5()
        {
            List<int> objList = new List<int>();
            objList.Add(10);
            objList.Add(2);
            objList.Add(3);

            foreach (int item in objList)
            {
                Console.WriteLine(item);
            }

            List<Employee> lstEmps = new List<Employee>();
            Employee obj = new Employee();
            obj.Name = "aaa";
            obj.EmpNo = 10; ;
            lstEmps.Add(obj);

            Employee obj2 = new Employee { Name = "ddd", EmpNo = 40 };
            lstEmps.Add(obj2);

            //object initializer
            lstEmps.Add(new Employee { Name = "bbb", EmpNo = 20 });
            lstEmps.Add(new Employee { Name = "ccc", EmpNo = 30 });

            foreach (Employee item in lstEmps)
            {
                Console.WriteLine(item.EmpNo);
                Console.WriteLine(item.Name);

            }

        }
        static void Mainl()
        {
            SortedList<int, string> objDictionary = new SortedList<int, string>();
            objDictionary.Add(10, "Arshan");
            objDictionary.Add(2, "Izhar");
            objDictionary.Add(3, "Mayuri");
            objDictionary.Add(30, "Shivani");
            objDictionary.Add(40, "Vikram");


            objDictionary.Remove(40);

            foreach (KeyValuePair<int, string> item in objDictionary)
            {
                Console.WriteLine($"key is {item.Key}, value is {item.Value}");
            }

            SortedList<int, Employee> o2 = new SortedList<int, Employee>();
            o2.Add(1, new Employee { Name = "aaa", EmpNo = 1 });
            o2.Add(2, new Employee { Name = "bbb", EmpNo = 2 });
            o2.Add(3, new Employee { Name = "ccc", EmpNo = 3 });

            foreach (KeyValuePair<int, Employee> item in o2)
            {
                Console.WriteLine(item.Key); //
                Console.WriteLine(item.Value.Name);
            }

            Stack<int> stack = new Stack<int>();
            Queue<int> queue = new Queue<int>();



        }
    }
    public class Employee
    {
        public int EmpNo { get; set; }
        public string Name { get; set; }

    }
}