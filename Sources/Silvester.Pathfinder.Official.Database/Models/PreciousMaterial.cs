﻿using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class PreciousMaterial : BaseEntity
    {
        public string Name { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public ICollection<TextBlock> Details { get; set; } = new List<TextBlock>();

        public ICollection<PreciousMaterialVariant> Variants { get; set; } = new List<PreciousMaterialVariant>();

        public ICollection<Trait> Traits { get; set; } = new List<Trait>();
     
        public ICollection<PreciousMaterialItem> Items { get; set; } = new List<PreciousMaterialItem>();

        public ICollection<PreciousMaterialWeapon> Weapons { get; set; } = new List<PreciousMaterialWeapon>();

        public ICollection<PreciousMaterialArmor> Armors {get; set; } = new List<PreciousMaterialArmor>();

        public ICollection<PreciousMaterialShield> Shields { get; set; } = new List<PreciousMaterialShield>();
    }

    public class PreciousMaterialVariant : BaseEntity
    {
        public string Name { get; set; } = default!;
        public string? NameAddendum { get; set; }

        public int Price { get; set; }

        public int ItemLevel { get; set; }

        public Guid BulkId { get; set; }
        public Bulk Bulk { get; set; } = default!;

        public Guid MaterialId { get; set; }
        public PreciousMaterial Material { get; set; } = default!;
    }

    public class PreciousMaterialItem : BaseEntity
    {
        public int Hardness { get; set; }
        public int HitPoints { get; set; }
        public int BrokenThreshold { get; set; }

        public Guid GradeId { get; set; }
        public ItemGrade Grade { get; set; } = default!;

        public Guid CategoryId { get; set; }
        public PreciousMaterialItemCategory Category { get; set; } = default!;

        public Guid MaterialId { get; set; }
        public PreciousMaterial Material { get; set; } = default!;
    }

    public class PreciousMaterialItemCategory : BaseEntity
    {
        public string Name { get; set; } = default!;

        public ICollection<PreciousMaterialItem> Items { get; set; } = new List<PreciousMaterialItem>();
    }
}
 