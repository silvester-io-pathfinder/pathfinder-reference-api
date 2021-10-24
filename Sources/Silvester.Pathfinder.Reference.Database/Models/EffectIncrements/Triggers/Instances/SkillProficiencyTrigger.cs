using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.EffectIncrements.Triggers.Instances
{
    public class SkillProficiencyTrigger : EffectIncrementTrigger
    {
        public Guid ProficiencyId { get; set; }
        public Proficiency Proficieny { get; set; } = default!;

        public Guid SkillId { get; set; }
        public Skill Skill { get; set; } = default!;
    }
}
