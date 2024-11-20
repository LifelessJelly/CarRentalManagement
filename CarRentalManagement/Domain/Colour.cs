using System.ComponentModel.DataAnnotations;

namespace BlazorApp2.Domain;

public class Colour : BaseDomainModel
{
    [MaxLength(100)]
    public string? Name { get; set; }
}