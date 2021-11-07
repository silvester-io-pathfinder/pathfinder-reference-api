using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class ModifyAncestrySizeEffect : BaseEffect
    {
        public Guid SizeId { get; set; }
        public AncestrySize Size { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder ModifyAncestrySize(this BooleanEffectBuilder builder, Guid id, Guid sizeId)
        {
            return builder.Add(new ModifyAncestrySizeEffect { Id = id, SizeId = sizeId });
        }
    }
}
