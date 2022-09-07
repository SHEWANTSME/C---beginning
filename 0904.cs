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
            bool t = true; // c++처럼 0,1론 안되는듯
            bool xx = false;
            Console.WriteLine("{0}{1}", t, xx);
            Console.WriteLine($"what the fuck {t} + {xx}");// interpolating varaibles

            // c#에는 long long이 없는듯?
        }
    }
}

using System;
using System.Text;
namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            // int n = int.Parse(Console.ReadLine());
            string x = Console.ReadLine();
            int xx = Convert.ToInt32(x);
            //Console.WriteLine(xx.GetType().Name);
            for (int i = 0; i < xx; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = i; k < xx; k++)
                {
                    Console.Write("*");
                }
                //for(int k=i; k < xx; k++)
                //{
                //    Console.Write("*");
                //}
                Console.WriteLine(" ");
            }
            //4
            //34
            //234
            //1234
            //01234

            //  string t = Console.ReadLine();
            //   Console.WriteLine(int.Parse(t).GetType().Name);


        }
    }
}



using System.Text;
using static System.Console;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();

        int N = int.Parse(ReadLine());
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < i; j++)
            {
                sb.Append(" ");
            }
            for (int j = 0; j < N - i; j++)
            {
                sb.Append("*");
            }
            sb.Append("\n");
        }
        Write(sb);
    }
}
