using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDS_1000_ABProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int iRes = 0;
            foreach (string str in Console.ReadLine().Split(' '))
            {
                iRes += int.Parse(str);
            }
            Console.Write(iRes);
        }
    }
}
