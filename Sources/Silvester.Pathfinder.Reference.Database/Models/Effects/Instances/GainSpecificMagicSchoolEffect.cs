using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainSpecificMagicSchoolEffect : BaseEffect
    {
        public Guid MagicSchoolId { get; set; }
        public MagicSchool MagicSchool { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainSpecificMagicSchool(this BooleanEffectBuilder builder, Guid id, Guid magicSchoolId)
        {
            return builder.Add(new GainSpecificMagicSchoolEffect { Id = id, MagicSchoolId = magicSchoolId});
        }
    }
}
