using NFramework.App;

namespace NFramework
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            new Autoload();
            //app.Run();

          //Module.GetModules();
            //mod.
            //Application.Run(new Form1());
            //MessageBox.Show("tét");
        }
    }
}