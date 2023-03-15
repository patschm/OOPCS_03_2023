
namespace Flexible;

internal class Point<T> where T: IFormattable
{
    public T X { get; set; }
    public T Y { get; set; }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}
