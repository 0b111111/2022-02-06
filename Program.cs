using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _2022_02_06
{
    internal class Program
    {
        static void Main()
        {
            Console.ForegroundColor=ConsoleColor.Green;
            Console.BackgroundColor=ConsoleColor.Black;
            Int64 suma=0;
            for(Int64 i=1;i<=100;i=suma-i)
            {
                Console.WriteLine(suma);
                suma+=i;
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
