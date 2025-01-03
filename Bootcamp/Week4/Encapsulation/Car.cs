namespace Encapsulation;

public class Car
{
    private string _brand;
    private string _model;
    private string _color;
    private int _doorNumber;

    public Car(){ }

    public string Brand
    {
        get { return _brand; }
        set { _brand = value; }
    }

    public string Model
    {
        get { return _model; }
        set { _model = value; }
    }

    public string Color
    {
        get { return _color; }
        set { _color = value; }
    }

    
    public int DoorNumber
    {
        get { return _doorNumber; }
        set
        {
            switch (value)
            {
                case 2:
                case 4:
                    _doorNumber = value;
                    break;
                default:                // Error message for invalid door number
                    Console.WriteLine("Geçersiz kapı sayısı girişi. Kapı sayısı 2 veya 4 olmalıdır.");
                    _doorNumber = -1;
                    break;
            }
        }
    }

    public void DisplayCarInfo()
    {
        Console.WriteLine($"Car Info: {Brand} {Model} {Color} {DoorNumber}");
    }
}