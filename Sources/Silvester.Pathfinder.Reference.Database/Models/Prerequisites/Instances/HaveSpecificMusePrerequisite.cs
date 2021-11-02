using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveSpecificMusePrerequisite : BasePrerequisite
    {
        public Guid RequiredMuseId { get; set; }
        public Muse RequiredMuse { get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder HaveSpecificMuse(this BooleanPrerequisiteBuilder builder, Guid id, Guid requiredMuseId)
        {
            return builder.Add(new HaveSpecificMusePrerequisite { Id = id, RequiredMuseId = requiredMuseId });
        }
    }
}
