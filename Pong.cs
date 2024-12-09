class Pong
{
    public delegate Task PongHandler();
    public event PongHandler? PongEvent;

    private Random _random = new Random();

    public async Task ReceivePing()
    {
        await Task.Delay(300);
        Console.WriteLine("Pong получил Ping");

        if (_random.Next(0, 2) == 0)
        {
            Console.WriteLine("Pong промахнулся! Победил Ping");
        }
        else
        {
            PongEvent?.Invoke();
        }
    }
}