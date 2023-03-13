namespace Basics;

internal class Program
{

    static void Main()
    {
        int age = 42;
        bool isOk = true;
        int? gender = 4;
        decimal price = 10.12345M;
        string? name =null;
        char initial = 'A';

        int result = 10;
        result += 2;

        Console.WriteLine(result);
        Console.WriteLine(name?.Length);

    }
}