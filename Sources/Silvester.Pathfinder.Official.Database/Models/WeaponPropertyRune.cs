using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class WeaponPropertyRune : BaseEntity
    {
        public string Name { get; set; } = default!;

        public string? CraftingRequirements { get; set; }

        public string? AccessRequirements { get; set; }

        public string Usage { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public ICollection<ArmorPropertyRuneAction> Actions { get; set; } = default!;

        public ICollection<Trait> Traits { get; set; } = new List<Trait>();
        
        public ICollection<WeaponPropertyRunePotencyBinding> Potencies { get; set; } = new List<WeaponPropertyRunePotencyBinding>();
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
}
