using NpgsqlTypes;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class AdventuringGear : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;
        
        public string Hands { get; set; } = default!;

        public int ItemLevel { get; set; } = default!;

        public int Price { get; set; }

        public Guid BulkId { get; set; }
        public Bulk Bulk { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public Guid RarityId { get; set; }
        public Rarity Rarity { get; set; } = default!;

        public ICollection<TextBlock> Details { get; set; } = new List<TextBlock>();

        public ICollection<AdventuringGearVariant> Variants { get; set; } = new List<AdventuringGearVariant>();

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }
}
