//using Siemens;
using Standards;

namespace Canon;

public class Camera : IDetector
{
    public void Detecting()
    {
        Record();
    }

    public void Record()
    {
        Console.WriteLine("The camera starts recording");
    }
}