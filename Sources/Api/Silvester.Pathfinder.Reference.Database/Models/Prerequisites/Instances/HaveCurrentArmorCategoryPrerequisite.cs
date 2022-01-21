using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveCurrentArmorCategoryPrerequisite : BasePrerequisite
    {
        public Guid ArmorCategoryId { get; set; }
        public ArmorCategory ArmorCategory { get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder HaveCurrentArmorCategory(this BooleanPrerequisiteBuilder builder, Guid id, Guid armorCategoryId )
        {
            return builder.Add(new HaveCurrentArmorCategoryPrerequisite { Id = id, ArmorCategoryId = armorCategoryId });
        }
    }
}
