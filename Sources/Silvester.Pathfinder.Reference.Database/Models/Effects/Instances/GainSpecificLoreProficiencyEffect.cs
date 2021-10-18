using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Instances
{
    public class GainSpecificLoreProficiencyEffect : Effect
    {
        public Guid ProficiencyId { get; set; }
        public Proficiency Proficiency { get; set; } = default!;

        public Guid LoreId { get; set; }
        public Lore Lore { get; set; } = default!;
    }
}
