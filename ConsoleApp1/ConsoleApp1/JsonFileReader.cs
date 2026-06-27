using System;
using System.Collections.Generic;
using System.Text;

    namespace ConsoleApp1;

/// <summary>
/// Reads and displays the contents of JSON files.
/// </summary>
public class JsonFileReader : BaseFileReader
{
    public override string SupportedFormat => "JSON";

    protected override void ParseContent(string filePath)
    {
        Console.WriteLine(" -> Opening JSON file...");

        string json = File.ReadAllText(filePath);

        Console.WriteLine(" -> Successfully parsed JSON.");

        string displayContent = json.Length > 100
            ? json.Substring(0, 100) + "..."
            : json;

        Console.WriteLine("\n--- JSON Content ---");
        Console.WriteLine(displayContent);
        Console.WriteLine("--------------------\n");
    }
}
  
