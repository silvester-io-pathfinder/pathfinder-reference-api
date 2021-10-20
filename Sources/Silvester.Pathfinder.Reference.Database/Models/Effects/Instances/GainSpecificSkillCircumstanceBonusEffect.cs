using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Instances
{
    //TODO: Determine if this needs a CheckType parameter of sorts.
    public class GainSpecificSkillCircumstanceBonusEffect : Effect
    {
        public int Bonus { get; set; }

        public Guid SkillId { get; set; }
        public Skill Skill { get; set; } = default!;
    }
}
