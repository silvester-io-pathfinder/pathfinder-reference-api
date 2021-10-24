using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveSpecificLoreProficiencyPrerequisite : BasePrerequisite
    {
        public Guid RequiredProficiencyId { get; set; }
        public Proficiency RequiredProficiency { get; set; } = default!;

        public Guid RequiredLoreId { get; set; }
        public Lore RequiredLore { get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder HaveSpecificLoreProficiency(this BooleanPrerequisiteBuilder builder, Guid id, Guid requiredProficiencyId, Guid requiredLoreId)
        {
            return builder.Add(new HaveSpecificLoreProficiencyPrerequisite { Id = id, RequiredProficiencyId = requiredProficiencyId, RequiredLoreId = requiredLoreId });
        }
    }
}
