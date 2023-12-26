using System.Collections.Generic;


namespace TPL_ParallelExamples
{
    internal class Program
    {
        static void Main()
        {
            int[] arr = new int[10];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Thread.Sleep(1000);
            //    arr[i] = i * 10;
            //    Console.WriteLine(arr[i]);
            //}
            //Parallel.For(0, 10, new Action<int>(i => { Thread.Sleep(1000); arr[i] = i * 10; Console.WriteLine(arr[i]); }));
            //Thread.Sleep(1000);
            //Console.ReadLine();

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            //Parallel.ForEach<int>(arr, new Action<int>(item => { Console.WriteLine(item); }));


            Parallel.Invoke(Func1, Func2, Func3, Func4, Func5);
        }

        static async Task Main2()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            await Parallel.ForEachAsync(arr, async (item, cancellationToken) =>
            {
                await Task.Delay(5000); //simulate delay to fetch data 
                Console.WriteLine($"item is {item}");
                //await Console.Out.WriteLineAsync($"item is {item}");
            });


        }

        static void Func1()
        {
            Console.WriteLine("Func1");
        }
        static void Func2()
        {
            Console.WriteLine("Func2");
        }
        static void Func3()
        {
            Console.WriteLine("Func3");
        }
        static void Func4()
        {
            Console.WriteLine("Func4");
        }
        static void Func5()
        {
            Console.WriteLine("Func5");
        }

    }
}




















//        //https://peterdaugaardrasmussen.com/2021/11/13/csharp-how-to-use-parallel-foreachasync/