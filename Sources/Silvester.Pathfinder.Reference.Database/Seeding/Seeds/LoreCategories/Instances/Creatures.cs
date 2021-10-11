using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.LoreCategories.Instances
{
    public class Creatures : Template
    {
        public static readonly Guid ID = Guid.Parse("bbc3c7bd-39be-4ec5-a6d0-c65683f24c58");

        protected override LoreCategory GetLoreCategory()
        {
            return new LoreCategory
            {
                Id = ID,
                StatModifierId = Stats.Instances.Intelligence.ID,
                Name = "Creatures",
                Description = "Lore about a specific creature or narrow category of creatures.",
                Examples = "Demon Lore, Owlbear Lore, Vampire Lore"
            };
        }
    }
}
