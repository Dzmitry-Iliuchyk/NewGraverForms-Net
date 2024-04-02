using GraverLibrary.Models;
using GraverLibrary.Models.Common;
using GraverLibrary.Services;
using GraverLibrary.Services.Common;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NewGraverForms_Net.Logger;
using Serilog;
using System.Text;
using System.Text.Unicode;



namespace NewGraverForms_Net
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        { 
            Logging.ConfigureLogger();
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            // Add the event handler for handling non-UI thread exceptions to the event.
            AppDomain.CurrentDomain.UnhandledException +=
                new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
            var host = CreateHostBuilder().Build();

            ServiceProvider = host.Services;

            Application.Run(ServiceProvider.GetRequiredService<MainForm>());
        }


        public static IServiceProvider ServiceProvider { get; private set; }

        private static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder().ConfigureHostConfiguration(a => a.AddJsonFile("appSettings.json", optional: false, reloadOnChange: true))
                .ConfigureServices((context, services) =>
                {

                    services.AddSingleton<MainForm>();
                    services.AddSingleton(new MaxiGrafConfig(
                        context.Configuration.GetSection("GraverConfig").GetValue<string>("ApiKey"),
                        context.Configuration.GetSection("GraverConfig").GetValue<float>("FocusHeight")));
                    services.AddSingleton<ConnectionConfig>();
                    services.AddSingleton<MarkInfo>();
                    services.AddSingleton<IBaseMarkerService, MaxiGrafService>();
                });
        }
        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            try
            {
                Exception ex = (Exception)e.ExceptionObject;

                Log.Error("Unhandled exception message: \r\n" + ex.Message + "\r\n StackTrace:\r\n" + ex.StackTrace);
                MessageBox.Show("The program will be closed!\r\n"+ex.ToString(), "Something went wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception exc)
            {
                try
                {
                    MessageBox.Show("Fatal Non-UI Error",
                        "Fatal Non-UI Error. Could not write the error to the event log. Reason: "
                        + exc.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                finally
                {
                    Application.Exit();
                }
            }
        }
    }
}