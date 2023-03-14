namespace TwoTowers;

internal class Elevator
{
    public int CurrentFloor { get; set; } = 0;

    public  void Call(int floor)
    {
        Console.WriteLine($"Elevator travels to the {floor}th floor");
        CurrentFloor = floor;
    }
}
