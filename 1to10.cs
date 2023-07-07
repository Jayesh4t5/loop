using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop
{
    internal class _1to10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <=10; i++) 
            {
                
                Console.WriteLine($" {num*i}");


            }
        }
    }
}
