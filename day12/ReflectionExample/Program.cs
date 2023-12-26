using System.Reflection;
namespace ReflectionExample
{
    internal class Program
    {
        static void Main()
        {
            //Assembly asm = Assembly.GetAssembly(typeof( int));
            //Assembly asm = Assembly.GetExecutingAssembly();
            //Assembly asm = Assembly.GetCallingAssembly();  //asm3
            //Assembly asm = Assembly.GetEntryAssembly();  //asm1
            //asm1 -> asm2 -> asm3 -> [asm4]

            Assembly asm = Assembly.LoadFrom("D:\\Trainings\\YcpOct23\\Day2\\Functions\\bin\\Debug\\net7.0\\Functions.dll");
            //Assembly asm2 = Assembly.LoadFrom(@"D:\Trainings\YcpOct23\Day2\Functions\bin\Debug\net7.0\Functions.dll");

            //Console.WriteLine(asm.FullName);
            Console.WriteLine(asm.GetName().Name);
            Type[] arrTypes = asm.GetTypes();
            foreach (Type t in arrTypes)
            {
                Console.WriteLine("   " + t.Name);
                MethodInfo[] arrMethods = t.GetMethods();
                foreach (MethodInfo m in arrMethods)
                {
                    Console.WriteLine("       " + m.Name);
                    ParameterInfo[] arrParameters = m.GetParameters();
                    foreach (ParameterInfo p in arrParameters)
                    {
                        Console.WriteLine("           " + p.Name);
                    }
                }
            }
        }
    }
}