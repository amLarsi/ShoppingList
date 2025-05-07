using System;
using System.Windows.Forms;

namespace Apolonio
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Display());
        }
    }
}
