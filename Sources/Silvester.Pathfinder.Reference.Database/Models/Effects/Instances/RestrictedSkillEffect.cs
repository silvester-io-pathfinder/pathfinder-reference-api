using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Instances
{
    public class RestrictedSkillEffect : Effect
    {
        public Guid ProficiencyId { get; set; }
        public Proficiency Proficiency { get; set; } = default!;

        public Guid SkillId { get; set; }
        public Skill Skill { get; set; } = default!;
    }
}
