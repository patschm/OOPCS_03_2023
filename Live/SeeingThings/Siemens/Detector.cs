using Standards;

namespace Siemens;

//public interface IDetector
//{
//    void Detecting();
//}

public delegate void OnDetect();

public class Detector
{
    private List<IDetector> detectors = new List<IDetector>();
    private event OnDetect? Detecting;

    public void Connect(IDetector detector)
    {
        detectors.Add(detector);
    }
    public void Connect(OnDetect del)
    {
        Detecting += del;
    }
    public void PerformDetect()
    {
        //foreach (var item in Detecting.GetInvocationList()) {
        //    Console.WriteLine(  item.Method.Name);
        //}
        Console.WriteLine("Hmmm! What's that?");
        if(Detecting != null )
        {
            Detecting();
        }

        foreach( IDetector detector in detectors )
        {
            detector.Detecting();
        }
    }
}