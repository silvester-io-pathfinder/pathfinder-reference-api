using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainSpecificMagicSchoolSpellEffect : BaseEffect
    {
        public int Level { get; set; }

        public Guid MagicSchoolId { get; set; }
        public MagicSchool MagicSchool { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainSpecificMagicSchoolSpell(this BooleanEffectBuilder builder, Guid id, Guid magicSchoolId, int level)
        {
            return builder.Add(new GainSpecificMagicSchoolSpellEffect { Id = id, MagicSchoolId = magicSchoolId, Level = level });
        }
    }
}
