using NLog;

string path = Directory.GetCurrentDirectory() + "\\nlog.config";

var logger = LogManager.LoadConfiguration(path).GetCurrentClassLogger();

Console.WriteLine("Enter 1 to add movies.");
Console.WriteLine("Enter 2 to list movies.");
Console.WriteLine("Enter anything else to quit.");

String? prompt = Console.ReadLine();




// log sample messages
logger.Trace("Sample trace message");
logger.Debug("Sample debug message");
logger.Info("Sample informational message");
logger.Warn("Sample warning message");
logger.Error("Sample error message");
logger.Fatal("Sample fatal error message");

// NLog supports structured messages
var fruit = new[] { "bananas", "apples", "pears" };
logger.Info("I like to eat {Fruit}", fruit);

// Example of logging an exception
try
{
    int x = 10;
    int y = 0;
    Console.WriteLine(x / y);
}
catch (Exception ex)
{
    logger.Error(ex.Message);
}