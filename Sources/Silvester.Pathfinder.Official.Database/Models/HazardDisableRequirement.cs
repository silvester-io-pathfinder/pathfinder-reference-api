using System;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class HazardDisableRequirement : BaseEntity
    {
        public int DifficultyCheck { get; set; }

        public string Description { get; set; } = default!;

        public Guid SkillId { get; set; }
        public Skill Skill { get; set; } = default!;

        public Guid RequiredProficiencyId { get; set; }
        public Proficiency RequiredProficiency { get; set; } = default!;

        public Guid HazardId { get; set; }
        public Hazard Hazard { get; set; } = default!;
    }
}
