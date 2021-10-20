using Silvester.Pathfinder.Reference.Database.Models.Effects;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveSpecificInnovationPrerequisite : Prerequisite
    {
        public Guid InnovationId { get; set; }
        public Innovation Innovation { get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static EffectBuilder.Prerequisites HaveSpecificInnovation(this EffectBuilder.Prerequisites builder, Guid id, Guid bindingId, Guid innovationId)
        {
            return builder.Add(bindingId, new HaveSpecificInnovationPrerequisite { Id = id, InnovationId = innovationId });
        }
    }
}
