using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class ModifyAncestryHitpointsEffect : BaseEffect
    {
        public ModifierType ModifierType { get; set; }
        public int Modifier { get; set; }
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder ModifyAncestryHitpoints(this BooleanEffectBuilder builder, Guid id, ModifierType modifierType, int modifier)
        {
            return builder.Add(new ModifyAncestryHitpointsEffect { Id = id, ModifierType = modifierType, Modifier = modifier });
        }
    }
}
