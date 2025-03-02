using System.ComponentModel.DataAnnotations;

namespace CrazyMusicians.Models;

public class Musician
{
    public int Id { get; set; }

    [Required(ErrorMessage = "FullName is required.")]
    [StringLength(100, ErrorMessage = "FullName cannot be longer than 100 characters.")]
    public string FullName { get; set; }

    [Required(ErrorMessage = "Profession is required.")]
    [StringLength(50, ErrorMessage = "Profession cannot be longer than 50 characters.")]
    public string Profession { get; set; }

    [Required(ErrorMessage = "FunFact is required.")]
    [StringLength(200, ErrorMessage = "FunFact cannot be longer than 200 characters.")]
    public string FunFact { get; set; }
}