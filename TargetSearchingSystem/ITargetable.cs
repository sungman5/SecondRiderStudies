namespace TargetSearchingSystem;

public interface ITargetable
{
    public string Tag { get; set; }
    public Point3D Position { get; set; }
    public string Ontargeted();
}