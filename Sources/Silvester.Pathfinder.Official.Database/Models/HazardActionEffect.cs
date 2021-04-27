using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class HazardActionEffect : BaseEntity
    {
        public string? Name { get; set; } = default!;

        public Guid HazardActionId { get; set; }
        public HazardAction HazardAction { get; set; } = default!;
        
        public ICollection<Trait> Traits { get; set; } = new List<Trait>();
    }

    public class AttackHazardActionEffect : HazardActionEffect
    {
        public AttackHazardActionEffect()
        {
            Name = "Strike";
        }

        public string Damage { get; set; } = default!;

        public string Weapon { get; set; } = default!;

        public string? Addendum { get; set; }

        public int ProficiencyBonus { get; set; }

        public Guid DamageTypeId { get; set; }
        public DamageType DamageType { get; set; } = default!;

        public Guid AttackTypeId { get; set; }
        public AttackType AttackType { get; set; } = default!;

        public Guid ActionTypeId { get; set; }
        public ActionType ActionType { get; set; } = default!;
    }

    public class SpellHazardActionEffect : HazardActionEffect
    {
        public string Damage { get; set; } = default!;

        public int DifficultyCheck { get; set; }

        public Guid SavingThrowStatId { get; set; }
        public SavingThrowStat SavingThrowStat { get; set; } = default!;

        public Guid DamageTypeId { get; set; }
        public DamageType DamageType { get; set; } = default!;
    }

    public class PoisonHazardActionEffect : HazardActionEffect
    {
        public Guid PoisonEffectId { get; set; }
        public StaggeredEffect PoisonEffect { get; set; } = default!;
    }

    public class RollableHazzardActionEffect : HazardActionEffect, IRollableEffect
    {
        public string? CriticalSuccess { get; set; }
        public string? Success { get; set; }
        public string? Failure { get; set; }
        public string? CriticalFailure { get; set; }
    }

    public class OtherHazardActionEffect : HazardActionEffect
    {
        public OtherHazardActionEffect()
        {
            Name = "Other";
        }

        public string Effect { get; set; } = default!;
    }
}
