using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1;

/// <summary>
/// Reads and displays the contents of XML files.
/// </summary>
public class XmlFileReader : BaseFileReader
{
    public override string SupportedFormat => "XML";

    protected override void ParseContent(string filePath)
    {
        Console.WriteLine(" -> Opening XML file...");

        string xml = File.ReadAllText(filePath);

        Console.WriteLine(" -> Successfully parsed XML.");

        string displayContent = xml.Length > 100
            ? xml.Substring(0, 100) + "..."
            : xml;

        Console.WriteLine("\n--- XML Content ---");
        Console.WriteLine(displayContent);
        Console.WriteLine("-------------------\n");
    }
}
    

