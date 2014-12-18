using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDS_1409_TwoBandits
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strs = Console.ReadLine().Split(' ');
            List<int> i = new List<int>();
            int iAll = 0;
            foreach(string str in strs)
            {
                i.Add(int.Parse(str));
                iAll += i.Last();
            }
            iAll--;
            foreach (int iTmp in i)
            {
                Console.Write((iAll - iTmp).ToString() + ' ');
            }
            
        }
    }
}
