using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using System;


namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveAnySensePrerequisite : BasePrerequisite
    {
        public Guid RequiredSenseAccuracyId { get; set; }
        public SenseAccuracy RequiredSenseAccuracy { get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder HaveAnySense(this BooleanPrerequisiteBuilder builder, Guid id, Guid requiredSenseAccuracyId)
        {
            return builder.Add(new HaveAnySensePrerequisite { Id = id, RequiredSenseAccuracyId = requiredSenseAccuracyId });
        }
    }
}
