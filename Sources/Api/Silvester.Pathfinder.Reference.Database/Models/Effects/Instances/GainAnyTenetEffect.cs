using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainAnyTenetEffect : BaseEffect
    {

    }   
    
    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainAnyTenet(this BooleanEffectBuilder builder, Guid id)
        {
            return builder.Add(new GainAnyTenetEffect { Id = id });
        }
    }
}
