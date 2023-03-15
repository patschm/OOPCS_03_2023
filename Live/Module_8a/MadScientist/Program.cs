namespace MadScientist;

internal class Program
{
    static void Main(string[] args)
    {
        var simon = new SimonVdMeer();
        var willem = new WillemKlein();

        willem.Calculate(simon.Add);
    }
}