using NLog;
string path = Directory.GetCurrentDirectory() + "\\nlog.config";
// create instance of Logger
var logger = LogManager.LoadConfiguration(path).GetCurrentClassLogger();

StreamReader movies = new StreamReader("movies.csv");
StreamReader links = new StreamReader("links.csv");
StreamReader ratings = new StreamReader("ratings.csv");
StreamReader tags = new StreamReader("tags.csv");
//prompt for input
Console.WriteLine("Enter 1 to add data.");
Console.WriteLine("Enter 2 to read data.");
Console.WriteLine("Enter anything else to quit.");
// input response
string? resp = Console.ReadLine();

if(resp == "1")
{
    //create file
    StreamWriter sw = new StreamWriter("data.csv");

    //prompt user for movie id
    Console.WriteLine("What Movie Id will this be?");
    string? resp1 = Console.ReadLine();
    if(String.IsNullOrEmpty(resp1)){
        logger.Error("Enter a valid Movie ID");
    }

    //prompt user for title
    Console.WriteLine("What is the Title?");
    string? resp2 = Console.ReadLine();
    if(String.IsNullOrEmpty(resp2)){
        logger.Error("Enter a valid Title");
    }

    //prompt user for genre
    Console.WriteLine("What is the Genre? (If multiple separate with | )");
    string? resp3 = Console.ReadLine();
    if(String.IsNullOrEmpty(resp3)){
        logger.Error("Enter a valid Genre");
    }

    //writes data in file
    sw.WriteLine(resp1 + "," + resp2 + "," + resp3);
    sw.Close();
}
else if(resp == "2")
{
    //reads the entire file
    while(!movies.EndOfStream)
    {
        Console.WriteLine(movies.ReadLine());
    }
    //reads entire file
    while(!links.EndOfStream)
    {
        Console.WriteLine(links.ReadLine());
    }
    //reads entire file
    while(!ratings.EndOfStream)
    {
        Console.WriteLine(ratings.ReadLine());
    }
    //reads entire file
    while(!tags.EndOfStream)
    {
        Console.WriteLine(tags.ReadLine());
    }
}

