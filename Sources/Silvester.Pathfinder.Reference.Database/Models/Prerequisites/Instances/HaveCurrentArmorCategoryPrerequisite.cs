using Silvester.Pathfinder.Reference.Database.Models.Effects;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveCurrentArmorCategoryPrerequisite : Prerequisite
    {
        public Guid ArmorCategoryId { get; set; }
        public ArmorCategory ArmorCategory { get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static EffectBuilder.Prerequisites HaveCurrentArmorCategory(this EffectBuilder.Prerequisites builder, Guid id, Guid bindingId, Guid armorCategoryId )
        {
            return builder.Add(bindingId, new HaveCurrentArmorCategoryPrerequisite { Id = id, ArmorCategoryId = armorCategoryId });
        }
    }
}
