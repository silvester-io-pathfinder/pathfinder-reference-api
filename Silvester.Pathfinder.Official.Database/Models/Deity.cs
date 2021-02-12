using Silvester.Pathfinder.Official.Database;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class Deity : BaseEntity
    {
        public string Name { get; set; } = default!;

        public Guid CategoryId { get; set; }
        public DeityCategory Category { get; set; } = default!;

        public Guid AlignmentId { get; set; }
        public Alignment Alignment { get; set; } = default!;

        public ICollection<DeityFollowerAlignment> FollowerAlignments { get; set; } = new List<DeityFollowerAlignment>();
        public ICollection<DivineFont> DivineFonts { get; set; } = new List<DivineFont>();
        public ICollection<Domain> Domains { get; set; } = new List<Domain>();
    }
}
