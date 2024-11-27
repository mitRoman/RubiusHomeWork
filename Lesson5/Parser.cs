class Parser
{
    public double GetParseValue(string? value)
    {
        if (double.TryParse(value, out double parseValue))
            return parseValue;
        throw new ArgumentException("Некорректные данные! Не удалось преобразовать значение.");
    }
}

