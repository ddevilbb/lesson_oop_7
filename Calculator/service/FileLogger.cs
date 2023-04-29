using Serilog;
using Serilog.Events;

namespace Calculator.service;

public class FileLogger: IAppLogger
{
    private readonly ILogger _logger;

    public FileLogger()
    {
        _logger =  new LoggerConfiguration()
            .MinimumLevel.Information()
            .WriteTo.File(Directory.GetParent(Environment.CurrentDirectory)!.Parent!.Parent!.FullName + "/resources/log.txt")
            .CreateLogger();
    }

    public void Log(String message)
    {
        String dateTime = DateTime.Now.ToString("[d MMMM yyyy HH:mm]");
        _logger.Information($"{dateTime} {message}");
    }    
}
