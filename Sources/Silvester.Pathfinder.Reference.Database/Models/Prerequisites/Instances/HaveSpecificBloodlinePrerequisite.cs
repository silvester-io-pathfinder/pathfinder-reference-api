using Silvester.Pathfinder.Reference.Database.Models.Effects;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveSpecificBloodlinePrerequisite : Prerequisite
    {
        public Guid RequiredBloodlineId { get; set; }
        public Bloodline RequiredBloodline { get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static EffectBuilder.Prerequisites HaveSpecificBloodline(this EffectBuilder.Prerequisites builder, Guid id, Guid bindingId, Guid requiredBloodlineId)
        {
            return builder.Add.Prerequisites(bindingId, new HaveSpecificBloodlinePrerequisite { Id = id, RequiredBloodlineId = requiredBloodlineId });
        }
    }
}
