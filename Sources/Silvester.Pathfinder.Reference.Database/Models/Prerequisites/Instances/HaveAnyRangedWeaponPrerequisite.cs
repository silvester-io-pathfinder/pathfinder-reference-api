using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveAnyRangedWeaponPrerequisite : BasePrerequisite
    {

    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder HaveAnyRangedWeapon(this BooleanPrerequisiteBuilder builder, Guid id)
        {
            return builder.Add(new HaveAnyRangedWeaponPrerequisite { Id = id });
        }
    }
}
