class Counter
{
    public delegate void CountHandler(int num);
    public static event CountHandler? ThresholdReached;

    public static async Task StartCount(int num)
    {
        for (int i = 1; i <= 100; i++)
        {
            await Task.Delay(300);
            Console.WriteLine(i);
            if (i == num)
            {
                ThresholdReached?.Invoke(num);
                break;
            }
        }
    }
}
