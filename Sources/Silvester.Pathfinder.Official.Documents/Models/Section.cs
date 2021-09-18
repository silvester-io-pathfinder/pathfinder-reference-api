using System;
using System.Collections.Generic;
using System.Linq;

namespace Silvester.Pathfinder.Official.Documents.Models
{
    public record Section
    {
        public string Title { get; }
        public IReadOnlyList<SubSection> SubSections { get; }

        public Section(string title, IReadOnlyList<SubSection>? subSections = null)
        {
            Title = title;
            SubSections = subSections ?? new List<SubSection>();
        }

        public class Builder
        {
            private string Title { get; }

            private List<SubSection.Builder> SubSections { get; }

            public Builder(string title)
            {
                Title = title;
                SubSections = new List<SubSection.Builder>();
            }

            public Builder AddSubSection(string? title, Action<SubSection.Builder> buildAction)
            {
                SubSection.Builder builder = new SubSection.Builder(title);
                SubSections.Add(builder);
                buildAction(builder);

                return this;
            }

            public Section Build()
            {
                return new Section(Title, SubSections.Select(e => e.Build()).ToList());
            }
        }
    }
}
