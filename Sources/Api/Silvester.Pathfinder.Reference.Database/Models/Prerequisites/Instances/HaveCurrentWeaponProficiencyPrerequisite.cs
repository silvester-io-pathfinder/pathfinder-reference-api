using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveCurrentWeaponProficiencyPrerequisite : BasePrerequisite
    {
        public Guid RequiredProficiencyId { get; set; }
        public Proficiency RequiredProficiency { get; set; } = default!;

        public Comparator Comparator { get; set; }
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder HaveCurrentWeaponProficiency (this BooleanPrerequisiteBuilder builder, Guid id, Comparator comparator, Guid requiredProficiencyId)
        {
            return builder.Add(new HaveCurrentWeaponProficiencyPrerequisite { Id = id, Comparator = comparator, RequiredProficiencyId = requiredProficiencyId });
        }
    }
}
