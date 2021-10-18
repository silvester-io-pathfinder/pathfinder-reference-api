using Silvester.Pathfinder.Reference.Database.Models.Effects;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveSpecificLoreProficiencyPrerequisite : Prerequisite
    {
        public Guid RequiredProficiencyId { get; set; }
        public Proficiency RequiredProficiency { get; set; } = default!;

        public Guid RequiredLoreId { get; set; }
        public Lore RequiredLore { get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static EffectBuilder.Prerequisites HaveSpecificLoreProficiency(this EffectBuilder.Prerequisites builder, Guid id, Guid bindingId, Guid requiredProficiencyId, Guid requiredLoreId)
        {
            return builder.Add(bindingId, new HaveSpecificLoreProficiencyPrerequisite { Id = id, RequiredProficiencyId = requiredProficiencyId, RequiredLoreId = requiredLoreId });
        }
    }
}
