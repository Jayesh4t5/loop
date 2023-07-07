using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop
{
    internal class while_4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = Convert.ToInt32(Console.ReadLine());

            int i = 1;
            while (i <= 10) 
            {
                int res = num * i;
                Console.WriteLine($"{res}");
                i++;
            }
        }
    }
}
