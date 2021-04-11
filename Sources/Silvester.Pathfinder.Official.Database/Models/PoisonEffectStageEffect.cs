using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class PoisonEffectStageEffect : BaseEntity
    {
        public bool Permanent { get; set; }

        public Guid PoisonEffectStageId { get; set; }
        public PoisonEffectStage PoisonEffectStage { get; set; } = default!;
    }

    public class ConditionPoisonStageEffect : PoisonEffectStageEffect
    {
        public Guid ConditionId { get; set; }
        public Condition Condition { get; set; } = default!;

        public int? Severity { get; set; }
    }

    public class DamagePoisonStageEffect : PoisonEffectStageEffect
    {
        public string Damage { get; set; } = default!;

        public string? Every { get; set; } = default!;

        public bool IsDamagePersistent { get; set; } = false;

        public Guid DamageTypeId { get; set; }
        public DamageType DamageType { get; set; } = default!;
    }

    public class OtherPoisonStageEffect : PoisonEffectStageEffect
    {
        public string Effect { get; set; } = default!;
    }
}
