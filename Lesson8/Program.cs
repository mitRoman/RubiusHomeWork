//------------- Задание #1 -------------
public class Program
{
    public static async Task Main(string[] args)
    {

        Console.Write("Введите число от 1 до 100: ");
        if (!int.TryParse(Console.ReadLine(), out int num) || num < 1 || num > 100)
        {
            Console.WriteLine("Введено некорректное число. Завершение программы.");
            return;
        }

        Counter.ThresholdReached += Handler1.InfoMessage;
        Counter.ThresholdReached += Handler2.InfoMessage;

        await Counter.StartCount(num);



        //------------- Задание #2 -------------
        var ping = new Ping();
        var pong = new Pong();

        ping.PingEvent += pong.ReceivePing;
        pong.PongEvent += ping.ReceivePong;

        await ping.StartPing();
    }
}