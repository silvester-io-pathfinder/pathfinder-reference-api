using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveAnyDeitySpecificDomainPrerequisite : BasePrerequisite
    {
        public Guid RequiredDomainId { get; set; }
        public Domain RequiredDomain { get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder HaveAnyDeitySpecificDomain(this BooleanPrerequisiteBuilder builder, Guid id, Guid requiredDomainId)
        {
            return builder.Add(new HaveAnyDeitySpecificDomainPrerequisite { Id = id, RequiredDomainId = requiredDomainId });
        }
    }
}
