using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveSpecificDivineFontPrerequisite : BasePrerequisite
    {
        public Guid RequiredDivineFontId { get; set; }
        public DivineFont RequiredDivineFont { get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder HaveSpecificDivineFont(this BooleanPrerequisiteBuilder builder, Guid id, Guid requiredDivineFontId)
        {
            return builder.Add(new HaveSpecificDivineFontPrerequisite { Id = id, RequiredDivineFontId = requiredDivineFontId });
        }
    }
}
