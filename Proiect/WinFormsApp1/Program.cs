using DataAccess;
using Microsoft.Extensions.DependencyInjection;


namespace WinFormsApp1
{
    internal static class Program
    {
        public static ServiceProvider ServiceProvider { get; set; }
        private static void Config()
        {
            var services=new ServiceCollection();
            services.AddDbContext<DBContext>();
            ServiceProvider = services.BuildServiceProvider();
        }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Config();
            ApplicationConfiguration.Initialize();
            Application.Run(new WarframeTracker());
        }
    }
}