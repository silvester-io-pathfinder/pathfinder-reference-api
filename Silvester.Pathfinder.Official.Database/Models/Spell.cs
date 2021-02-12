using Silvester.Pathfinder.Official.Database;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class Spell : BaseEntity
    {
        public string Name { get; set; } = default!;

        public string Description { get; set; } = default!;

        public int? Range { get; set; }

        public TimeSpan? CastTime { get; set; }

        public int Level { get; set; }

        public string? Targets { get; set; }

        public bool IsDismissable { get; set; } 

        public string? Area { get; set; }

        public string? Duration { get; set; } 

        public Guid? ActionTypeId { get; set; }
        public ActionType? ActionType { get; set; }

        public Guid SpellTypeId { get; set; }
        public SpellType SpellType { get; set; } = default!;

        public Guid? SavingThrowStatId { get; set; }
        public SavingThrowStat? SavingThrowStat { get; set; }

        public RollableEffect? RollableEffect { get; set; }
        public Guid? RollableEffectId { get; set; }

        public MagicSchool MagicSchool { get; set; } = default!;
        public Guid MagicSchoolId { get; set; }

        public ICollection<SpellDetailBlock> AdditionalDetails { get; set; } = new List<SpellDetailBlock>();

        public ICollection<MagicTradition> Traditions { get; set; } = new List<MagicTradition>();

        public ICollection<SpellComponent> Components { get; set; } = new List<SpellComponent>();

        public ICollection<Trait> Traits { get; set; } = new List<Trait>();

        public ICollection<SpellHeightening> Heightenings { get; set; } = new List<SpellHeightening>();

        public ICollection<SpellTrigger> Triggers { get; set; } = new List<SpellTrigger>();

        public ICollection<SpellRequirement> Requirements { get; set; } = new List<SpellRequirement>();
    }
}
