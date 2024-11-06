
// ------ Задача #1 -------

bool isCorrect = false;

while (isCorrect == false) {
    Console.Write("Введите номер года: ");
    string yearNumber = Console.ReadLine();

    if (int.TryParse(yearNumber, out int year))
    {
        if (year >= 0 && year <= 30000)
        {
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            Console.WriteLine("");
        }
        else
        {
            Console.WriteLine("Введите целое число от 0 до 30000");
            Console.WriteLine("");
        }
        isCorrect = true;
    }
    else
    {
        Console.WriteLine("Введите корректные данные");
        Console.WriteLine("");
    }
}



//-------- Задача #2 ------------

Console.Write("Введите количество расходов: ");
string input = Console.ReadLine();

int costs = int.TryParse(input, out int parsedCosts) ? parsedCosts : 0;
int[] costsArr = new int[costs];
int summ = 0;

for (int i = 1; i <= costs; i++)
{
    Console.Write($"Введите сумму расхода {i}: ");
    int price = int.TryParse(Console.ReadLine(), out int parsedPrice) ? parsedPrice : 0;
    costsArr[i - 1] = price;
}

foreach (int item in costsArr) {
    summ += item;
}

if (summ == 0)
    Console.WriteLine("Вы ввели некорректные данные");
else
    Console.WriteLine($"Общие расходы за месяц составляют: {summ}");