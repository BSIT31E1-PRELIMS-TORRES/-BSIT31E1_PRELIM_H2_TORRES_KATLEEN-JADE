using System;
using System.Collections.Generic;
using System.Text;
    namespace ConsoleApp1;

/// <summary>
/// Reads and displays the contents of CSV files.
/// </summary>
public class CsvFileReader : BaseFileReader
{
    public override string SupportedFormat => "CSV";

    protected override void ParseContent(string filePath)
    {
        Console.WriteLine(" -> Opening CSV file...");

        string[] lines = File.ReadAllLines(filePath);

        Console.WriteLine($" -> Successfully parsed {lines.Length} rows.");

        Console.WriteLine("\n--- CSV Content ---");
        foreach (string line in lines.Take(5))
        {
            Console.WriteLine(line);
        }
        Console.WriteLine("-------------------\n");
    }
}
   
