namespace session_12.Utilities;

public static class DictionaryReader
{
    public static string[] ReadWords()
    {
        string filePath = Path.Combine(AppContext.BaseDirectory, "DataFiles", "dictionary_english.txt");
        return File.ReadAllLines(filePath)
            .Where(line => !string.IsNullOrWhiteSpace(line))
            .ToArray();
    }
}
