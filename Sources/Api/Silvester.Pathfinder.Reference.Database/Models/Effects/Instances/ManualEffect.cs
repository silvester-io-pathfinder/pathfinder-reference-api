using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class ManualEffect : BaseEffect
    {
        public string Text { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder Manual(this BooleanEffectBuilder builder, Guid id, string text)
        {
            return builder.Add(new ManualEffect { Id = id, Text = text});
        }
    }
}
