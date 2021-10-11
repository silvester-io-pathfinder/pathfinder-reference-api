using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.LoreCategories.Instances
{
    public class Planes : Template
    {
        public static readonly Guid ID = Guid.Parse("3cba9afe-48b8-4123-a1ce-b6ec8685e2b3");

        protected override LoreCategory GetLoreCategory()
        {
            return new LoreCategory
            {
                Id = ID,
                StatModifierId = Stats.Instances.Intelligence.ID,
                Name = "Planes",
                Description = "Lore of a specific plane other than the Material Plane, or the plane in which the game is set if not the Material Plane.",
                Examples = "Abyss Lore, Astral Plane Lore, Heaven Lore"
            };
        }
    }
}
