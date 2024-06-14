using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Dream_Notes
{
public static class NoteStorage
{
    private static readonly string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "notes.json");

    public static void SaveNotes(List<Note> notes)
    {
        string json = JsonConvert.SerializeObject(notes, Formatting.Indented);
        File.WriteAllText(filePath, json);
    }

    public static List<Note> LoadNotes()
    {
        if (!File.Exists(filePath))
        {
            return new List<Note>();
        }

        string json = File.ReadAllText(filePath);
        return JsonConvert.DeserializeObject<List<Note>>(json);
    }
}
}

