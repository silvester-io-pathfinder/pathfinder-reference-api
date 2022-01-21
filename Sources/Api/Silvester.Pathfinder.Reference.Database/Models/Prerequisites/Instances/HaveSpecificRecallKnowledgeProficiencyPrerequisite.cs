using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;


namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveSpecificRecallKnowledgeProficiencyPrerequisite : BasePrerequisite
    {
        public Guid RequiredProficiencyId { get; set; }
        public Proficiency RequiredProficiency { get; set; } = default!;

        public bool RequiresAssurance { get; set; }
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder HaveSpecificRecallKnowledgeProficiency(this BooleanPrerequisiteBuilder builder, Guid id, Guid requiredProficiencyId, bool requiresAssurance)
        {
            return builder.Add(new HaveSpecificRecallKnowledgeProficiencyPrerequisite { Id = id, RequiredProficiencyId = requiredProficiencyId, RequiresAssurance = requiresAssurance });
        }
    }
}
