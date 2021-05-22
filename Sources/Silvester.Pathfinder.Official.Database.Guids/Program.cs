using System;
using System.IO;

namespace Silvester.Pathfinder.Official.Database.Guids
{
    public class Program
    {
        static void Main(string[] args)
        {
            foreach (string filePath in Directory.GetFiles(Path.Combine(Directory.GetCurrentDirectory(), "..", "..", "..", "..", "Silvester.Pathfinder.Official.Database"), "*.cs", SearchOption.AllDirectories))
            {
                Console.WriteLine("Processing: " + filePath);
                Guid id = Guid.NewGuid();
                string text = File.ReadAllText(filePath);
                text = text.Replace("Guid.Parse(\"\")", $"Guid.Parse(\"{id}\")");
                File.WriteAllText(filePath, text);
            }
        }
    }
}
