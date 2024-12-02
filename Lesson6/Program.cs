// ---------- Задание #1 ----------
string path = @"C:\Users\Public\Book.txt";

if (File.Exists(path))
{
    try
    {
        string content = File.ReadAllText(path);
        int wordCount = 0;

        wordCount = Counter.CountWords(content);

        Console.WriteLine($"Количество слов (чтение всего файла): {wordCount}");

        using (StreamReader reader = new StreamReader(path))
        {
            wordCount = 0;
            string? line;
            while ((line = reader.ReadLine()) != null)
            {
                wordCount += Counter.CountWords(line);
            }
        }

        Console.WriteLine($"Количество слов (потоковая обработка): {wordCount}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Ошибка: {ex.Message}");
    }
}
else
{
    Console.WriteLine("Файл не найден.");
}

Console.WriteLine("====================");
Console.WriteLine();



// ---------- Задание #2 ----------

List<Registration> registrations = new List<Registration>();
List<Question> questions = new List<Question>()
{
    new Question { Number = 1, Text = "Добавить запись"},
    new Question { Number = 2, Text = "Показать все записи (отсортировано по дате)"},
    new Question { Number = 3, Text = "Получить записи по дате"},
    new Question { Number = 4, Text = "Выход"}
};

bool isRunning = true;

while (isRunning)
{
    Console.WriteLine();
    foreach (Question q in questions) { Console.WriteLine($"{q.Number}.{q.Text}"); }

    Console.Write("Выберите действие: ");
    int choice = Parser.GetParseValue(Console.ReadLine());
    
    switch (choice)
    {
        case 1:
            Actions.AddRecords(registrations);
            break;
        case 2:
            Actions.ShowAllRecords(registrations);
            break;
        case 3:
            Actions.GetRecordsByDate(registrations);
            break;
        case 4:
            Console.WriteLine("Выход из программы...");
            isRunning = false;
            break;
        default:
            Console.WriteLine("Неверный выбор. Попробуйте снова.");
            break;
    }
}

