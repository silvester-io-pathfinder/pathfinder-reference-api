using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Instances
{
    public class GainSpecificLanguageEffect : Effect
    {
        public Guid LanguageId { get; set; }
        public Language Language { get; set; } = default!;
    }
}
