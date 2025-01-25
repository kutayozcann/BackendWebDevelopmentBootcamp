namespace Patikaflix;

public class BaseSeries
{
    public required string? SeriesName { get; init; }
    public required List<string?> Genre { get; init; }
    public required string Director { get; init; }
}
