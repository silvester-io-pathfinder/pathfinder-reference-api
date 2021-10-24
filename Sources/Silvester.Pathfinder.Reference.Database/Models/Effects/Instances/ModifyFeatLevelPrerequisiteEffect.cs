using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class ModifyFeatLevelPrerequisiteEffect : BaseEffect
    {
        public Guid FeatId { get; set; }
        public Feat Feat { get; set; } = default!;

        public ModifierType ModifierType { get; set; }
        public int Modifier { get; set; }
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder ModifyFeatLevelPrerequisite(this BooleanEffectBuilder builder, Guid id, Guid featId, ModifierType modifierType, int modifier)
        {
            return builder.Add(new ModifyFeatLevelPrerequisiteEffect { Id = id, FeatId = featId, ModifierType = modifierType, Modifier = modifier });
        }
    }
}

