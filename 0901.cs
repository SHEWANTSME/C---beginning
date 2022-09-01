using System;// 이게 주석인것은 same
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    class Program
    {
        static void Main() // string[] args 써도되고 안써도 되는듯?
        {
            Console.WriteLine("Hello World!");
            int a = 10;
            Console.WriteLine(a + 3);
            decimal dex = 1032.303m;
            Console.WriteLine(dex + 33.233m);
            Console.Write(dex + " ");
            Console.Write(dex + " ");
            bool t = true;
            bool xx = false;
            Console.WriteLine("{0}{1}" , t,xx);
            Console.WriteLine($"what the fuck {t} + {xx}");// interpolating varaibles
            // c#에는 long long이 없는듯?
        }
    }
}
