namespace TwoTowers;

internal class Floor
{
    // friend == internal (public withing the library. Private outside
    // internal static Elevator lift = new Elevator();
    private static Elevator lift = new Elevator();

    public int Number { get; set; }

    public void CallElevator()
    {
        lift.Call(Number);
    }
    public void ShowElevatorStatus()
    {
        //Console.WriteLine($"Floor number: {this.Number}");
        Console.WriteLine($"The elevator is on the {Floor.lift.CurrentFloor}th floor");
    }
}
