
namespace TheCompany;

internal class Eric : Employee
{
    public void ProgrammingInDelphi()
    {
        Console.WriteLine("Eric is programming products in Delphi");
    }

    public override void Work()
    {
        ProgrammingInDelphi();
    }
}
