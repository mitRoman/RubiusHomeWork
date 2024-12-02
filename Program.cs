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



// ---------- Задание #2 ----------



Console.Write("Введите дату регистрации:");
string str = Console.ReadLine();

Parser parser = new Parser(str);


class Person : Registration
{
    public string Name { get; set; }


}



