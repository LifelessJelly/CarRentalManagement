namespace CarRentalManagement.Components.Domain;

public class Vehicle : BaseDomainModel
{
    public int year { get; set; }
    public string? LicensePlateNumber { get; set; }
    public int MakeId { get; set; }
    public int ModelId { get; set; }
    public int ColorId { get; set; }
}