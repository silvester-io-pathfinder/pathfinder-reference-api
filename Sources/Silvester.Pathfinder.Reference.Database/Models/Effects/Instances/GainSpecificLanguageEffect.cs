using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainSpecificLanguageEffect : BaseEffect
    {
        public Guid LanguageId { get; set; }
        public Language Language { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainSpecificLanguage(this BooleanEffectBuilder builder, Guid id, Guid languageId)
        {
            return builder.Add(new GainSpecificLanguageEffect { Id = id, LanguageId = languageId });
        }
    }
}
