namespace OneMoreThing;

internal class Program
{
    static void Main(string[] args)
    {
        Point<int> p1 = new Point<int> { X = 1, Y = 2 };
        Console.WriteLine( p1);
        DoSomething(p1);
        Console.WriteLine(p1);
    }

    private static void DoSomething(Point<int> ppp)
    {
        ppp.X = 100;
        ppp.Y = 200;
    }
}