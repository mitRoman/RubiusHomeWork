internal class Parser
{
    public static DateTime GetParseValue(string input)
    {
        DateTime dateTime = DateTime.TryParse(input, out DateTime result) ? result : DateTime.MinValue;
        return dateTime;
    }
}

