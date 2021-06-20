using NpgsqlTypes;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class Shield : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public int Price { get; set; }

        public int ArmorClassBonus { get; set; }

        public int SpeedPenalty { get; set; }

        public int Hardness { get; set; }

        public int HitPoints { get; set; }

        public int BrokenThreshold { get; set; }

        public Guid BulkId { get; set; }
        public Bulk Bulk { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public ICollection<TextBlock> Details { get; set; } = new List<TextBlock>();
        
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }
}
