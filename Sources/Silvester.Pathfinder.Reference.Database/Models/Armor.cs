using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models
{
    public class Armor : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public int? Level { get; set; }

        public int Price { get; set; }

        public int ArmorClassBonus { get; set; }

        public int DexterityCap { get; set; }

        public int CheckPenalty { get; set; }

        public int SpeedPenalty { get; set; }

        public int Strength { get; set; }

        public Guid BulkId { get; set; }
        public Bulk Bulk { get; set; } = default!;

        public Guid ArmorCategoryId { get; set; }
        public ArmorCategory ArmorCategory { get; set; } = default!;

        public Guid ArmorGroupId { get; set; }
        public ArmorGroup ArmorGroup { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public ICollection<Trait> Traits { get; set; } = new List<Trait>();
        public ICollection<TextBlock> Details { get; set; } = new List<TextBlock >();
     
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }
}
