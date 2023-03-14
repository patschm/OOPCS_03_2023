namespace TheCompany;

// Interface describes what an object CAN DO!!!
interface IContract
{
    void DoWork();
}

internal class ACME
{
    private List<IContract> _employees = new List<IContract>();

    public void Hire(IContract employee)
    {
        _employees.Add(employee);
    }

    public void BlowWhistle()
    {
        Console.Beep(1000, 500);
       foreach(IContract emp in _employees) 
        { 
            emp.DoWork();
        }
    }
}
