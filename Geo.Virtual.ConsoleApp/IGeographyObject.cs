public interface IGeographyObject
{
    public int X { get; set; }
    public int Y { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }

    public void GetInformation();
}
