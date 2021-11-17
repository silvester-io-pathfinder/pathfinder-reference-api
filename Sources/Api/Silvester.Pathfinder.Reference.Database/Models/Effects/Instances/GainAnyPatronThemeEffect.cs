using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainAnyPatronThemeEffect : BaseEffect
    {

    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainAnyPatronTheme(this BooleanEffectBuilder builder, Guid id)
        {
            return builder.Add(new GainAnyPatronThemeEffect { Id = id });
        }
    }
}
