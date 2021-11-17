using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainAnyPrototypeConstructCompanionEffect : BaseEffect
    {

    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainAnyPrototypeConstructCompanion(this BooleanEffectBuilder builder, Guid id)
        {
            return builder.Add(new GainAnyPrototypeConstructCompanionEffect { Id = id });
        }
    }
}
