using System;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class ImproveSpecificTraitAnySavingThrowEffect : BaseEffect
    {
        public string? Addendum { get; set; }

        public Guid TraitId{ get; set; }
        public Trait Trait { get; set; } = default!;

        public RollResult InitialResult { get; set; }
        public RollResult Becomes { get; set; }
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder ImproveSpecificTraitAnySavingThrow(this BooleanEffectBuilder builder, Guid id, Guid traitId, RollResult initialResult, RollResult becomes, string? addendum = null)
        {
            return builder.Add(new ImproveSpecificTraitAnySavingThrowEffect { Id = id, TraitId = traitId, InitialResult = initialResult, Becomes = becomes, Addendum = addendum });
        }
    }

}
