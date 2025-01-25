using Patikaflix;

Console.WriteLine("Welcome to Patikaflix");

var seriesList = new List<Series>();

while (true)
{
    Series:
    Console.Clear();
    int productionYear, publicationYear;
    string? firstPlatform, director;
    string? seriesName;

    // Prompt for series name and validate input
    while (true)
    {
        Console.Write("Please enter series name: ");
        seriesName = Console.ReadLine();
        if (!string.IsNullOrEmpty(seriesName)) break;
        Console.WriteLine("Please enter valid series name!");
    }

    // Prompt for production year and validate input
    while (true)
    {
        Console.Write("Please enter production year: ");
        var validProdYear = int.TryParse(Console.ReadLine(), out productionYear);
        if (validProdYear && productionYear is < 2026 and > 1950) break;
        Console.WriteLine("Please enter valid production year!");
    }

    // Collect genres for the series
    var genres = new List<string?>();
    string[] validGenres = ["comedy", "crime fiction", "drama", "romantic", "history"];
    while (true)
    {
        Genre:
        Console.Write("Please enter genre (Comedy, Crime Fiction, Drama, Romantic, History): ");
        var genre = Console.ReadLine()?.ToLower();
        if (validGenres.Contains(genre))
        {
            genres.Add(genre);
            Console.Write("Do you want to add genre? (Y/N) : ");
            var input = Console.ReadLine();
            if (input?.ToLower() == "y") goto Genre;
            else break;
        }

        Console.WriteLine("Please enter valid genre!");
    }

    // Prompt for publication year and ensure it is after the production year
    while (true)
    {
        Console.Write("Please enter publication year: ");
        var validPublicYear = int.TryParse(Console.ReadLine(), out publicationYear);
        if (validPublicYear && publicationYear >= productionYear) break;
        Console.WriteLine("Please enter valid publication year!");
    }

    // Prompt for director's name
    while (true)
    {
        Console.Write("Please enter director name: ");
        director = Console.ReadLine();
        if (!string.IsNullOrEmpty(director)) break;
        Console.WriteLine("Please enter valid director name!");
    }

    // Prompt for the first platform the series was released on
    while (true)
    {
        Console.Write("Please enter first platform which it was released: ");
        firstPlatform = Console.ReadLine();
        if (!string.IsNullOrEmpty(firstPlatform)) break;
        Console.WriteLine("Please enter valid first platform!");
    }

    // Create a new Series object and add it to the list
    var series = new Series()
    {
        ProductionYear = productionYear,
        Director = director,
        Genre = genres,
        YearOfPublication = publicationYear,
        FirstPlatform = firstPlatform,
        SeriesName = seriesName
    };

    seriesList.Add(series);

    Console.WriteLine("Series added");
    Console.Write("Do you want to add new series? (Y/N): ");
    var choice = Console.ReadLine();
    if (choice?.ToLower() == "y") goto Series;
    else break;
}

Console.Clear();

// Filter and sort series with the "comedy" genre
var comedyList = seriesList.Where(x => x.Genre.Contains("comedy"))
    .OrderBy(x => x.SeriesName)
    .ThenBy(x => x.Director)
    .Select(x => new BaseSeries()
    {
        SeriesName = x.SeriesName,
        Genre = x.Genre,
        Director = x.Director,
    })
    .ToList();

// Display the filtered comedy series
Console.WriteLine("-----------------Comedy List-----------------");
foreach (var i in comedyList)
{
    Console.WriteLine($"Series Name: {i.SeriesName} / Director: {i.Director} / Genre: {string.Join(',', i.Genre)}");
}