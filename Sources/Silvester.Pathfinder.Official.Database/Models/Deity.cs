using NpgsqlTypes;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class Deity : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;
        public string Edicts { get; set; } = default!;
        public string Anathema { get; set; } = default!;
        public string Description { get; set; } = default!;

        public Guid CategoryId { get; set; }
        public DeityCategory Category { get; set; } = default!;

        public Guid AlignmentId { get; set; }
        public Alignment Alignment { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public ICollection<Skill> DivineSkills { get; set; } = new List<Skill>();
        public ICollection<DivineFont> DivineFonts { get; set; } = new List<DivineFont>();
        public ICollection<Alignment> FollowerAlignments { get; set; } = new List<Alignment>();
        public ICollection<Domain> Domains { get; set; } = new List<Domain>();
     
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }
}
