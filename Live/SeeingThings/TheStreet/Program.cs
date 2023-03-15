using Canon;
using Philips;
using Siemens;

namespace TheStreet;

internal class Program
{
    static void Main(string[] args)
    {
        Detector loop = new Detector();
        Lamp tl = new Lamp();
        Camera cam = new Camera();


        loop.PerformDetect();
    }
}