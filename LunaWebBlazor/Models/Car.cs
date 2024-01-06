namespace LunaWebBlazor.Models;

public class Car
{
    public int CarId { get; set; }
    public string Color { get; set; }
    public string Title { get; set; }
    public int YearOfIssue { get; set; }
    public string SubTitle { get; set; }
    public double Volume { get; set; }
    public int Mileage { get; set; }
    public string Location { get; set; }
    public List<string> Images { get; set; }
}
