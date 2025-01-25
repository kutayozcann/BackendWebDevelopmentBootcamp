using Patikafy;

List<Artist> artists = new List<Artist>()
{
    new Artist()
        { FirstNameLastName = "Ajda Pekkan", Genre = "Pop", DebutYear = 1968, AlbumSales = "About 20 million" },
    new Artist()
    {
        FirstNameLastName = "Sezen Aksu", Genre = "Turkish Folk Music / Pop", DebutYear = 1971,
        AlbumSales = "About 10 million"
    },
    new Artist() { FirstNameLastName = "Funda Arar", Genre = "Pop", DebutYear = 1999, AlbumSales = "About 3 million" },
    new Artist()
        { FirstNameLastName = "Sertap Erener", Genre = "Pop", DebutYear = 1994, AlbumSales = "About 5 million" },
    new Artist() { FirstNameLastName = "Sıla", Genre = "Pop", DebutYear = 2009, AlbumSales = "About 3 million" },
    new Artist()
        { FirstNameLastName = "Serdar Ortaç", Genre = "Pop", DebutYear = 1994, AlbumSales = "About 10 million" },
    new Artist() { FirstNameLastName = "Tarkan", Genre = "Pop", DebutYear = 1992, AlbumSales = "About 40 million" },
    new Artist() { FirstNameLastName = "Hande Yener", Genre = "Pop", DebutYear = 1999, AlbumSales = "About 7 million" },
    new Artist() { FirstNameLastName = "Hadise", Genre = "Pop", DebutYear = 2005, AlbumSales = "About 5 million" },
    new Artist()
    {
        FirstNameLastName = "Gülben Ergen", Genre = "Turkish Folk Music / Pop", DebutYear = 1997,
        AlbumSales = "About 10 million"
    },
    new Artist()
    {
        FirstNameLastName = "Neşet Ertaş", Genre = "Turkish Folk Music / Turkish Classical Music", DebutYear = 1960,
        AlbumSales = "About 2 million"
    }
};

// Artists whose names start with 'S'
var startsWithS = artists.Where(x => x.FirstNameLastName.StartsWith($"S")).ToList();
Console.WriteLine("---------------------Starting with S------------------------");
startsWithS.ForEach(x => Console.WriteLine(x.Display()));

// Artists with album sales more than 10 million
var moreThan10Million = artists.Where(x => int.Parse(x.AlbumSales.Split(' ')[1]) > 10).ToList();
Console.WriteLine("-------------More than 10 million album sales---------------");
moreThan10Million.ForEach(x => Console.WriteLine(x.Display()));

// Artists who debuted before 2000 and are Pop
Console.WriteLine("---------------------Pre 2000 and Pop-----------------------");
var pre2000AndPop = artists.Where(x => x.DebutYear < 2000 && x.Genre.Contains("Pop")).ToList()
    .GroupBy(x => x.DebutYear)
    .OrderBy(group => group.Key)
    .Select(group => new
    {
        DebutYear = group.Key,
        OrderedArtists = group.OrderBy(artist => artist.FirstNameLastName)
    });

foreach (var group in pre2000AndPop)
{
    Console.WriteLine($"Debut Year: {group.DebutYear}");
    foreach (var artist in group.OrderedArtists)
    {
        Console.WriteLine($"    Artist: {artist.FirstNameLastName}");
    }
}

Console.WriteLine("------------------------------------------------------------");
// Top-selling artist
var mostSoldAlbumedArtist = artists.OrderByDescending(x => int.Parse(x.AlbumSales.Split(' ')[1])).First();
Console.WriteLine(
    $"Top Sold Album Artist => {mostSoldAlbumedArtist.FirstNameLastName} with {mostSoldAlbumedArtist.AlbumSales}");

// Oldest and newest debut artist
var oldestDebutArtist = artists.OrderBy(artist => artist.DebutYear).First();
var newestDebutArtist = artists.OrderByDescending(artist => artist.DebutYear).First();

Console.WriteLine($"Oldest Debut Artist => {oldestDebutArtist.FirstNameLastName} / {oldestDebutArtist.DebutYear}");
Console.WriteLine($"Newest Debut Artist => {newestDebutArtist.FirstNameLastName} / {newestDebutArtist.DebutYear}");