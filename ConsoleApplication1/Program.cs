using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            shotechs.output();

            Console.WriteLine("Type 1st number");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type 2nd number");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("///////////////////////");
            Console.WriteLine("// Choose a option //");
            Console.WriteLine("///////////////////////");
            Console.WriteLine("1 - addition");
            Console.WriteLine("2 - subtration ");
            Console.WriteLine("3 - multification");
            Console.WriteLine("4 - division");
            int z = Convert.ToInt32(Console.ReadLine());
            switch (z)
            {
                case 1:
                    Console.WriteLine("///////////////////////");
                    Console.WriteLine("// Result //");
                    Console.WriteLine("///////////////////////");
                    Console.WriteLine(x + y);
                    break;
                case 2:
                    Console.WriteLine("///////////////////////");
                    Console.WriteLine("// Result //");
                    Console.WriteLine("///////////////////////");
                    Console.WriteLine(x - y);
                    break;
                case 3:
                    Console.WriteLine("///////////////////////");
                    Console.WriteLine("// Result //");
                    Console.WriteLine("///////////////////////");
                    Console.WriteLine(x * y);
                    break;
                case 4:
                    Console.WriteLine("///////////////////////");
                    Console.WriteLine("// Result //");
                    Console.WriteLine("///////////////////////");
                    Console.WriteLine(x / y);
                    break;
            }
            Console.ReadKey(true);
        }
    }
}
