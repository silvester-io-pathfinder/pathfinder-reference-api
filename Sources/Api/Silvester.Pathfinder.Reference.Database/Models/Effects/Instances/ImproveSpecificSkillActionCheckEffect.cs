using System;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class ImproveSpecificSkillActionCheckEffect : BaseEffect
    {
        public Guid SkillActionId { get; set; }
        public SkillAction SkillAction { get; set; } = default!;

        public RollResult InitialResult { get; set; }
        public RollResult Becomes { get; set; }
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder ImproveSpecificSkillActionCheck(this BooleanEffectBuilder builder, Guid id, Guid skillActionId, RollResult initialResult, RollResult becomes)
        {
            return builder.Add(new ImproveSpecificSkillActionCheckEffect { Id = id, SkillActionId = skillActionId, InitialResult = initialResult, Becomes = becomes });
        }
    }

}