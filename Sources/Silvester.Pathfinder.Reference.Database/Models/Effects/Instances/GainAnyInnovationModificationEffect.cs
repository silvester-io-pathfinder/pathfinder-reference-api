using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainAnyInnovationModificationEffect : BaseEffect
    {
        public Guid InnovationModificationTypeId { get; set; }
        public InnovationModificationType InnovationModificationType { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainAnyInnovationModification(this BooleanEffectBuilder builder, Guid id, Guid innovationModificationTypeId)
        {
            return builder.Add(new GainAnyInnovationModificationEffect { Id = id, InnovationModificationTypeId = innovationModificationTypeId });
        }
    }
}
