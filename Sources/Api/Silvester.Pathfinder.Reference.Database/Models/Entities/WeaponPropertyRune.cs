using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Silvester.Pathfinder.Reference.Database.Seeding;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class WeaponPropertyRune : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public string? CraftingRequirements { get; set; }

        public string? AccessRequirements { get; set; }

        public string Usage { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public ICollection<WeaponPropertyRuneAction> Actions { get; set; } = default!;

        public ICollection<Trait> Traits { get; set; } = new List<Trait>();
        
        public ICollection<WeaponPropertyRunePotencyBinding> Potencies { get; set; } = new List<WeaponPropertyRunePotencyBinding>();
     
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class WeaponPropertyRuneAction : BaseEntity
    {
        public string Name { get; set; } = default!;

        public string Effect { get; set; } = default!;

        public string? Frequency { get; set; }

        public string? Requirements { get; set; }

        public string? Trigger{ get; set; }

        public Guid ActionTypeId { get; set; }
        public ActionType ActionType { get; set; } = default!;

        public Guid RuneId { get; set; }
        public WeaponPropertyRune Rune { get; set; } = default!;

        public ICollection<Trait> Traits { get; set; } = new List<Trait>();
    }

    public class WeaponPropertyRunePotencyBinding : BaseEntity
    {
        public int Price { get; set; }
        
        public int ItemLevel { get; set; }

        public Guid RuneId { get; set; }
        public WeaponPropertyRune Rune { get; set; } = default!;

        public Guid? RollableEffectId { get; set; }
        public RollableEffect? RollableEffect { get; set; }

        public Guid PotencyId { get; set; }
        public Potency Potency { get; set; } = default!;
        
        public ICollection<TextBlock> Benefits { get; set; } = default!;

        public ICollection<Trait> Traits { get; set; } = new List<Trait>();
    }

    public class WeaponPropertyRuneSearchConfigurator : SearchableEntityConfigurator<WeaponPropertyRune>
    {
        public override Expression<Func<WeaponPropertyRune, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.AccessRequirements, e.CraftingRequirements, e.Usage };
        }
    }
}
