using System;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class StaggeredEffectStageEffect : BaseEntity
    {
        public bool Permanent { get; set; }

        public Guid StaggeredEffectStageId { get; set; }
        public StaggeredEffectStage StaggeredEffectStage { get; set; } = default!;
    }

    public class ConditionPoisonStageEffect : StaggeredEffectStageEffect
    {
        public Guid ConditionId { get; set; }
        public Condition Condition { get; set; } = default!;

        public int? Severity { get; set; }
    }

    public class DamagePoisonStageEffect : StaggeredEffectStageEffect
    {
        public string Damage { get; set; } = default!;

        public string? Every { get; set; } = default!;

        public bool IsDamagePersistent { get; set; } = false;

        public Guid DamageTypeId { get; set; }
        public DamageType DamageType { get; set; } = default!;
    }

    public class OtherPoisonStageEffect : StaggeredEffectStageEffect
    {
        public string Effect { get; set; } = default!;
    }
}
