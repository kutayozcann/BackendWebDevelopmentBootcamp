namespace Patikaflix;

public class Series : BaseSeries
{
    public int ProductionYear { get; init; }
    public int YearOfPublication { get; init; }
    public required string? FirstPlatform { get; init; }

    public override string ToString()
    {
        return
            $"Series Name: {SeriesName} / Production Year: {ProductionYear} / Genre: {string.Join(", ", Genre)} " +
            $"/ Year of Publication: {YearOfPublication} / Director: {Director} / Platform: {FirstPlatform}";
    }
}