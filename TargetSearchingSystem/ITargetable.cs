namespace TargetSearchingSystem;

public interface ITargetable
{
    public string Tag { get; }
    public Point3D Position { get; }
    public string Ontargeted();
}