using System;
using System.Collections.Generic;
using System.Linq;

namespace Silvester.Pathfinder.Reference.Documents.Models
{
    public record Document
    {
        public DateTime CreationDate { get; }
        public DateTime LastModificationDate { get; }
        public int Version { get; }
        public IReadOnlyList<Section> Sections { get; }

        public Document(DateTime creationDate, DateTime lastModificationDate, int version, IReadOnlyList<Section> sections)
        {
            CreationDate = creationDate;
            LastModificationDate = lastModificationDate;
            Version = version;
            Sections = sections;
        }

        public class Builder
        {
            private List<Section.Builder> Sections { get; }
            private DateTime CreationDate { get; }
            private DateTime LastModificationDate { get; }
            private int Version { get; }

            public Builder(DateTime creationDate, DateTime lastModificationDate, int version)
            {
                Sections = new List<Section.Builder>();
                CreationDate = creationDate;
                LastModificationDate = lastModificationDate;
                Version = version;
            }

            public Builder AddSection(string title, Action<Section.Builder> buildAction)
            {
                Section.Builder builder = new Section.Builder(title);
                buildAction(builder);
                Sections.Add(builder);

                return this;
            }

            public Document Build()
            {
                return new Document(CreationDate, LastModificationDate, Version, Sections.Select(e => e.Build()).ToList());
            }
        }
    }
}
