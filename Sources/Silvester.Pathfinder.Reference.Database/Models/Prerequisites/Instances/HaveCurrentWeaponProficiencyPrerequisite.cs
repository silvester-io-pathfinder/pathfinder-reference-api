using Silvester.Pathfinder.Reference.Database.Models.Effects;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveCurrentWeaponProficiencyPrerequisite : Prerequisite
    {
        public Guid RequiredProficiencyId { get; set; }
        public Proficiency RequiredProficiency { get; set; } = default!;

        public Comparator Comparator { get; set; }
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static EffectBuilder.Prerequisites HaveCurrentWeaponProficiency (this EffectBuilder.Prerequisites builder, Guid id, Guid bindingId, Comparator comparator, Guid requiredProficiencyId)
        {
            return builder.Add(bindingId, new HaveCurrentWeaponProficiencyPrerequisite { Id = id, Comparator = comparator, RequiredProficiencyId = requiredProficiencyId });
        }
    }
}
