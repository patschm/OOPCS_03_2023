namespace TheCompany;

internal class Anshul : Employee
{
    public void TranslatesToDutch()
    {
        Console.WriteLine("Anshul translates Hindi into Dutch");
    }

    public override void Work()
    {
        TranslatesToDutch();
    }
}
