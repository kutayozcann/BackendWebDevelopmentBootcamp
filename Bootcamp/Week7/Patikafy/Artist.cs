namespace Patikafy;

public class Artist
{
    public string FirstNameLastName { get; set; }
    public string Genre { get; set; }
    public int DebutYear { get; set; }
    public string AlbumSales { get; set; }

    public string Display()
    {
        return $"Name and Surname: {FirstNameLastName} / Genre: {Genre} / Publish Date: {DebutYear} / Album Sales: {AlbumSales}";
    }
}