namespace NullableType
{
    internal class Program
    {
        static void Main1()
        {
            //int? i = 10;
            int? i = null;

            int j;
            //if(i != null) 
            //    j =(int) i;
            //else
            //    j = 0;

            //if(i.HasValue)
            //    j = i.Value;
            //else
            //    j = 0;

            //j = i.GetValueOrDefault();
            //j = i.GetValueOrDefault(10);

            j = i ?? 0; //null coalescing operator

            Console.WriteLine(j);
        }
        static void Main()
        {
            string s = "aaa";
            Console.WriteLine(s);

        }
    }
}