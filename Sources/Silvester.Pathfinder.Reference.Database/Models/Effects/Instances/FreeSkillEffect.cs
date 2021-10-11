using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Instances
{
    public class FreeSkillEffect : Effect
    {
        public string? Restrictions { get; set; }

        public Guid ProficiencyId { get; set; }
        public Proficiency Proficiency { get; set; } = default!;
    }
}
