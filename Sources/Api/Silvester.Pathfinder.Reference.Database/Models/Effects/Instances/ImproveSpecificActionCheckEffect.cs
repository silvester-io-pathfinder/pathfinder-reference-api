using System;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class ImproveSpecificActionCheckEffect : BaseEffect
    {
        public Guid ActionId { get; set; }
        public Models.Entities.Action Action { get; set; } = default!;

        public RollResult InitialResult { get; set; }
        public RollResult Becomes { get; set; }
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder ImproveSpecificActionCheck(this BooleanEffectBuilder builder, Guid id, Guid actionId, RollResult initialResult, RollResult becomes)
        {
            return builder.Add(new ImproveSpecificActionCheckEffect { Id = id, ActionId = actionId, InitialResult = initialResult, Becomes = becomes });
        }
    }

}
