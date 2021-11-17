using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveSpecificInstinctPrerequisite : BasePrerequisite
    {
        public Guid RequiredInstinctId { get; set; }
        public Instinct RequiredInstinct { get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder HaveSpecificInstinct(this BooleanPrerequisiteBuilder builder, Guid id, Guid requiredInstinctId)
        {
            return builder.Add(new HaveSpecificInstinctPrerequisite { Id = id, RequiredInstinctId = requiredInstinctId});
        }
    }
}
