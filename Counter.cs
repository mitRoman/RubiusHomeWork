class Counter
{
    public static int CountWords(string content)
    {
        char[] delimiters = { ' ', '\t', '\n', '\r', '.', ',', ';', ':', '!', '?' };
        return content.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Length;
    }
}
