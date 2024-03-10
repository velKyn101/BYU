using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        Entry copyEntry = new Entry(); // Create a new instance of Entry
        copyEntry._promptText = newEntry._promptText; // Set the properties of the new instance
        copyEntry._entryText = newEntry._entryText;
        // Set other properties as needed
        _entries.Add(copyEntry); // Add the new instance to the list
    }

    public void DisplayAll()
    {
        Console.WriteLine("Entries in the journal:");
        foreach (Entry entry in _entries){
        entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        string folder = @"C:\Users\kelvy\OneDrive\Área de Trabalho\BYU\cse210-projects-main\prove\Develop02";
        string filename = file;
        string fullPath = Path.Combine(folder, filename);
        using (StreamWriter outputFile = new StreamWriter(fullPath))
        {   
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}~Prompt: {entry._promptText}~{entry._entryText}~");
            }  
        }
    }

    public void LoadFromFile(string file)
    {
        string folder = @"C:\Users\kelvy\OneDrive\Área de Trabalho\BYU\cse210-projects-main\prove\Develop02";
        string filename = file;
        string fullPath = Path.Combine(folder, filename);
        string [] lines = System.IO.File.ReadAllLines(fullPath);

    foreach (string line in lines)
    {
        string[] parts = line.Split('~');

        string date = parts[0];
        string prompt = parts[1];
        string entries = parts[2];

        Entry newEntry = new Entry();
        {
            newEntry._date = DateTime.Parse(date);
            newEntry._promptText = prompt;
            newEntry._entryText = entries;
        };
        _entries.Add(newEntry);
    }
}
}   