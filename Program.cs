using System;
using System.Windows.Forms;

namespace L0002B_Uppgift_1_Windows_Forms_App_.NET
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Växelberäknaren());
        }
    }
}
