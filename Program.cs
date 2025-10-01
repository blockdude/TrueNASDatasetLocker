
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace TrueNASLocker
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new LockerForm());
        }
    }
}