using GraverLibrary.Models;
using GraverLibrary.Models.Common;
using GraverLibrary.Services;
using GraverLibrary.Services.Common;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NewGraverForms_Net.Exceptions.Serial;
using NewGraverForms_Net.Logger;
using Serilog;
using System.Diagnostics;
using System.Reflection;



namespace NewGraverForms_Net
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
        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder().ConfigureHostConfiguration(a=>a.AddJsonFile("appSettings.json",optional: false,reloadOnChange: true))
                .ConfigureServices((context, services) => {
       
                    services.AddSingleton<MainForm>();
                    services.AddSingleton(new MaxiGrafConfig(Properties.Settings.Default.apiKey));
                    services.AddSingleton<ConnectionConfig>();
                    services.AddSingleton<MarkInfo>();
                    services.AddSingleton<IBaseMarkerService,MaxiGrafService>();
                });
        }
        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            try
            {
                Exception ex = (Exception)e.ExceptionObject;
                if (ex.GetType() == typeof(SensorUnavailableException))
                {

                }
                switch (ex.GetType().Name)
                {
                    case nameof(SensorUnavailableException):
                        Log.Error("SensorUnavailableException with message\r\n" + ex.Message+"\r\n StackTrace:\r\n"+ex.StackTrace);
                        MessageBox.Show(ex.ToString(), "Something went wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case nameof(HeightOutOfRangeException):
                        Log.Error("HeightOutOfRangeException with message\r\n" + ex.Message + "\r\n StackTrace:\r\n" + ex.StackTrace);
                        MessageBox.Show(ex.ToString(), "Something went wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case nameof(SerialPortException):
                        Log.Error("SerialPortException with message\r\n" + ex.Message + "\r\n StackTrace:\r\n" + ex.StackTrace);
                        MessageBox.Show(ex.ToString(), "Something went wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    default:
                        break;
                }
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
                    //Application.Exit();
                }
            }
        }
    }
}