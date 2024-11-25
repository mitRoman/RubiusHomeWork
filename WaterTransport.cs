namespace RubiusHomeWork
{
    internal class WaterTransport : Menu
    {
        string[] menu =
            [
                "===== Водный транспорт =====",
                "1. Катер",
                "2. Теплоход",
                "3. Баржа"
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
