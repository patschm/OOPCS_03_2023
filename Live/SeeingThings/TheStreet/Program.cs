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
        //loop.Detecting += tl.On;
        //loop.Detecting += cam.Record;

        //loop.detectors.Add(tl);
        //loop.detectors.Add(cam);

        loop.Connect(tl);
        loop.Connect(cam);

        loop.Connect(tl.On);
        loop.Connect(cam.Record);


        loop.PerformDetect();

        // Not accepted solutions:
        //tl.On();
        //cam.Record();
    }
}