namespace RubiusHomeWork
{
    internal class Menu
    {
        public virtual void GetMenu()
        {
            string[] mainMenu =
            [
            "===== Тип транспорта =====",
            "1. Воздушный",
            "2. Наземный",
            "3. Водный"
            ];

            foreach (string item in mainMenu)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }

        public void GetSubMenu(int input)
        {
            AirTransportMenu airTransport = new AirTransportMenu();
            GroundTransport groundTransport = new GroundTransport();
            WaterTransport waterTransport = new WaterTransport();

            switch (input) {
                case 1:
                    airTransport.GetMenu();
                    break;
                case 2:
                    groundTransport.GetMenu();
                    break;
                case 3:
                    waterTransport.GetMenu();
                    break;
            }
        }
    }
}
