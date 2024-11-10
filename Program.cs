// ------ Задача #1 -------

bool isCorrect = false;

while (isCorrect == false)
{
    Console.Write("Введите сумму дохода: ");
    string? input = Console.ReadLine();

    decimal summ = decimal.TryParse(input, out decimal parseInput) ? parseInput : 0;
    if (summ <= 0) {
        Console.WriteLine("Ошибка! Введите корректные данные!");
        Console.WriteLine();
    }
    else {
        taxCalculation(summ);
        isCorrect = true;
    }
}

void taxCalculation(decimal summ) {

    decimal tax = Math.Round(summ * 13 / 100, 2);

    Console.WriteLine($"Сумма налогов к уплате: {tax}");
}




