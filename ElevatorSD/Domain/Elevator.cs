namespace Domain;

public class Elevator
{
    private readonly Queue<int> _requests = new();

    public int CurrentFloor { get; private set; }
    public string CurrentDirection { get; private set; }

    private Elevator()
    {
        CurrentFloor = 0;
        CurrentDirection = Direction.Idle;
    }

    public static Elevator Create() => new();

    public void AddRequest(int floor)
    {
        _requests.Enqueue(floor);
    }

    public void ProcessRequest()
    {
        while (_requests.Count != 0)
        {
            int floor = _requests.Dequeue();
            MoveToFloor(floor);
        }
    }

    private void MoveToFloor(int targetFloor)
    {
        if (targetFloor == CurrentFloor)
        {
            CurrentDirection = Direction.Idle;
            Display();
            return;
        }

        CurrentDirection = targetFloor > CurrentFloor ? Direction.Up : Direction.Down;

        while (CurrentFloor != targetFloor)
        {
            CurrentFloor += CurrentDirection == Direction.Up ? 1 : -1;
            Display();
        }
    }

    private void Display()
    {
        Console.WriteLine($"Current Floor: {CurrentFloor}, Current Direction: {CurrentDirection}");
    }
}
