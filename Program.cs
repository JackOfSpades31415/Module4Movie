using NLog;

string path = Directory.GetCurrentDirectory() + "\\nlog.config";

var logger = LogManager.LoadConfiguration(path).GetCurrentClassLogger();

Console.WriteLine("Enter 1 to add movie.");
Console.WriteLine("Enter 2 to list movies.");
Console.WriteLine("Enter anything else to quit.");

String? prompt = Console.ReadLine();

if (prompt == "1"){

    StreamWriter sw = new StreamWriter("movies.csv");
    Console.WriteLine("movie ID?");
    int movieID = int.Parse(Console.ReadLine());
    Console.WriteLine("Name of movie?");
    String? movieName = Console.ReadLine();
    bool genreAsk = true;
    List<string> genres;
    char moreGenre;
    while(genreAsk){
        Console.WriteLine("What genre?");
        genres.add(Console.ReadLine);
        Console.WriteLine("Another Genre? Y/N");
        moreGenre = Console.ReadLine();
            if(moreGenre == "N"){
                genreAsk = false;
            }
    }
    sw.WriteLine($"{movieID},{movieName},{string.join("|", genres)}");
    sw.Close;

}
else if(prompt == "2"){
         if(System.IO.File.Exists("movies.csv")){
        StreamReader sr = new StreamReader("movies.csv");
        while(!sr.EndOfStream){
            sr.ReadLine;
        }
            sr.Close();
         }

}




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