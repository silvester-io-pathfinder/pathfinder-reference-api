using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class AdventuringGearVariant : BaseEntity
    {
        public string NameAddendum { get; set; } = default!;

        public string? DescriptionAddendum { get; set; } 

        public int? Hands { get; set; } = default!;

        public int ItemLevel { get; set; } = default!;

        public int Price { get; set; }

        public Guid BulkId { get; set; }
        public Bulk Bulk { get; set; } = default!;

        public Guid RarityId { get; set; }
        public Rarity Rarity { get; set; } = default!;

        public Guid AdventuringGearId { get; set; }
        public AdventuringGear AdventuringGear { get; set; } = default!;
    }
}
