namespace Inheritance;

internal class Marker : Pen
{
    public bool IsBold { get; set; } = false;

    public override void Write(string txt)
    {     
        Console.ForegroundColor = LineColor;
        if (IsBold)
        {
            Console.WriteLine($"Marker is writing Bold {txt} with linewidth: {LineWidth} ");
        }
        else
        {
            Console.WriteLine($"Marker is writing {txt} with linewidth: {LineWidth} ");
        }


        Console.ResetColor();
    }
}
