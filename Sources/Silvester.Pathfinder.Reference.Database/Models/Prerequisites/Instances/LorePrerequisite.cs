using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class LorePrerequisite : Prerequisite
    {
        public Guid RequiredProficiencyId { get; set; }
        public Proficiency RequiredProficiency { get; set; } = default!;

        public Guid? RequiredLoreId { get; set; }
        public Lore? RequiredLore { get; set; }
    }
}
