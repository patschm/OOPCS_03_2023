namespace EvolutionTheory;

delegate int MathDel(int x, int y);

internal class Program
{
    static void Main(string[] args)
    {
        // .NET Framework 1.0/1.1 (2002/2003).
        MathDel m1 = new MathDel(Add);
        int result = m1.Invoke(1, 2);
        result = m1(1, 2);

        // .NET Framework 2.0 (2005)
        MathDel m2 = Add;
        result = m2(2, 3);

        int c = 100;

        MathDel m3 = delegate (int x, int y)
        {
            return x + y + c;
        };

        result = m3(3, 4);

        // .NET Framework 3.0/3.5 (2008)
        MathDel m4 = (x, y) => x + y + c;
        result = m4(4, 5);

        // Procedure
        Action<string> a1 = Console.WriteLine;
        a1("Hello");

        // Function
        Func<int> m5 = () => 42;
        result = m5();

        Func<int, int, int> m6 = Add;
        result = m6(2, 3);

        Func<int, int, int> m7 = (a, b) => a - b;
        result = m7(98, 56);

        Console.WriteLine(result);
    }

    static int Add(int x, int y)
    {
        return x + y;
    }
}