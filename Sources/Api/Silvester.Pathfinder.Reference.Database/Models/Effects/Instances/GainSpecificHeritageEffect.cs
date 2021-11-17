using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainSpecificHeritageEffect : BaseEffect
    {
        public Guid HeritageId { get; set; }
        public Heritage Heritage { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainSpecificHeritage(this BooleanEffectBuilder builder, Guid id, Guid heritageId)
        {
            return builder.Add(new GainSpecificHeritageEffect { Id = id, HeritageId = heritageId });
        }
    }
}
