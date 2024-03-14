using System;
using System.Collections.Generic;
using System.IO;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Entry
{
    //DateTime Date = DateTime.Now;
    //string dateText = Date.ToShortDateString();
    
    public DateTime Date { get; set; }
    public string PromptText { get; set; }
    public string EntryText { get; set; }

    public Entry(DateTime date, string prompt, string response)
    {
        Date = date;
        PromptText = prompt;
        EntryText = response;
    }
}
