using Kanban_ToDoList.Constant;
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
        static MessagesLog messagesLog = new MessagesLog();
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
                Log.Information(messagesLog.msStart);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());

            }
            catch (Exception)
            {

                Log.Fatal(messagesLog.msError);
            }
            finally
            {
                Log.CloseAndFlush(); // Ensure all logs are flushed before exiting
            }
        }
    }
}
