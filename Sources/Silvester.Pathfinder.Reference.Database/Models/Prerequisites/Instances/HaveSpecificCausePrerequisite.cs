using Silvester.Pathfinder.Reference.Database.Models.Effects;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveSpecificCausePrerequisite : Prerequisite
    {
        public Guid RequiredCauseId { get; set; }
        public Cause RequiredCause { get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static EffectBuilder.Prerequisites HaveSpecificCause (this EffectBuilder.Prerequisites builder, Guid id, Guid bindingId, Guid requiredCauseId)
        {
            return builder.Add(bindingId, new HaveSpecificCausePrerequisite { Id = id, RequiredCauseId = requiredCauseId });
        }
    }
}
