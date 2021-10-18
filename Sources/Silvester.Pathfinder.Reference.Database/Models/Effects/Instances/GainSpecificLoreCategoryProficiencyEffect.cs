using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Instances
{
    public class GainSpecificLoreCategoryProficiencyEffect : Effect
    {
        public string? Restrictions { get; set; }

        public Guid ProficiencyId { get; set; }
        public Proficiency Proficiency { get; set; } = default!;

        public Guid LoreCategoryId { get; set; }
        public LoreCategory LoreCategory { get; set; } = default!;
    }
}
