using System.ComponentModel.DataAnnotations;

namespace BlazorApp2.Domain;

public class Make : BaseDomainModel
{
    [MaxLength(100)]
    public string? Name { get; set; }
}