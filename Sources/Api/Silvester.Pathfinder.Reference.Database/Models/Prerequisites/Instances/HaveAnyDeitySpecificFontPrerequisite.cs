using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveAnyDeitySpecificFontPrerequisite : BasePrerequisite
    {
        public Guid RequiredDivineFontId { get; set; }
        public DivineFont RequiredDivineFont { get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder HaveAnyDeitySpecificFont(this BooleanPrerequisiteBuilder builder, Guid id, Guid requiredDivineFontId)
        {
            return builder.Add(new HaveAnyDeitySpecificFontPrerequisite { Id = id, RequiredDivineFontId = requiredDivineFontId });
        }
    }
}
