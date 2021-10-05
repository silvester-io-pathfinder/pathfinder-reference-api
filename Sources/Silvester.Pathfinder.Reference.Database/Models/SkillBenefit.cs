using System;

namespace Silvester.Pathfinder.Reference.Database.Models
{
    public class SkillBenefit : BaseEntity
    {
        public Guid SkillId { get; set; }
        public Skill Skill { get; set; } = default!;

        public Guid BenefitTypeId { get; set; }
        public BenefitType BenefitType { get; set; } = default!;
    }
}
