using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapWindowsForm2
{
    internal class TinhToan
    {
        public static void Cong(int a, int b, ref double s)
        {
            s = a + b;
        }

        public static void Tru(int a, int b, ref double s)
        {
            s = a - b;
        }

        public static void Nhan(int a, int b, ref double s)
        {
            s = a * b;
        }
        public static void Chia(int a, int b, ref double s)
        {
            s = (double)a / b;
        }
    }
}
