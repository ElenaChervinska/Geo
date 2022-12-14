public abstract class GeographyObject
{
    public int X { get; set; }
    public int Y { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }

    public virtual void GetInformation()
    {
        Console.WriteLine($"X: {this.X}");
        Console.WriteLine($"Y: {this.Y}");
        Console.WriteLine($"Name: {this.Name}");
        Console.WriteLine($"Description: {this.Description}\n");
    }
}
