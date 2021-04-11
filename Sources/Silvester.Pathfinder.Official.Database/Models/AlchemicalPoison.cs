using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class AlchemicalPoison : BaseEntity
    {
        public string Name { get; set; } = default!;

        public string Usage { get; set; } = default!;
        
        public int ItemLevel { get; set; }

        public int Price { get; set; }

        public string Onset { get; set; } = default!;

        public int DifficultyCheck { get; set; }

        public string MaximumDuration { get; set; } = default!;

        public Guid ActionTypeId { get; set; }
        public ActionType ActionType { get; set; } = default!;

        public Guid SavingThrowStatId { get; set; }
        public SavingThrowStat SavingThrowStat { get; set; } = default!;

        public Guid BulkId { get; set; }
        public Bulk Bulk { get; set; } = default!;

        public Guid ActionId { get; set; }
        public Action Action { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public ICollection<Trait> Traits { get; set; } = new List<Trait>();

        public ICollection<AlchemicalPoisonDetailBlock> Details { get; set; } = new List<AlchemicalPoisonDetailBlock>();
    }

    public class AlchemicalPoisonDetailBlock : BaseEntity
    {
        public string Text { get; set; } = default!;

        public Guid AlchemicalPoisonId { get; set; }
        public AlchemicalPoison AlchemicalPoison { get; set; } = default!;
    }

    public class AlchemicalPoisonStage : BaseEntity
    {
        public int Stage { get; set; }

        public string Duration { get; set; } = default!;

        public ICollection<AlchemicalPoisonStageEffect> Effects { get; set; } = new List<AlchemicalPoisonStageEffect>();

        public Guid AlchemicalPoisonId { get; set; }
        public AlchemicalPoison AlchemicalPoison { get; set; } = default!;
    }

    public class AlchemicalPoisonStageEffect : BaseEntity
    {
        public bool Permanent { get; set; }

        public Guid AlchemicalPoisonStageId { get; set; }
        public AlchemicalPoisonStage AlchemicalPoisonStage { get; set; } = default!;
    }

    public class ConditionAlchemicalPoisonStageEffect : AlchemicalPoisonStageEffect
    {
        public Guid ConditionId { get; set; }
        public Condition Condition { get; set; } = default!;

        public int? Severity { get; set; }
    }

    public class DamageAlchemicalPoisonStageEffect : AlchemicalPoisonStageEffect
    {
        public string Damage { get; set; } = default!;

        public string? Every { get; set; } = default!;

        public bool IsDamagePersistent { get; set; } = false;

        public Guid DamageTypeId { get; set; }
        public DamageType DamageType { get; set; } = default!;
    }

    public class OtherAlchemicalPoisonStageEffect : AlchemicalPoisonStageEffect
    {
        public string Effect { get; set; } = default!;
    }

}
