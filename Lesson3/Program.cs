// ------ Задача #1 -------

bool isCorrect = false;

while (isCorrect == false)
{
    Console.Write("Введите сумму дохода: ");
    string? input = Console.ReadLine();

    decimal summ = decimal.TryParse(input, out decimal parseInput) ? parseInput : 0;

    if (summ <= 0)
    {
        Console.WriteLine("Ошибка! Введите корректные данные!");
        Console.WriteLine();
    }
    else
    {
        taxCalculation(summ);
        isCorrect = true;
    }
}

void taxCalculation(decimal summ)
{
    decimal tax = Math.Round(summ * 13 / 100, 2);

    Console.WriteLine($"Сумма налогов к уплате: {tax}");
}




// ------ Задача #2 --------

string[] menu = new string[5];
menu = ["-------- МЕНЮ --------", "1. Добавить товар", "2. Просмотреть все товары", "3. Удалить товар", "4. Найти товар", "5. Выйти", "======================"];

Dictionary<string, int> supplies = new Dictionary<string, int>();
supplies["Яблоки"] = 10;
supplies["Ананасы"] = 3;
supplies["Бананы"] = 23;

int item = 0;

DisplayMenu();

while (item != 5)
{
    Console.WriteLine();
    Console.Write("Выберите дейстие из МЕНЮ: ");
    string? inputStr = Console.ReadLine();

    item = int.TryParse(inputStr, out int parseInputStr) ? parseInputStr : 0;

    if (item == 0)
        ErrorMessage();
    else if (item == 1)
        AddItem();
    else if (item == 2)
        DisplaySupplies();
    else if (item == 3)
        DeleteItem();
    else if (item == 4)
        SearchItem();
    else if (item == 5)
        break;
    else
        ErrorMessage();
}

void DisplayMenu()
{
    foreach (var item in menu)
    {
        Console.WriteLine(item);
    }
}

void ErrorMessage()
{
    Console.WriteLine();
    Console.WriteLine("Ошибка! Введите корректные данные!");
}

void AddItem()
{
    Console.Write("Введите название товара для добавления: ");
    string? inputName = Console.ReadLine();
    Console.Write("Введите количество: ");
    string? inputCount = Console.ReadLine();

    if(int.TryParse(inputCount, out int count))
    {
        if (supplies.ContainsKey(inputName))
        {
            supplies[inputName] += count;
            Console.WriteLine($"Количество товара '{inputName}' было увеличено на {count}");
        }
        else
        {
            supplies.Add(inputName, count);
            Console.WriteLine($"Добавлен новый товар '{inputName}' в кол-ве {count}");
        }
    }
    else
    {
        ErrorMessage();
    }
}

void DisplaySupplies()
{
    Console.WriteLine();
    Console.WriteLine("Список товаров в наличии:");
    foreach (var supp in supplies)
    {
        Console.WriteLine($"{supp.Key}: {supp.Value}");
    }
}

void DeleteItem()
{
    Console.Write("Введите название товара для удаления: ");
    string? inputName = Console.ReadLine();

    if (supplies.Remove(inputName))
        Console.WriteLine($"Товар '{inputName}' был удален");
    else
        Console.WriteLine("Товар не найден!");
}

void SearchItem()
{
    Console.Write("Введите название товара для поиска: ");
    string? inputName = Console.ReadLine();
    if (supplies.TryGetValue(inputName, out int count))
    {
        Console.WriteLine($"Товар '{inputName}' найден. Кол-во: {count}");
    }
    else
    {
        Console.WriteLine($"Товар '{inputName}' не найден.");
    }
}