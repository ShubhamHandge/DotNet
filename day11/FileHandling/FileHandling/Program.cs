namespace FileHandling
{
    internal class Program
    {
        static void Main()
        {
            Create_Directory();
            WriteToTextFileFormatted();
            ReadFromTextFileFormatted();
            WriteToTextFileBinary();
            ReadToTextFileBinary();
        }
        private  static void Create_Directory()
        {

            //Directory.CreateDirectory("C:\\new");
            Directory.CreateDirectory(@"F:\.Net\day11\aaa");


            //DirectoryInfo dir = new DirectoryInfo("C:\\aaaa");

            //dir.

        }

        private static void WriteToTextFileFormatted()
        {
           
            StreamWriter writer = File.CreateText("F:\\.Net\\day11\\aaa\\a.txt");
            writer.WriteLine("line 1");
            writer.WriteLine("Line 2");
            writer.WriteLine("line 3");

            writer.Close();
        }

        private static void ReadFromTextFileFormatted()
        {
            string s;
            StreamReader reader = File.OpenText("F:\\.Net\\day11\\aaa\\a.txt");
            while ((s = reader.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
            reader.Close();
        }
        private static void WriteToTextFileBinary()
        {
            string s = "Hello";
            int i = 100;
            bool b = true;

            FileInfo f = new FileInfo("F:\\.Net\\day11\\aaa\\a.dat");

            BinaryWriter binary_writer = new BinaryWriter(f.OpenWrite());
            binary_writer.Write(s);
            binary_writer.Write(i);
            binary_writer.Write(b);

            binary_writer.Close();
        }
        private static void ReadToTextFileBinary()
        {
            string s;
            int i;
            bool b;

            FileInfo f = new FileInfo("F:\\.Net\\day11\\aaa\\a.dat");

            BinaryReader binary_reader = new BinaryReader(f.OpenRead());

            s = binary_reader.ReadString();
            i = binary_reader.ReadInt32();
            b = binary_reader.ReadBoolean();

            Console.WriteLine(s);
            Console.WriteLine(i.ToString());
            Console.WriteLine(b.ToString());

            binary_reader.Close();
        }


    }
}