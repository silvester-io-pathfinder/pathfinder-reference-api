using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class Philosophy : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;
        public string? Edicts { get; set; } 
        public string? Anathema { get; set; } 
        public string? AreasOfConcern { get; set; } 

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public ICollection<TextBlock> Details { get; set; } = new List<TextBlock>();
        public ICollection<Alignment> FollowAlignments { get; set; } = new List<Alignment>();

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }
}
