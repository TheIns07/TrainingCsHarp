

using TestProject;

namespace Program
{
    class Program
    {
        // static void Main(string[] args)

        void method()
        {
            Scrape myScrape = new();
            Console.WriteLine(myScrape.ScrapeWebPage("https://example-files.online-convert.com/document/txt/example.txt"));
            Console.ReadLine();
        }
 
    }
}