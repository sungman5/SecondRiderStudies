namespace TargetSearchingSystem;

public readonly struct Point3D
{
    public float X { get; }
    public float Y { get; }
    public float Z { get; }

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

    public double GetDistance(Point3D other)
    {
        double dx = this.X - other.X;
        double dy = this.Y - other.Y;
        double dz = this.Z - other.Z;

        double result = Math.Sqrt(dx * dx + dy * dy + dz * dz);
        return result;
    }
}