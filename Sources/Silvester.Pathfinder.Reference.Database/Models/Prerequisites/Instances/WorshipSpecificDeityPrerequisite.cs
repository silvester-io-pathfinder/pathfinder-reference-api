using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;


namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class WorshipSpecificDeityPrerequisite : BasePrerequisite
    {
        public Guid RequiredDeityId { get; set; }
        public Deity RequiredDeity { get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder WorshipSpecificDeity(this BooleanPrerequisiteBuilder builder, Guid id, Guid requiredDeityId)
        {
            return builder.Add(new WorshipSpecificDeityPrerequisite { Id = id, RequiredDeityId = requiredDeityId});
        }
    }
}