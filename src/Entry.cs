using System.Diagnostics;
using TrueNASLocker.UI;
namespace TrueNASLocker
{
    internal static class Entry
    {
        [STAThread]
        static void Main()
        {
            Global.LoadSettings();
            ApplicationConfiguration.Initialize();
            Application.Run(new LockerForm());
            Global.SaveSettings(Global.Settings);
        }
    }
}