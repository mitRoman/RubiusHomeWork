Console.WriteLine("Для выхода из программы введите: exit");
while (true)
{
    Console.Write("Введите номер года: ");

    string str = Console.ReadLine();

    if(str.ToLower() == "exit")
    {
        break;
    }

    if (int.TryParse(str, out int year))
    {
        if (year >= 0 && year <= 30000)
        {
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            Console.WriteLine("");
        }
        else
        {
            Console.WriteLine("Введите целое число от 0 до 30000");
            Console.WriteLine("");
        }
    }
    else
    {
        Console.WriteLine("Введите корректные данные");
        Console.WriteLine("Для выхода из программы введите: exit");
        Console.WriteLine("");
    }
}