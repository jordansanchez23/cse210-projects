public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _location; // Location of the activities
    public Entry (string date, string promptText, string entryText, string location)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
        _location = location;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine($"Location/Context: {_location}");
        Console.WriteLine();
    }
}