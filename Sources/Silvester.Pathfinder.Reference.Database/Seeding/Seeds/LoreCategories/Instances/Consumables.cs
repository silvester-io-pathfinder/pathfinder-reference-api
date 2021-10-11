using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.LoreCategories.Instances
{
    public class Consumables : Template
    {
        public static readonly Guid ID = Guid.Parse("9300549a-7bdd-408e-afcd-8d9ad3bd499d");

        protected override LoreCategory GetLoreCategory()
        {
            return new LoreCategory
            {
                Id = ID,
                StatModifierId = Stats.Instances.Intelligence.ID,
                Name = "Consumables",
                Description = "Lore about a type of food or drink.",
                Examples = "Alcohol Lore, Baking Lore, Butchering Lore, Cooking Lore, Tea Lore"
            };
        }
    }
}
