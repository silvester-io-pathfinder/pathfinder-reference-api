using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Instances
{
    public class GainSpecificStatSkillProficiencyEffect : Effect
    {
        public Guid StatId { get; set; }
        public Stat Stat { get; set; } = default!;

        public Guid ProficiencyId { get; set; }
        public Proficiency Proficiency { get; set; } = default!;
    }
}

