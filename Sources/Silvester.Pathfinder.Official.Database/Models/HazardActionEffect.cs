using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class HazardActionEffect : BaseEntity
    {
        public string Name { get; set; } = default!;

        public Guid HazardActionId { get; set; }
        public HazardAction HazardAction { get; set; } = default!;
    }

    public class AttackHazardActionEffect : HazardActionEffect
    {
        public string Damage { get; set; } = default!;

        public string Weapon { get; set; } = default!;

        public int ProficiencyBonus { get; set; }

        public Guid DamageTypeId { get; set; }
        public DamageType DamageType { get; set; } = default!;

        public Guid AttackTypeId { get; set; }
        public AttackType AttackType { get; set; } = default!;

        public Guid ActionTypeId { get; set; }
        public ActionType ActionType { get; set; } = default!;
    }

    public class PoisonHazardActionEffect : HazardActionEffect
    {
        public Guid PoisonEffectId { get; set; }
        public PoisonEffect PoisonEffect { get; set; } = default!;
    }

    public class RollableHazzardActionEffect : HazardActionEffect, IRollableEffect
    {
        public string? CriticalSuccess { get; set; }
        public string? Success { get; set; }
        public string? Failure { get; set; }
        public string? CriticalFailure { get; set; }
    }
}
