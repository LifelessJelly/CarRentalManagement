namespace CarRentalManagement.Components.Domain;

public class Booking : BaseDomainModel
{
    public DateTime DateOut { get; set; }
    public DateTime DateIn { get; set; }
    public int VehicleId { get; set; }
    public int CustomerId { get; set; }
}