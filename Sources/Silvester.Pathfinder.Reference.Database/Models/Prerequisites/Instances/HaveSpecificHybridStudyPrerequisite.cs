using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using System;


namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveSpecificHybridStudyPrerequisite : BasePrerequisite
    {
        public Guid RequiredHybridStudyId { get; set; } 
        public HybridStudy RequiredHybridStudy { get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder HaveSpecificHybridStudy(this BooleanPrerequisiteBuilder builder, Guid id, Guid requiredHybridStudyId)
        {
            return builder.Add(new HaveSpecificHybridStudyPrerequisite { Id = id, RequiredHybridStudyId = requiredHybridStudyId });
        }
    }
}
