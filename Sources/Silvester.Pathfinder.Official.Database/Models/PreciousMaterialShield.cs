using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class PreciousMaterialShield : BaseEntity
    {
        public string Name { get; set; } = default!;
        
        public Guid MaterialId { get; set; }
        public PreciousMaterial Material { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public ICollection<Trait> Traits { get; set; } = new List<Trait>();
   
        public ICollection<TextBlock> Details { get; set; } = new List<TextBlock>();

        public ICollection<PreciousMaterialShieldVariant> Variants { get; set; } = new List<PreciousMaterialShieldVariant>();
    }

    public class PreciousMaterialShieldVariant : BaseEntity
    {
        public string Name { get; set; } = default!;

        public string CraftRequirements { get; set; } = default!;

        public int ItemLevel { get; set; }

        public int Price { get; set; }

        public int Hardness { get; set; }

        public int HitPoints { get; set; }

        public int BrokenThreshold { get; set; }

        public Guid ShieldId { get; set; }
        public PreciousMaterialShield Shield { get; set; } = default!;

        public Guid BulkId { get; set; }
        public Bulk Bulk { get; set; } = default!;

        public Guid GradeId { get; set; }
        public ItemGrade Grade { get; set; } = default!;
    }
}
 