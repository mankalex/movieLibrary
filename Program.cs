using NLog;
string path = Directory.GetCurrentDirectory() + "\\nlog.config";
// create instance of Logger
var logger = LogManager.LoadConfiguration(path).GetCurrentClassLogger();

StreamReader movies = new StreamReader("movies.csv");
StreamReader links = new StreamReader("links.csv");
StreamReader ratings = new StreamReader("ratings.csv");
StreamReader tags = new StreamReader("tags.csv");
//prompt for input
Console.WriteLine("Enter what movieId you wish to view.");
// input response
string? resp = Console.ReadLine();

if(String.IsNullOrEmpty(resp)) {
    logger.Error("Please enter a valid ID");
}

