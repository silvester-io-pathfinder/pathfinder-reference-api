using System;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class DiseaseStageEffect : BaseEntity
    {
        public bool Permanent { get; set; }

        public Guid DiseaseStageId { get; set; }
        public DiseaseStage DiseaseStage { get; set; } = default!;
    }

    public class ConditionDiseaseStageEffect : DiseaseStageEffect
    {
        public Guid ConditionId { get; set; }
        public Condition Condition { get; set; } = default!;

        public int? Severity { get; set; }
    }

    public class DamageDiseaseStageEffect : DiseaseStageEffect
    {
        public string Damage { get; set; } = default!;

        public string? Every{ get; set; } = default!;

        public bool IsDamagePersistent { get; set; } = false;

        public Guid DamageTypeId { get; set; }
        public DamageType DamageType { get; set; } = default!;
    }

    public class OtherDiseaseStageEffect : DiseaseStageEffect
    {
        public string Effect { get; set; } = default!;
    }

    public class RecurrenceDiseaseStageEffect : DiseaseStageEffect
    {
        public string DiseaseComesBackAfter { get; set; } = default!;
    }
}

