namespace RubiusHomeWork
{
    internal class AirTransportMenu : Menu
    {
        private readonly string[] menu =
        {
            "===== Воздушный транспорт =====",
            "1. Самолёт",
            "2. Вертолет",
            "3. Дирижабль"
        };

        public override void GetMenu()
        {
            foreach (string item in menu)
            {
                Console.WriteLine(item);
            }
        }

        public string GetSubtype(int num)
        {
            if (num <= 0 || num > menu.Length)
            {
                string errorMessage = "Ошибка";
                return errorMessage;
            }
            else
            {
                string item = menu[num];
                int startIndex = item.IndexOf('.') + 2;

                return item.Substring(startIndex);
            }
        }
    }
}
