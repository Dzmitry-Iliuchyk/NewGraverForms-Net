using GraverLibrary.Models;
using GraverLibrary.Models.Common;
using GraverLibrary.Services;
using GraverLibrary.Services.Common;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NewGraverForms_Net.Models;
using NewGraverForms_Net.Services.Common;
using NewGraverForms_Net.Services.Implementations;
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
                    services.AddLogging(builder=>
                    {
                        builder.ClearProviders();
                        var path = Path.Combine(Application.StartupPath, "Logs", DateTime.Now.ToShortDateString()+".log");
                        var directoryPath = Path.GetDirectoryName(path);
                        if (!Directory.Exists(directoryPath))
                        {
                            Directory.CreateDirectory(directoryPath);
                        }
                        File.Create(path);
                        var logger = new LoggerConfiguration()
                            .MinimumLevel.Information()
                            .WriteTo.Console()
                            .WriteTo.File(path)
                            .CreateLogger();

                        builder.AddSerilog(logger);
                    });
                    services.AddSingleton<MainForm>();
                    services.AddSingleton<FormAxis>();
                    services.AddSingleton(new MaxiGrafConfig(
                        context.Configuration.GetSection(nameof(ConfigSectionsEnum.GraverConfig))
                        .GetValue<string>(nameof(IGraverConfig.ApiKey)),
                        context.Configuration.GetSection(nameof(ConfigSectionsEnum.GraverConfig))
                        .GetValue<float>(nameof(IGraverConfig.FocusHeight))));
                    services.AddSingleton<SerialConfig>(new SerialConfig(
                        context.Configuration.GetSection(nameof(ConfigSectionsEnum.SerialRangeMeter))
                        .GetValue<string>(nameof(SerialConfig.PortName)),
                        context.Configuration.GetSection(nameof(ConfigSectionsEnum.SerialRangeMeter))
                        .GetValue<int>(nameof(SerialConfig.BaudRate))));
                    services.AddSingleton<IHeightService, HeightService>();
                    services.AddSingleton<MarkInfo>();

                    services.AddSingleton<IBaseMarkerService, MaxiGrafService>();
                    //services.AddSingleton<IBaseMarkerService, MockGraverService>();
                });
        }
        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            var logger = ServiceProvider.GetRequiredService<Serilog.ILogger>();
            try
            {
                Exception ex = (Exception)e.ExceptionObject;

                logger.Error("Unhandled exception message: \r\n" + ex.Message + "\r\n StackTrace:\r\n" + ex.StackTrace);
                MessageBox.Show("The program will be closed!\r\n"+ex.ToString(), "Something went wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception exc)
            {
                try
                {
                    logger.Error("Unhandled exception \r\n"+exc.Message);
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