namespace TargetSearchingSystem;

public struct Point3D
{
    public float X { get; set; }
    public float Y { get; set; }
    public float Z { get; set; }

    public override string ToString()
    {
        return $"X:{X}, Y:{Y}, Z:{Z}";
    }

    public Point3D(float x, float y, float z)
    {
        X = x;
        Y = y;
        Z = z;
    }
    
}