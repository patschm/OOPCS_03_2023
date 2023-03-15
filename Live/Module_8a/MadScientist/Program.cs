namespace MadScientist;

internal class Program
{
    static void Main(string[] args)
    {
        var simon = new SimonVdMeer();
        var willem = new WillemKlein();

        MathDel? m1 = simon.Add;
        m1 += simon.Add;
        m1 += simon.Subtract;
        m1 += simon.Add; 
        m1 -= simon.Subtract;

        foreach(var entry in m1.GetInvocationList())
        {
            Console.WriteLine(  entry.Method.Name);
        }
        

        willem.Calculate(m1, 3,2 );
        //willem.Calculate(simon.Subtract, 5, 8);
    }
}