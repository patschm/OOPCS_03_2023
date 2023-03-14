namespace Inheritance;

internal class FountainPen : Pen
{
    public int InkLevel { get; set; } = 5;

    // Here I want polymorphism to be activated.
    // I use override
    public override void Write(string txt)
    {
         if(0 == InkLevel)
        {
            Console.WriteLine($"{nameof(FountainPen)} is empty");
            return;
        }
        InkLevel--;
        Console.ForegroundColor = LineColor;
        Console.WriteLine($"FountainPen is writing {txt} with linewidth: {LineWidth} ");
        Console.ResetColor();
    }
}
