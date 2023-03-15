namespace MoreInteraction;

internal class Program
{
    static void Main(string[] args)
    {
        var patrick = new Patrick();
        var suzanne = new Suzanne();

        //patrick.GoShopping();

        Instruction something = patrick.GoShopping;
        //something();

        suzanne.Execute(patrick.GoShopping);
        suzanne.Execute(something);
        suzanne.Execute(Explode);

        Console.WriteLine(  "=========================");
        suzanne.somethingElse = DoSomething;
        suzanne.Execute(Explode);
    }



    static void Explode()
    {
        Console.WriteLine("Kaboooom");
    }
    static string DoSomething(int bla)
    {
        return $"Doing something with value {bla}";
    }
}