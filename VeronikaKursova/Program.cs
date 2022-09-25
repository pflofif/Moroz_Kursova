using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using VeronikaKursova.Services;

namespace VeronikaKursova
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
            //ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //var host = CreateHostBuilder().Build();
            //ServiceProvider = host.Services;

            Application.Run(new Form1());
        }
        //public static IServiceProvider ServiceProvider { get; private set; }
        //static IHostBuilder CreateHostBuilder()
        //{
        //    return Host.CreateDefaultBuilder()
        //        .ConfigureServices((_, services) => {
        //            services.AddTransient<IChildCreator, ChildCreator>();
        //            services.AddTransient<Form1>();
        //        });
        //}
    }
}