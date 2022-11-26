public class River : IGeographyObject
{
    public int X { get; set; }
    public int Y { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set ; }
    public double Speed { get; set; }
    public double Lenght { get; set; }

    public void GetInformation()
    {
        Console.WriteLine($"X: {this.X}");
        Console.WriteLine($"Y: {this.Y}");
        Console.WriteLine($"Name: {this.Name}");
        Console.WriteLine($"Description: {this.Description}");
        Console.WriteLine($"Speed: {this.Speed}");
        Console.WriteLine($"Lenght: {this.Lenght}");
    }
}
