
namespace TwoTowers;

internal partial class Point
{
    public int X { get; set; }
    public int Y { get; set; }
}

// Partial: Merged compile time
internal partial class Point
{
  
    public static Point operator +(Point a, Point b)
    {
        return new Point { X = a.X + b.X, Y = a.Y + b.Y };
    }
    public static Point operator -(Point a, Point b)
    {
        return new Point { X = a.X - b.X, Y = a.Y - b.Y };
    }

    public void Show()
    {
        Console.WriteLine($"({X}, {Y})");
    }
}
