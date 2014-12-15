using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDS_1785_Localization
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = new List<int>();
            List<string> strs = new List<string>();

            strs.Add("few");
            ints.Add(1);
            strs.Add("several");
            ints.Add(5);
            strs.Add("pack");
            ints.Add(10);
            strs.Add("lots");
            ints.Add(20);
            strs.Add("horde");
            ints.Add(50);
            strs.Add("throng");
            ints.Add(100);
            strs.Add("swarm");
            ints.Add(250);
            strs.Add("zounds");
            ints.Add(500);
            strs.Add("legion");
            ints.Add(1000);

            int n = int.Parse(Console.ReadLine());

            int iQuan = strs.Count - 1;
            if (n >= ints[iQuan])
                Console.WriteLine(strs[iQuan]);
            else
                for (int i = iQuan; i > 0; i--)
                {
                    if ((n >= ints[i - 1]) && (n < ints[i]))
                    {
                        Console.WriteLine(strs[i-1]);
                        i = -1;
                    }
                }
        }
    }
}
