namespace Flexible;

internal class Program
{
    static void Main(string[] args)
    {
        int number = 10;
        long nr2 = number;

        Point<SchoolBus> bus = new Point<SchoolBus>() { X = 5, Y = 42 };
        Console.WriteLine(bus);

        Point<int> p1 = new Point<int>{ X=1, Y=2 };  
        //Point p2 = new Point { X=100, Y=200 };
        Console.WriteLine(p1);

        SchoolBus a = 10;
        SchoolBus b = 20;
        Console.WriteLine($"a={a}, b={b}");
        Swap(ref a, ref b);
        Console.WriteLine($"a={a}, b={b}");


        int nr = (int)a;
        Console.WriteLine(nr);
    }

    //private static void Swap(ref int aa, ref int bb)
    //{
    //    int tmp = bb;
    //    bb = aa;
    //    aa = tmp;
    //}
    //private static void Swap(ref long aa, ref long bb)
    //{
    //    long tmp = bb;
    //    bb = aa;
    //    aa = tmp;
    //}
    //private static void Swap(ref float aa, ref float bb)
    //{
    //    float tmp = bb;
    //    bb = aa;
    //    aa = tmp;
    //}
    private static void Swap<T>(ref T aa, ref T bb)
    {
        T tmp = bb;
        bb = aa;
        aa = tmp;
    }
}