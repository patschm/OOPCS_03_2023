//using Siemens;
using Standards;

namespace Philips;

public class Lamp : IDetector
{
    public void Detecting()
    {
        On();
    }

    public void On()
    {
        Console.WriteLine("The lamp lights up the road");
    }
}