namespace Survivor.Data.Entities;

public class CategoryEntity : BaseEntity
{
    public string? Name { get; set; }
    public List<CompetitorEntity> Competitors { get; set; } = new();
       
}