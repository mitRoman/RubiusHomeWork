class Actions
{
    public static void AddRecords(List<Registration> records)
    {
        Console.Write("Введите фамилию: ");
        string surname = Console.ReadLine();

        Console.Write("Введите дату регистрации (гггг-мм-дд): ");
        if (DateTime.TryParse(Console.ReadLine(), out DateTime date))
        {
            records.Add(new Registration { Surname = surname, RegistrationDate = date });
            Console.WriteLine("Запись успешно добавлена!");
        }
        else
        {
            Console.WriteLine("Некорректный формат даты. Попробуйте снова.");
        }

        Console.WriteLine("-----------------------");
    }

    public static void ShowAllRecords(List<Registration> records)
    {
        var sortedRecords = records.OrderBy(r => r.RegistrationDate).ToList();

        if(!sortedRecords.Any())
        {
            Console.WriteLine("Нет записей!");
            return;
        }

        Console.WriteLine("Все записи (отсортированы по дате): ");
        foreach (var s in sortedRecords)
        {
            Console.WriteLine($"{s.RegistrationDate:yyyy-MM-dd}: {s.Surname}");
        }

        Console.WriteLine("-----------------------");
    }

    public static void GetRecordsByDate(List<Registration> records)
    {
        Console.WriteLine("Введите дату регистрации");

        if (DateTime.TryParse(Console.ReadLine(), out DateTime date))
        {
            var findRecord = records.Where(r => r.RegistrationDate == date);

            if (!findRecord.Any())
            {
                Console.WriteLine("Записей на указанную дату нет");
                return;
            }

            Console.WriteLine($"Запись на дату: {date}");
            foreach (var record in findRecord)
            {
                Console.WriteLine($"{record.RegistrationDate:yyyy-MM-dd}: {record.Surname}");
            }
        }
        else
        {
            Console.WriteLine("Не корректный формат даты! Попробуйте снова");
        }

        Console.WriteLine("-----------------------");
    }
}

