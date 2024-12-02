internal class Parser
{
    public static int GetParseValue(string choice)
    {
        int num = int.TryParse(choice, out int parseInt) ? parseInt : 0;
        return num;
    }
}

