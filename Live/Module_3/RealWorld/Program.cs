using System.Net.WebSockets;

namespace RealWorld;

internal class Program
{
    static void Main(string[] args)
    {
        // Big Bang

        uint linew = 10;
        //do 
        //{
        //    Console.WriteLine("What should the linewidt be?");
        //    string slw = Console.ReadLine();
        //    if (!uint.TryParse(slw, out linew))
        //    {
        //        Console.WriteLine("Invalid linewidth");
        //        continue;
        //    }
        //    break;
        //}
        //while (true);

        Pen p1 = new Pen();
        p1.LineColor = ConsoleColor.Green;
        //p1.lineWidth = 2;
        p1.LineWidth = linew;

        p1.Write("Hello");

        Pen p2 = new Pen(lnWidth:10, ConsoleColor.Blue);
        p2.Write("Hello World");

        Pen p3 = new Pen();
        p3.Write("Hello World P3");

        Pen p4 = new Pen { LineWidth=1000, LineColor = ConsoleColor.Red };
        //p4.lineWidth = 4_000_000_000;
        //p4.SetLineWidth(4_000_000_000);
        p4.LineWidth= 1000;
        p4.Write("Hello World P4");





        // Big Crunch
    }
}