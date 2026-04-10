using Transport_Operations.Enums;

namespace Transport_Operations.Models;

public class TransportService
{
    public int Id { get; set; }
    public string Origin { get; set; }
    public string Destination { get; set; }
    public int Distance { get; set; }
    public ServiceStatus Status { get; set; } = ServiceStatus.Pending;
    public double TotalCost { get; set; } = 0.0;
    public Driver? Driver { get; set; }
    public Vehicle? Vehicle { get; set; }

    public TransportService(int id, string origin, string destination, int distance)
    {
        Id = id;
        Origin = origin;
        Destination = destination;
        Distance = distance;
    }
}