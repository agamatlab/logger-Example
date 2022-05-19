using NLog;
using Serilog;
using log4net;

class Program
{
    static void Main(string[] args)
    {
        // SeriLog
        Log.Logger = new LoggerConfiguration()
            .WriteTo.Console()
            .CreateLogger();

        Log.Information("Message Serilog");


        // NLog
        Logger log = NLog.LogManager.GetCurrentClassLogger();
        log.Debug("This is a debug message");


        // Log4Net

        log4net.Config.BasicConfigurator.Configure();
        ILog logger4net = log4net.LogManager.GetLogger(typeof(Program));
        logger4net.Info("Log4Net Message");

    }
}