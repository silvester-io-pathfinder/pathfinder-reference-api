using Silvester.Pathfinder.Reference.Database.Models.Effects;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveSpecificInstinctPrerequisite : Prerequisite
    {
        public Guid RequiredInstinctId { get; set; }
        public Instinct RequiredInstinct { get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static EffectBuilder.Prerequisites HaveSpecificInstinct(this EffectBuilder.Prerequisites builder, Guid id, Guid bindingId, Guid requiredInstinctId)
        {
            return builder.Add(bindingId, new HaveSpecificInstinctPrerequisite { Id = id, RequiredInstinctId = requiredInstinctId});
        }
    }
}
