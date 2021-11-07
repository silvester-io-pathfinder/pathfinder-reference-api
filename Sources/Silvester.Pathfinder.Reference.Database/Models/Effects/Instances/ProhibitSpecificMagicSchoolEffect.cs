using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class ProhibitSpecificMagicSchoolEffect : BaseEffect
    {
        public Guid ProhibitedMagicSchoolId { get; set; }
        public MagicSchool ProhibitedMagicSchool { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder ProhibitSpecificMagicSchool(this BooleanEffectBuilder builder, Guid id, Guid prohibitedMagicSchoolId)
        {
            return builder.Add(new ProhibitSpecificMagicSchoolEffect { Id = id, ProhibitedMagicSchoolId = prohibitedMagicSchoolId });
        }
    }
}
