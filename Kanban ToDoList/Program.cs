using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Kanban_ToDoList
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.File("Logs/log.txt",rollingInterval: RollingInterval.Day)
                .CreateLogger();
            try
            {
                Log.Information("Application started");
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());

            }
            catch (Exception)
            {

                Log.Fatal("An error occurred while starting the application.");
            }
            finally
            {
                Log.CloseAndFlush(); // Ensure all logs are flushed before exiting
            }
        }
    }
}
