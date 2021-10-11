using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.LoreCategories.Instances
{
    public class Deities : Template
    {
        public static readonly Guid ID = Guid.Parse("728eb80b-f98e-4eb5-baa5-112f4e589f83");

        protected override LoreCategory GetLoreCategory()
        {
            return new LoreCategory
            {
                Id = ID,
                StatModifierId = Stats.Instances.Intelligence.ID,
                Name = "Deities",
                Description = "Lore about a specific deity.",
                Examples = "Abadar Lore, Iomedae Lore"
            };
        }
    }
}
