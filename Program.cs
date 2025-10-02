namespace TrueNASLocker
{
    internal static class Program
    {
        public static readonly string VERSION = "v20251001_2112";

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new LockerForm());
        }
    }
}