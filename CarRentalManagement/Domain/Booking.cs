namespace BlazorApp2.Domain;

public class Booking : BaseDomainModel
{
    public DateTime DateIn { get; set; }
    public DateTime DateOut { get; set; }
    public int VehicleId { get; set; }
    public int CustomerId { get; set; }
}