using Serilog;

namespace NewGraverForms_Net.Logger
{
    public static class Logging
    {
        public static void ConfigureLogger()
        {
            string path = Application.StartupPath + "\\MaxiGrafLog.txt";
            FileInfo fileInfo = new FileInfo(path);
            if (!fileInfo.Exists)
            {
                fileInfo.Create();
            }
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Information()
                .WriteTo.Console()
                .WriteTo.File(path)
                .CreateLogger();

            Log.Information("Hello, Serilog!");

        }
    }
}
