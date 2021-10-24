using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class Stave : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public string Usage { get; set; } = default!;

        public string CraftingRequirements { get; set; } = default!;
        
        public string Activate { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public ICollection<StavePotencyBinding> Potencies { get; set; }  = new List<StavePotencyBinding>();
        public ICollection<Trait> Traits { get; set; }  = new List<Trait>();
        public ICollection<TextBlock> Details { get; set; }  = new List<TextBlock>();
        public ICollection<ActionEffect> Effects { get; set; }  = new List<ActionEffect>();
     
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class StavePotencyBinding : BaseEntity
    {
        public int Price { get; set; }
        
        public string? Addendum { get; set; }

        public int ItemLevel { get; set; }

        public Guid StaveId { get; set; }
        public Stave Stave { get; set; } = default!;

        public Guid BulkId { get; set; }
        public Bulk Bulk { get; set; } = default!;

        public Guid PotencyId { get; set; }
        public Potency Potency { get; set; } = default!;

        public ICollection<StaveSpell> Spells { get; set; } = new List<StaveSpell>();
        public ICollection<Trait> Traits { get; set; }  = new List<Trait>();
    }

    public class StaveSpell : BaseEntity
    {
        public int? Level { get; set; }

        public Guid PotencyBindingId { get; set; }
        public StavePotencyBinding PotencyBinding { get; set; } = default!;

        public Guid SpellId { get; set; }
        public Spell Spell { get; set; } = default!;
    }
}
