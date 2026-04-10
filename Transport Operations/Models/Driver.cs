using Transport_Operations.Enums;

namespace Transport_Operations.Models;

public class Driver
{
    public int Id { get; set; }
    public string FullName { get; set; }
    private string Licence { get; set; }
    public DriverStatus Status { get; set; } = DriverStatus.Available;

    public Driver(int id, string fullName, string licence)
    {
        Id = id;
        FullName = fullName;
        Licence = licence;
    }


}