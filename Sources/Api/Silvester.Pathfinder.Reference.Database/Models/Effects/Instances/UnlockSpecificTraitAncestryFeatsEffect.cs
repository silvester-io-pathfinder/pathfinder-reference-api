using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    ///<summary>Unlocks the Versatile Heritage's Trait's feats as Ancestry Feat options.</summary>
    public class UnlockSpecificTraitAncestryFeatsEffect : BaseEffect
    {
        public Guid AncestryTraitId { get; set; }
        public Trait AncestryTrait { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder UnlockSpecificTraitAncestryFeats(this BooleanEffectBuilder builder, Guid id, Guid ancestryTraitId)
        {
            return builder.Add(new UnlockSpecificTraitAncestryFeatsEffect { Id = id, AncestryTraitId = ancestryTraitId });
        }
    }
}
