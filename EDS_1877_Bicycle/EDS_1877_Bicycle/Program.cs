using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDS_1877_Bicycle
{
    class Program
    {
        static void Main(string[] args)
        {
            int inp1 = int.Parse(Console.ReadLine());
            int inp2 = int.Parse(Console.ReadLine());
            if (((inp1 % 2 == 0) || (inp2 % 2 != 0)) )
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
