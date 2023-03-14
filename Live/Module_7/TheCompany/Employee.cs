namespace TheCompany;

// Employee INHERITS from Person and IMPLEMENTS IContract
internal abstract class Employee : Person, IContract
{
    public void DoWork()
    {
        Console.WriteLine("Works for ACME");
        Work();
    }

    public abstract void Work();
}
