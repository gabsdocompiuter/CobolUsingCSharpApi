using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using RGiesecke.DllExport;

namespace CSharpApi
{
    public class Class1
    {
        [DllExport(CallingConvention = CallingConvention.Cdecl)]
        public static void ShowMessage()
        {
            MessageBox.Show("Hello!");
        }
    }
}
