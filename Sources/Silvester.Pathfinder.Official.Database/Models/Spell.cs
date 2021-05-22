using Silvester.Pathfinder.Official.Database.Utilities.Tables;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class Spell : BaseEntity
    {
        public string Name { get; set; } = default!;

        public int Level { get; set; }

        public string? Addendum { get; set; }

        public string? Range { get; set; }

        public string? Area { get; set; }
        
        public string? Cost { get; set; }

        public string? Targets { get; set; }

        public string? CastTime { get; set; }

        public string? Trigger { get; set; }

        public string? Duration { get; set; }
        
        public string? Requirements { get; set; }

        public bool? IsSavingThrowBasic { get; set; }

        public bool IsDismissable { get; set; } 

        public Guid? ActionTypeId { get; set; }
        public ActionType? ActionType { get; set; }

        public Guid SpellTypeId { get; set; }
        public SpellType SpellType { get; set; } = default!;

        public Guid? SavingThrowStatId { get; set; }
        public SavingThrowStat? SavingThrowStat { get; set; }

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public Guid? TableId { get; set; }
        public Table? Table { get; set; }

        public Guid MagicSchoolId { get; set; }
        public MagicSchool MagicSchool { get; set; } = default!;

        public Guid? ClassId { get; set; }
        public Class? Class { get; set; }

        public Guid? MysteryId { get; set; }
        public Mystery? Mystery { get; set; }

        public Guid? DomainId { get; set; }
        public Domain? Domain { get; set; }

        public ICollection<RollableEffect> RollableEffects { get; set; } = new List<RollableEffect>();
        
        public ICollection<TextBlock> Details { get; set; } = new List<TextBlock>();

        public ICollection<SpellComponent> Components { get; set; } = new List<SpellComponent>();

        public ICollection<Trait> Traits { get; set; } = new List<Trait>();

        public ICollection<SpellHeightening> Heightenings { get; set; } = new List<SpellHeightening>();

        public ICollection<ActionEffect> ActionEffects { get; set; } = new List<ActionEffect>();

        public ICollection<StaggeredEffect> StaggeredEffects { get; set; } = new List<StaggeredEffect>();
     
        public ICollection<Creature> CreatureEffects { get; set; } = new List<Creature>();

        public ICollection<MagicTradition> Traditions { get; set; } = new List<MagicTradition>();
    }

    public class SpellHeightening : BaseEntity
    {
        public string Level { get; set; } = default!;

        public ICollection<TextBlock> Details { get; set; } = new List<TextBlock>();

        public Guid SpellId { get; set; }
        public Spell Spell { get; set; } = default!;
    }

}
