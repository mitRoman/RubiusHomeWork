class Ping
{
    public delegate Task PingHandler();
    public event PingHandler? PingEvent;

    private Random _random = new Random();

    public async Task StartPing()
    {
        Console.WriteLine("Ping начинает игру!");
        if (PingEvent != null)
        {
            await PingEvent.Invoke();
        }
    }

    public async Task ReceivePong()
    {
        await Task.Delay(300);
        Console.WriteLine("Ping получил Pong");

        if (_random.Next(0, 2) == 0)
        {
            Console.WriteLine("Ping промахнулся! Победил Pong");
        }
        else
        {
            PingEvent?.Invoke();
        }
    }
}