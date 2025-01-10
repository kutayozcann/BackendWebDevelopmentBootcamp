namespace IMDB;

public class Movie
{
    // Properties
    public double Rating { get; set; }
    public string Title { get; set; }

    // Display method for showing full details of a movie
    public void Display()
    {
        Console.Write($"Title : {Title} ----- ");
        Console.WriteLine($"Rating : {Rating}");
    }
    
    // Display movies with ratings between 4 and 9
    public void DisplayByRating()
    {
        if (Rating <= 9.0 && Rating >= 4.0)
        {
            Console.Write($"Title : {Title} ----- ");
            Console.WriteLine($" Rating : {Rating}");
        }
    }
    
    // Display movies with titles starting with the letter 'A'
    public void DisplayByTitle()
    {
        if (Title[0] == 'A' || Title[0] == 'a')
        {
            Console.WriteLine($"Title : {Title} ");
        }
    }
}