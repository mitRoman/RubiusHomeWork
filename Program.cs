class Program
{
    public static async Task Main(string[] args)
    {
        string path = "resource\\Book.txt";

        string fullPath = Path.Combine(Directory.GetCurrentDirectory(), path);

        if (File.Exists(fullPath))
        {
            try
            {
                string content = await File.ReadAllTextAsync(fullPath);
                int wordCount = 0;

                wordCount = Counter.CountWords(content);

                Console.WriteLine($"Количество слов (чтение всего файла): {wordCount}");

                using (StreamReader reader = new StreamReader(fullPath))
                {
                    wordCount = 0;
                    string? line;
                    while ((line = await reader.ReadLineAsync()) != null)
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
    }
}