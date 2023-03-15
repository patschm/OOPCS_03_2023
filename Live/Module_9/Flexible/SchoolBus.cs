namespace Flexible;

internal class SchoolBus : IFormattable
{
    public int nr;

    public static implicit operator SchoolBus(int x)
    {
       return new SchoolBus { nr= x };  
    }
    public static explicit operator int(SchoolBus sb)
    {
        return sb.nr;
    }

    public override string ToString()
    {
        return nr.ToString();
    }

    public string ToString(string? format, IFormatProvider? formatProvider = null)
    {
        return ToString();
    }
}