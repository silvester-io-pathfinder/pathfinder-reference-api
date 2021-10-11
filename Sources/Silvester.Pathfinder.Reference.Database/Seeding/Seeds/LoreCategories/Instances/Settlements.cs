using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.LoreCategories.Instances
{
    public class Settlements : Template
    {
        public static readonly Guid ID = Guid.Parse("1edd0e36-7a85-4eb4-afa3-0c9350241f70");

        protected override LoreCategory GetLoreCategory()
        {
            return new LoreCategory
            {
                Id = ID,
                StatModifierId = Stats.Instances.Intelligence.ID,
                Name = "Settlements",
                Description = "Lore about a specific settlement.",
                Examples = "Absalom Lore, Magnimar Lore"
            };
        }
    }
}
