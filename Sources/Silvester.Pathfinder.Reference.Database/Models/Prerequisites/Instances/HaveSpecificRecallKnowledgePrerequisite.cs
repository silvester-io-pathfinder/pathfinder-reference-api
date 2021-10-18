using Silvester.Pathfinder.Reference.Database.Models.Effects;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveSpecificRecallKnowledgePrerequisite : Prerequisite
    {
        public Guid RequiredProficiencyId { get; set; }
        public Proficiency RequiredProficiency { get; set; } = default!;

        public bool RequiresAssurance { get; set; }
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static EffectBuilder.Prerequisites HaveSpecificRecallKnowledge(this EffectBuilder.Prerequisites builder, Guid id, Guid bindingId, Guid requiredProficiencyId, bool requiresAssurance)
        {
            return builder.Add(bindingId, new HaveSpecificRecallKnowledgePrerequisite { Id = id, RequiredProficiencyId = requiredProficiencyId, RequiresAssurance = requiresAssurance });
        }
    }
}
