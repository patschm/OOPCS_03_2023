namespace TheCompany;

internal class Lennard : Employee, IContract2
{
    void IContract2.DoWork()
    {
        Console.WriteLine("Another Company");
        WritesInVBA();
    }
    public override void Work()
    {
        WritesInVBA();
    }

    public void WritesInVBA()
    {
        Console.WriteLine("Lennard writse VBA code");
    }
}
