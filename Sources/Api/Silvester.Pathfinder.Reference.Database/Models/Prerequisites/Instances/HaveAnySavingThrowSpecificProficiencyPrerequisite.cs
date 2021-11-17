using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using System;


namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveAnySavingThrowSpecificProficiencyPrerequisite : BasePrerequisite
    {
        public Guid RequiredProficiencyId { get; set; }
        public Proficiency RequiredProficiency { get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder HaveAnySavingThrowSpecificProficiency(this BooleanPrerequisiteBuilder builder, Guid id, Guid requiredProficiencyId)
        {
            return builder.Add(new HaveAnySavingThrowSpecificProficiencyPrerequisite { Id = id, RequiredProficiencyId = requiredProficiencyId });
        }
    }
}
