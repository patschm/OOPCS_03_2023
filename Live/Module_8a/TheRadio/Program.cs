namespace TheRadio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var r10 = new RadioStation();
            r10.Message += ByEmail;
            r10.Message += ByPost;
            r10.Message += ByCable;
            r10.Message += BySMS;
            r10.Message += ByPigean;
            r10.Message += ByCable;
            r10.Message += ByEmail;
            r10.Message += ByPost;
            r10.Message += ByCable;
            r10.Message += BySMS;
            r10.Message += ByPigean;
            r10.Message += ByCable;
            r10.Message += ByEmail;
            r10.Message += ByPost;
            r10.Message += ByCable;
            r10.Message += BySMS;
            r10.Message += ByPigean;
            r10.Message += ByCable;

            r10.Broadcast();

            //r10.Message("Hey Suckers!!!!");

        }


        static void ByEmail(string txt)
        {
            Console.WriteLine($"Received by Email: {txt}");
        }
        static void BySMS(string txt)
        {
            Console.WriteLine($"Received by SMS: {txt}");
        }
        static void ByCable(string txt)
        {
            Console.WriteLine($"Received by Cable: {txt}");
        }
        static void ByPost(string txt)
        {
            Console.WriteLine($"Received by Post: {txt}");
        }
        static void ByPigean(string txt)
        {
            Console.WriteLine($"Received by Pigeon: {txt}");
        }
    }
}