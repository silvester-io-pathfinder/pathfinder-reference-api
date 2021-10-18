using Silvester.Pathfinder.Reference.Database.Models.Effects;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveSpecificArmorCategoryProficiencyPrerequisite : Prerequisite
    {
        public Guid ArmorCategoryId { get; set; }
        public ArmorCategory ArmorCategory { get; set; } = default!;

        public Guid RequiredProficiencyId { get; set; }
        public Proficiency RequiredProficiency { get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static EffectBuilder.Prerequisites HaveSpecificArmorCategoryProficiency(this EffectBuilder.Prerequisites builder, Guid id, Guid bindingId, Guid armorCategoryId, Guid requiredProficiencyId)
        {
            return builder.Add(bindingId, new HaveSpecificArmorCategoryProficiencyPrerequisite { Id = id, ArmorCategoryId = armorCategoryId, RequiredProficiencyId = requiredProficiencyId});
        }
    }
}
