namespace TechStore;

public abstract class BaseMakine // Base Class
{
    // Properties
    private DateOnly ProductionDate { get; }
    public string? SerialNumber { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? OpSystem { get; set; }

    // Constructor that initializes the ProductionDate to current date
    public BaseMakine()
    {
        ProductionDate = DateOnly.FromDateTime(DateTime.Now);
    }

    // Virtual method for displaying infos
    public virtual void Display()
    {
        Console.WriteLine($"Production Date: {ProductionDate}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Serial Number: {SerialNumber}");
        Console.WriteLine($"Operating System: {OpSystem}");
    }
    public abstract void GetProductName();
}

public class Phone : BaseMakine // Derived Class from BaseMakine
{
    public bool isTrLicenced { get; set; }

    // Overriding Display method to add Tr Licence status
    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Tr Licenced: {isTrLicenced}");
    }
    
    public override void GetProductName()
    {
        Console.WriteLine($"Your phone name ===> {Name}");
    }
}

public class PC : BaseMakine // Derived Class from BaseMakine
{
    public bool BluetoothEnabled { get; set; }
    private int _usbPortNumber;
    
    // Property for validate the number of USB ports
    public int UsbPortNumber
    {
        get { return _usbPortNumber;}
        set
        {
            switch (value)
            {
                case 2:
                case 4:
                    _usbPortNumber = value;
                    break;
                default:
                    Console.WriteLine("Invalid Usb Port Number. Setting to default (-1).");
                    _usbPortNumber = -1;
                    break;
            }
        }
        
         }
    
    // Overriding Dispaly method to include Bluetooth status and USB Ports number
    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Bluetooth Enabled: {BluetoothEnabled}");
        Console.WriteLine($"Usb Port Number: {_usbPortNumber}");
    }
    
    public override void GetProductName()
    {
        Console.WriteLine($"Your PC name ===> {Name}");
    }
}