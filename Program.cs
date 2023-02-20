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

