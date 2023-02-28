using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._02._23_HW
{
    internal class Program
    {
        static void Swap<T>(ref T a, ref T b)
        {
            T buf = a;
            a = b;
            b = buf;
        }
        static void Main(string[] args)
        {
            int a = 5, b = 10;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Swap(ref a, ref b);
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
