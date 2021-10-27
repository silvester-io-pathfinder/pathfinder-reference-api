using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class Spell : BaseEntity, ISearchableEntity, INamedEntity
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

        public Guid? InitialRevelationOfId { get; set; }
        public Mystery? InitialRevelationOf { get; set; }

        public Guid? AdvancedRevelationOfId { get; set; }
        public Mystery? AdvancedRevelationOf { get; set; }

        public Guid? GreaterRevelationOfId { get; set; }
        public Mystery? GreaterRevelationOf { get; set; }

        public Guid? GrantedById { get; set; }
        public Mystery? GrantedBy { get; set; }

        public Guid? DomainId { get; set; }
        public Domain? Domain { get; set; }

        public Guid? StaggeredEffectId { get; set; }
        public StaggeredEffect? StaggeredEffect { get; set; } = default!;

        public ICollection<RollableEffect> RollableEffects { get; set; } = new List<RollableEffect>();
        
        public ICollection<TextBlock> Details { get; set; } = new List<TextBlock>();

        public ICollection<SpellComponent> Components { get; set; } = new List<SpellComponent>();

        public ICollection<Trait> Traits { get; set; } = new List<Trait>();

        public ICollection<SpellHeightening> Heightenings { get; set; } = new List<SpellHeightening>();

        public ICollection<ActionEffect> ActionEffects { get; set; } = new List<ActionEffect>();
     
        public ICollection<Creature> CreatureEffects { get; set; } = new List<Creature>();

        public ICollection<MagicTradition> Traditions { get; set; } = new List<MagicTradition>();

        public ICollection<PatronTheme> Patrons { get; set; } = new List<PatronTheme>();

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class SpellHeightening : BaseEntity
    {
        public string Level { get; set; } = default!;

        public ICollection<TextBlock> Details { get; set; } = new List<TextBlock>();

        public Guid SpellId { get; set; }
        public Spell Spell { get; set; } = default!;
    }

}
