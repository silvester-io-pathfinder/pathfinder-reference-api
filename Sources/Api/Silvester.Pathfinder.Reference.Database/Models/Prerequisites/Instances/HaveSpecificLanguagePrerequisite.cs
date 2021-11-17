using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveSpecificLanguagePrerequisite : BasePrerequisite
    {
        public Guid LanguageId { get; set; }
        public Language Language { get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder HaveSpecificLanguage(this BooleanPrerequisiteBuilder builder, Guid id, Guid languageId)
        {
            return builder.Add(new HaveSpecificLanguagePrerequisite { Id = id, LanguageId = languageId });
        }
    }
}
