using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    //TODO: Determine if this needs a CheckType parameter of sorts.
    public class GainSpecificSkillCircumstanceBonusEffect : BaseEffect
    {
        public int Bonus { get; set; }

        public Guid SkillId { get; set; }
        public Skill Skill { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainSpecificSkillCircumstanceBonus(this BooleanEffectBuilder builder, Guid id, Guid skillId, int bonus)
        {
            return builder.Add(new GainSpecificSkillCircumstanceBonusEffect { Id = id, SkillId = skillId, Bonus = bonus });
        }
    }
}
