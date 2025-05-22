namespace SGPOS
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NzU5NjY2QDMyMzAyZTMzMmUzMGZFWU91aXBzOXAwVHJibEJCQ1FIeEFyOGVxME1LVDBBUW1MbFVSSW9BQWc9");
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}