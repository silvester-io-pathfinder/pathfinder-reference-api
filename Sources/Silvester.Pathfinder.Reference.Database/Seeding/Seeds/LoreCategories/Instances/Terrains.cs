using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.LoreCategories.Instances
{
    public class Terrains : Template
    {
        public static readonly Guid ID = Guid.Parse("b774c345-9381-4036-ba85-d8955408c206");

        protected override LoreCategory GetLoreCategory()
        {
            return new LoreCategory
            {
                Id = ID,
                StatModifierId = Stats.Instances.Intelligence.ID,
                Name = "Terrains",
                Description = "Lore about a specific terrain.",
                Examples = "Mountain Lore, River Lore"
            };
        }
    }
}
