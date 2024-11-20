using System.ComponentModel.DataAnnotations;

namespace BlazorApp2.Domain;

public class Vehicle : BaseDomainModel
{
    public int Year { get; set; }
    [MaxLength(100)]
    public string? LicensePlateNumber { get; set; }
    public int MakeId { get; set; }
    public int ModelId { get; set; }
    public int ColourId { get; set; }
}