using System;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class ImproveSpecificSkillSpecificSkillActionCheckEffect : BaseEffect
    {
        public string? Addendum { get; set; }

        public Guid SkillId { get; set; }
        public Skill Skill { get; set; } = default!;

        public Guid SkillActionId { get; set; }
        public SkillAction SkillAction { get; set; } = default!;

        public RollResult InitialResult { get; set; }
        public RollResult Becomes { get; set; }
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder ImproveSpecificSkillSpecificSkillActionCheck(this BooleanEffectBuilder builder, Guid id, Guid skillId, Guid skillActionId, RollResult initialResult, RollResult becomes, string? addendum = null)
        {
            return builder.Add(new ImproveSpecificSkillSpecificSkillActionCheckEffect { Id = id, SkillId = skillId, SkillActionId = skillActionId, InitialResult = initialResult, Becomes = becomes, Addendum = addendum});
        }
    }

}
