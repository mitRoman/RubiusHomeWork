using System;
using RubiusHomeWork;

class Program
{
    static void Main()
    {
        Menu menu = new Menu();
        AirTransportMenu airTransport = new AirTransportMenu();
        GroundTransport groundTransport = new GroundTransport();
        WaterTransport waterTransport = new WaterTransport();

        int input = 0; 

        menu.GetMenu();

        while(input == 0)
        {
            Console.Write("Выберите тип транспорта: ");
            input = int.TryParse(Console.ReadLine(), out int parseInput) ? parseInput : 0;

            switch (input)
            {
                case 1:
                    menu.GetSubMenu(input);
                    Console.Write("Выберите подтип транспорта: ");
                    int input2 = int.TryParse(Console.ReadLine(), out parseInput) ? parseInput : 0;
                    Console.WriteLine($"Отлично! Вы выбрали воздушный транспорт - {airTransport.GetSubtype(input2)}");
                    break;
                case 2:
                    menu.GetSubMenu(input);
                    Console.Write("Выберите подтип транспорта: ");
                    input2 = int.TryParse(Console.ReadLine(), out parseInput) ? parseInput : 0;
                    Console.WriteLine($"Отлично! Вы выбрали воздушный транспорт - {groundTransport.GetSubtype(input2)}");
                    break;
                case 3:
                    menu.GetSubMenu(input);
                    Console.Write("Выберите подтип транспорта: ");
                    input2 = int.TryParse(Console.ReadLine(), out parseInput) ? parseInput : 0;
                    Console.WriteLine($"Отлично! Вы выбрали воздушный транспорт - {waterTransport.GetSubtype(input2)}");
                    break;
                default:
                    Console.WriteLine("Выбранного пункта нет в меню. Сделайте другой выбор.");
                    input = 0;
                    break;
            }
        }
    }
}
