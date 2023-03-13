using System.Threading.Channels;

namespace Flowing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 15;

            int looper = 0;

            // Executes 1 or more times
            do
            {
                Console.WriteLine($"Do {looper++}");
            }
            while (looper <= 15);

            // Execute 0 or more times
            while(looper <= 15)
            {
                Console.WriteLine($"While {looper++}");
            }

            // When you know how often to repeat
            for(looper = 0; looper <= 15;looper+=3 )
            {
                if (looper == 9)
                {                           
                    continue;
                }
                //if (looper <= 15)
                //{
                    Console.WriteLine($"For {looper}");
                //}
               //else
               // {
               //     break;
               // }             
            }


            // Jump forward
            switch (age)
            {
                case -1:
                case 0:
                    Console.WriteLine("zero");
                    break;
                case 1:
                    Console.WriteLine("One");
                    break;
                default:
                    Console.WriteLine("Else");
                    break;
            }


            if (age < 10)
            {

            }
            else if (age >= 10 && age < 20)
            {
            }
            else
            {

            }
        }
    }
}