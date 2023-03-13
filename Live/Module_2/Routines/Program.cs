namespace Routines
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nr;
            FillItForMe(out nr);
            Console.WriteLine(nr);

            int a = 10;
            int b = 20;

            Console.WriteLine($"a={a}, b={b}");
            // int aa = a;
            // ref int aa = ref a;
            Swap(ref a, ref b);
            Console.WriteLine($"a={a}, b={b}");

            int result = AddNumbers(2, 3);
            //int result = AddNumbers(1, 2, 3, 4, 5, 6, 7, 8, 9, 10 );
            ShowNumber(result);
        }

        static void FillItForMe(out int aaa)
        {
            aaa = 42;
        }

        static void Swap(ref int aa, ref int bb)
        {
            int tmp = aa;
            aa = bb; 
            bb = tmp;
        }

        // Procedure
        static void ShowNumber(int nr)
        {
            Console.WriteLine(nr);
            return;
        }

        // Function
       
        static int AddNumbers(params int[] numbers)
        {
            return numbers.Sum();
        } 
        static int AddNumbers(int a, int b = 40)
        {
            return  a + b;  
        }
    }
}