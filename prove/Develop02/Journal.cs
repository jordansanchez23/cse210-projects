using System.IO;

public class Journal
{
    public List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            outputFile.WriteLine("Prompts, answers, and locations:");
            foreach (var entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}|{entry._location}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        if (!File.Exists(file))
        {
            Console.WriteLine("File not found.");
            return;
        }

        List<Entry> loadedEntries = new List<Entry>();
        string[] lines = File.ReadAllLines(file);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');
            if (parts.Length >= 4)
            {
                string date = parts[0].Trim();
                string promptText = parts[1].Trim();
                string entryText = parts[2].Trim();
                string location = parts[3].Trim(); //Exceeding requirements 
                

                Entry newEntry = new Entry(date, promptText, entryText, location);
                loadedEntries.Add(newEntry);
            }
        }

        _entries = loadedEntries;
        Console.WriteLine("Journal loaded successfully.");
    }
}
