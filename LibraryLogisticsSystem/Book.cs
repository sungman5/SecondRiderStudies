namespace LibraryLogisticsSystem;

public class Book : ILoggable
{
    public string Name { get; set; }
    public double Weight { get; set; }
    public BookLocation Location { get; set; }
    
    public Book(string name, double weight, BookLocation location)
    {
        Name = name;
        Weight = weight;
        Location = location;
    }
    
    
    public string GetInfo()
    {
        return $"책이름: {Name}, 무게:{Weight} 위치:{Location}";
    }
}