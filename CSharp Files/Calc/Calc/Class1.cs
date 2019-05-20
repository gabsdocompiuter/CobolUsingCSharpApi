using RGiesecke.DllExport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Calc
{
    public class Class1
    {
        [DllExport(CallingConvention = CallingConvention.Cdecl)]
        public static void TwoStringParams(string a, string b)
        {
            MessageBox.Show($"a: {a}, b:{b}");
        }

        [DllExport(CallingConvention = CallingConvention.Cdecl)]
        public static void TwoIntParams(int a, int b)
        {
            MessageBox.Show($"a: {a}, b:{b}");
        }
    }
}
