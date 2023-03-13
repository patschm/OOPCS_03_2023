using System.Diagnostics;
using System.Text;
using System.Threading.Channels;

namespace Collections;

internal class Program
{
    static void Main(string[] args)
    {
        Stopwatch sw = new Stopwatch();
        //string str = ""; // char[]
        StringBuilder str = new StringBuilder();
        sw.Start();
        for (int i = 0; i < 100000; i++)
        {
            //str += i;
            str.Append(i);
        }
        sw.Stop();
        Console.WriteLine(sw.Elapsed);


        int[] array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //array[0] = 1;
        //array[9] = 10;

        int[,] matrix = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
        int[,,] cube = new int[2, 2, 2] { { { 1, 2 }, { 4, 5 } }, { { 5, 6 }, { 7, 8 } } };

        int[][] jagged = new int[2][];
        jagged[0] = new int[3] { 1, 2, 3 };
        jagged[1] = array;

        List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Dictionary<string, int> dict = new Dictionary<string, int>();
        dict.Add("one", 1);
        dict.Add("two", 2);
        dict.Add("three", 3);
        dict.Add("four", 4);
        dict.Add("five", 5);
        //dict.Add("one", 6);

        Console.WriteLine(array[4]);
        Console.WriteLine(matrix[1, 1]);
        Console.WriteLine(cube[0, 1, 1]);
        Console.WriteLine(jagged[1][4]);
        Console.WriteLine(list[4]);
        Console.WriteLine(dict["five"]);

        int x;
        if (dict.TryGetValue("one", out x))
        {
            Console.WriteLine(x);
        }

        foreach(var tmp in dict)
        {
            Console.WriteLine(tmp.Value);
        }
    }
}