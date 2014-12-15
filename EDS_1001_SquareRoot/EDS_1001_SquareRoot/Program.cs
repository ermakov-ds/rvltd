using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDS_1001_SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Globalization.NumberFormatInfo nfi = System.Globalization.NumberFormatInfo.InvariantInfo;
            List<string> strs = new List<string>();
            string[] inputStr = Console.In.ReadToEnd().Split(new char[] { ' ', '\n', '\r', '\t' });
            foreach (string str in inputStr)
            {
                if (str != string.Empty)
                    strs.Add(str);
            }
            for (int i = strs.Count - 1; i > -1; i--)
            {
                double sqrt = Math.Sqrt(double.Parse(strs[i]));
                Console.WriteLine(string.Format("{0:F4}", sqrt));
            }
        }
    }
}