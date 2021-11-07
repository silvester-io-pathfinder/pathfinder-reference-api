using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using System;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainAnyDraconicExemplarEffect : BaseEffect
    {

    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainAnyDraconicExemplar(this BooleanEffectBuilder builder, Guid id)
        {
            return builder.Add(new GainAnyDraconicExemplarEffect { Id = id });
        }
    }
}

