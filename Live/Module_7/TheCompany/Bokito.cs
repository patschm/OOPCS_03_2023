namespace TheCompany;

internal class Bokito : IContract
{
    public void DoWork()
    {
        Work();
    }

    public void Work()
    {
        Console.WriteLine("Bokito keeps Suzanne out");
    }
}
