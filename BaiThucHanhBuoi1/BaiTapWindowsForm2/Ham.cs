using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapWindowsForm2
{
    internal class Ham
    {
        public static void NoiChuoi(string ho, string ten, string s)
        { 
            s = ho + " " + ten;
        }

        public static long GiaiThua(int n, long gt)
        {
            gt = 1;
            for (int i = 1; i <= n; i++)
            {
                gt *= i;
            }
            return gt;
        }
    }
}
