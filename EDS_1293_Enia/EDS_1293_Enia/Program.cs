using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDS_1293_Enia
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strs = Console.ReadLine().Split(' ');
            //List<int> Ns = new List<int>();
            int res = 2;
            foreach (string s in strs)
                res *= int.Parse(s); 
            Console.WriteLine(res);
        }
    }
}
