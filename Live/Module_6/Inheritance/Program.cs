namespace Inheritance;

internal class Program
{
    static void Main(string[] args)
    {
        // Generalization.
        // Is a FountainPen a Pen?
        Pen[] pens = new Pen[2];
        Pen p1 = new FountainPen { InkLevel = 3, LineColor = ConsoleColor.Blue };
        Pen m1 = new Marker { IsBold = true };


        pens[0] = new FountainPen();
        pens[1] = new Marker();

       TestPen(m1);

        for (int i = 0; i < 10; i++)
            TestPen(p1);

    }

    static void TestPen(Pen pen)
    {
        pen.Write("Test");
    }
    
}