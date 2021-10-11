using System;
using System.IO;

namespace Silvester.Pathfinder.Reference.Database.Guids
{
    public class Program
    {
        static void Main(string[] args)
        {
            foreach (string filePath in Directory.GetFiles(Path.Combine(Directory.GetCurrentDirectory(), "..", "..", "..", "..", "Silvester.Pathfinder.Reference.Database"), "*.cs", SearchOption.AllDirectories))
            {
                string text = File.ReadAllText(filePath);

                Console.WriteLine("Processing " + filePath);
                bool wasFound = false;
                do
                {
                    Guid id = Guid.NewGuid();
                    text = ReplaceFirstOccurrence(text, "Guid.Parse(\"\")", $"Guid.Parse(\"{id}\")", out wasFound);
                }
                while (wasFound);

                File.WriteAllText(filePath, text);
            }
        }

        public static string ReplaceFirstOccurrence(string source, string find, string replace, out bool found)
        {
            int place = source.IndexOf(find);
            found = place >= 0;

            return found
                ? source.Remove(place, find.Length).Insert(place, replace)
                : source;
        }
    }
}
