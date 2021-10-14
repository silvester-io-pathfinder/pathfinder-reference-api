using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Instances
{
    public class SkillProficiencyEffect : Effect
    {
        public Guid SkillId { get; set; }
        public Skill Skill { get; set; } = default!;

        public Guid ProficiencyId { get; set; }
        public Proficiency Proficiency { get; set; } = default!;
    }
}
