using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;


namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{


    public class HaveSpecificArmorCategorySpecificProficiencyPrerequisite : BasePrerequisite
    {
        public Guid ArmorCategoryId { get; set; }
        public ArmorCategory ArmorCategory { get; set; } = default!;

        public Guid RequiredProficiencyId { get; set; }
        public Proficiency RequiredProficiency { get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder HaveSpecificArmorCategorySpecificProficiency(this BooleanPrerequisiteBuilder builder, Guid id, Guid requiredProficiencyId, Guid armorCategoryId)
        {
            return builder.Add(new HaveSpecificArmorCategorySpecificProficiencyPrerequisite { Id = id, RequiredProficiencyId = requiredProficiencyId, ArmorCategoryId = armorCategoryId});
        }
    }
}
