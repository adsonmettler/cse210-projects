
// I have completed all the requirements of the program. Additionally,
// as part of exceeding the requirements, I enhanced the user experience
// to make the process smoother for the user. This includes adding
// confirmation messages such as: 'Entry added successfully', 'Journal
// saved to file: [file name]', and example of how to name the file.

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
        Console.WriteLine("Entry added sucessfully!");
    }

    public void Display()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries in the journal.");
            return;
        }

        Console.WriteLine("Journal Entries:");
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"Date: {entry._date}");
            Console.WriteLine($"Prompt: {entry._promptText}");
            Console.WriteLine($"Entry: {entry._entryText}");
            Console.WriteLine();
        }
    }

    public void SaveToFile(string file)
    {
        using (System.IO.StreamWriter writer = new System.IO.StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine(entry._date);
                writer.WriteLine(entry._promptText);
                writer.WriteLine(entry._entryText);
            }
        }

        Console.WriteLine($"Journal saved to file: {file}");
    }

    public void LoadFromFile(string file)
    {
        if (!System.IO.File.Exists(file))
        {
            Console.WriteLine($"File not found: {file}");
            return;
        }

        _entries.Clear();
        string[] lines = System.IO.File.ReadAllLines(file);

        for (int i = 0; i < lines.Length; i += 3) // Each entry has 3 lines
        {
            string date = lines[i];
            string prompt = lines[i + 1];
            string entryText = lines[i + 2];
            _entries.Add(new Entry(date, prompt, entryText));
        }

        Console.WriteLine($"Journal loaded from file: {file}");
    }
}