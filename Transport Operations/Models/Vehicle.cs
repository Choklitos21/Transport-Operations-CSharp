using Transport_Operations.Enums;

namespace Transport_Operations.Models;

public class Vehicle
{
    public string LicensePlate { get; set; }
    public VehicleType Type { get; set; }
    public int Capacity { get; set; }
    public VehicleStatus Status { get; set; } = VehicleStatus.Available;

    public Vehicle(string licensePlate, VehicleType type, int capacity)
    {
        LicensePlate = licensePlate;
        Type = type;
        Capacity = capacity;
    }
}