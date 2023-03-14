namespace TwoTowers;

internal class Program
{
    static void Main(string[] args)
    {
        Point p1 = new Point { X=10, Y=20 };
        Point p2 = new Point { X=100, Y=200 };

        Point p3 = p1 + p2; //Point.Add(p1, p2);
        p3.Show();


        Floor[] tower = new Floor[42];
        for (int i = 0; i < tower.Length; i++)
        {
            tower[i] = new Floor { Number = i };
        }

        tower[23].CallElevator();

        //ShowStatus(tower);

    }

    static void ShowStatus(Floor[] tw)
    {
        foreach (var et in tw)
        {
            et.ShowElevatorStatus();
        }
    }

}