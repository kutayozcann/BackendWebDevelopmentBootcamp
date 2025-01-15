namespace CarFabrication;

public class Car
{
    private int _doorNumber;

    public DateOnly ProductionDate { get; set; }
    public string? SerialNumber { get; set; }
    public string? Brand { get; set; }
    public string? Model { get; set; }
    public string? Color { get; set; }

    public int DoorNumber
    {
        get => _doorNumber;
        set
        {
            if (value % 2 == 0)
            {
                _doorNumber = value;
            }
            else
            {
                Console.WriteLine("Invalid number of doors number. Setting value to default.(-1)");
                _doorNumber = -1;
            }
        }
    }

    public Car()
    {
        ProductionDate = DateOnly.FromDateTime(DateTime.Now);
    }
}