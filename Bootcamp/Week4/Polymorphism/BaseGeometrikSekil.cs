namespace Polymorphism;

// Absract clas for geometric shapes
public abstract class BaseGeometrikSekil
{
    // Properties for height and width
    public int Height { get; set; }
    public int Width { get; set; }
    public abstract void Area(); // Abstract method for area calculation for derived classes
}

public class Kare : BaseGeometrikSekil
{
    public override void Area() // Override the Area() method for Kare
    {
        Console.WriteLine($"Area of Kare : {Height*Width}");
    }
}

public class Dikdortgen : BaseGeometrikSekil
{
    public override void Area() // Override the Area() for Dikdortgen
    {
        Console.WriteLine($"Area of Dikdortgen : {Height*Width}");
    }
}

public class Dikucgen : BaseGeometrikSekil
{
    public override void Area() // Override the Area() for Dikucgen
    {
        Console.WriteLine($"Area of Dikucgen : {Height*Width/2}");
    }
}