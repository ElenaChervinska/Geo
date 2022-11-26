
public class Mountain : GeographyObject
{
    public int HighestPoint { get; set; }

    public override void GetInformation()
    {
        base.GetInformation();
        Console.WriteLine($"HighestPoint: {this.HighestPoint}");
    }
}