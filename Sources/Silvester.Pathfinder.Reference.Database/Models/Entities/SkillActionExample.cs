using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class SkillActionExample : BaseEntity
    {
        public string Description { get; set; } = default!;

        public Guid ProficiencyId { get; set; }
        public Proficiency Proficiency { get; set; } = default!;

        public Guid SkillActionId { get; set; }
        public SkillAction SkillAction { get; set; } = default!;
    }
}
