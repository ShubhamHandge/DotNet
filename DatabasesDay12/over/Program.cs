using over;

Class o = new Class();
o.Display("");
int? j = o.Display(null)!;
namespace over
{
    public class Class
    {
        public int? Display(int? i)
        {
            Console.WriteLine("Display 1" + i);
            return i;
        }

        public void Display(string s)
        {
            Console.WriteLine("Display 1 " + s);
        }
    }
}