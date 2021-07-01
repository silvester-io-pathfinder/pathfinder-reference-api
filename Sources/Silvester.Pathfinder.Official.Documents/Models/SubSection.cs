using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Documents.Models
{
    public record SubSection
    {
        public string? Title { get; }
        public IReadOnlyList<string> Paragraphs { get; }

        public SubSection(string? title = null, List<string>? paragraphs = null)
        {
            Title = title;
            Paragraphs = paragraphs ?? new List<string>();
        }

        public class Builder
        {
            private List<string> Paragraphs { get; }
            private string? Title { get; }

            public Builder(string? title)
            {
                Paragraphs = new List<string>();
                Title = title;
            }

            public Builder AddParagraph(string text)
            {
                Paragraphs.Add(text);
                return this;
            }

            public SubSection Build()
            {
                return new SubSection(Title, Paragraphs);
            }
        }
    }
}
