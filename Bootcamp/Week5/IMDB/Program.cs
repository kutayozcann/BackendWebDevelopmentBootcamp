using IMDB;

Console.WriteLine("Welcome to the IMDB List");
List<Movie> movies = new List<Movie>();
bool appRepeater = true;

do
{
    // Asking the user for the movie name
    Console.Write("Please enter the movie name: ");
    var movieTitle = Console.ReadLine();

    double movieRating;
    bool validRating;
    do
    {
        // Asking the user for the movie rating and validating input
        Console.Write("Please enter the movie rating: ");
        validRating = double.TryParse(Console.ReadLine(), out movieRating);
        if (movieRating < 0 || movieRating > 10 || validRating == false)
        {
            Console.WriteLine("Invalid input. Please enter a rating between 0 and 10.");
            validRating = false;
        }
    } while (!validRating);

    // Creating a movie object with user-provided data
    var movie = new Movie()
    {
        Rating = movieRating,
        Title = movieTitle,
    };
    
    // Adding the movie to the list 
    movies.Add(movie);

    // Asking the user if they want to add another movie 
    Console.WriteLine("Do you want to create a new movie? (Y/N)");
    var repeaterChoice = Console.ReadLine()?.ToUpper();
    Console.Clear();

    if (repeaterChoice == "N")
    {
        appRepeater = false;
    }
} while (appRepeater);

Console.Clear();

// Display all movies in the list
Console.WriteLine("--------------------Full IMDB List-----------------");
foreach (var a in movies)
{
    a.Display();
}

// Display movies with rating between 4 and 9
Console.WriteLine("-------------------------------------------------");
Console.WriteLine("Displaying films that have rating between 4 and 9");
foreach (var a in movies)
{
    a.DisplayByRating();
}

//Display movies with titles that start with letter 'A' 
Console.WriteLine("-----------------------------------------------------------");
Console.WriteLine("Displaying films with a title that starts with letter 'A' ");
foreach (var a in movies)
{
    a.DisplayByTitle();
}