namespace MoreInteraction;

// Blueprint of a function( type definition)
delegate void Instruction();
delegate string Instruction2(int a);

internal class Suzanne
{
    public Instruction2 somethingElse;

    public void Execute(Instruction instruction)
    {
        Console.WriteLine("Suzanne executes the following instruction");
        instruction();

        if (somethingElse != null)
        {
            string result = somethingElse(42);
            Console.WriteLine(  result);
        }
    }
}
