namespace RubiusHomeWork
{
    internal class GroundTransport : Menu
    {
        string[] menu =
        [
            "===== Наземный транспор =====",
            "1. Легковой автомобиль",
            "2. Велосипед",
            "3. Грузовик"
        ];

        public override void GetMenu()
        {

            foreach (string item in menu)
            {
                Console.WriteLine(item);
            }
        }

        public string GetSubtype(int num)
        {
            string item = menu[num];
            int startIndex = item.IndexOf('.') + 2;
            return item.Substring(startIndex);
        }
    }
}
