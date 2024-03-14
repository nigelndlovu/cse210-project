using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayJournal()
    {
        foreach (var entry in _entries)
        {
            Console.WriteLine($"Date: {entry.Date}");
            Console.WriteLine($"Prompt: {entry.PromptText}");
            Console.WriteLine($"{entry.EntryText}");
            Console.WriteLine();
        }
    }

    public void SaveJournalToFile(string filename)
    {
        using StreamWriter outputFile = new StreamWriter(filename);
        foreach (var entry in _entries)
        {
            outputFile.WriteLine($"{entry.Date}: {entry.PromptText}");
            outputFile.WriteLine($"Response: {entry.EntryText}");
            outputFile.WriteLine();
        }
    }

    public void LoadJournalFromFile(string filename)
    {
        List<Entry> loadedEntries = [];

        using (StreamReader reader = new(filename))
        {
            while (!reader.EndOfStream)
            {
                string datePromptLine = reader.ReadLine();
                string responseLine = reader.ReadLine();

                string[] datePromptSplit = datePromptLine.Split([':'], 2);
                string[] promptSplit = datePromptSplit[1].Trim().Split([':'], 2);

                DateTime date = DateTime.Now;
                string _date = date.ToShortDateString();
                string prompt = promptSplit[1].Trim();
                string response = responseLine["Response: ".Length..].Trim();

                loadedEntries.Add(new Entry(date, prompt, response));
            }
        }

        _entries = loadedEntries;
    }
}
