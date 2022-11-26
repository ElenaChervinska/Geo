public class River : GeographyObject
{
    public double Speed { get; set; }
    public double Lenght { get; set; }

    public override void GetInformation()
    {
        base.GetInformation();
        Console.WriteLine($"Speed: {this.Speed}");
        Console.WriteLine($"Lenght: {this.Lenght}");
    }
}
