using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _2022_02_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor=ConsoleColor.Green;
            int suma=0;
            for(int i=1;i<=100;i=suma-i)
            {
                Console.WriteLine("suma: "+suma+"\ni: "+i);
                suma+=i;
            }
            //float myNum=1500000000;//,myNoNum=1500000000;
            //Console.WriteLine(((decimal)myNum));
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}