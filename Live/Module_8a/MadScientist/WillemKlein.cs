namespace MadScientist;

delegate int MathDel(int aaa, int baa);

internal class WillemKlein
{
    public void Calculate(MathDel fun, int aa, int bb)
    {
        Console.WriteLine("Willem starts calculating...");

        int result = fun(aa,bb);
        // TODO


        Console.WriteLine($"Willem Shouts: The answer is {result}");
    }
}
