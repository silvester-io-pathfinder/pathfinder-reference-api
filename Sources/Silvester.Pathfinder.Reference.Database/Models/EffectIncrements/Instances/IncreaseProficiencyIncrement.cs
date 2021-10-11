using System;

namespace Silvester.Pathfinder.Reference.Database.Models.EffectIncrements.Instances
{
    public class IncreaseProficiencyIncrement : EffectIncrement
    {
        public Guid ProficiencyId { get; set; }
        public Proficiency Proficiency { get; set; } = default!;
    }
}
