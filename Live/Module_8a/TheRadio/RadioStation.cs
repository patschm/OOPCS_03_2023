namespace TheRadio;

delegate void Messaging(string msg);

internal class RadioStation
{
    public event  Messaging Message;

    public void Broadcast()
    {
        Console.WriteLine("Start narrow casting");
        if (Message != null)
        {
            Message("Hello Listeners");
        }
    }
}
