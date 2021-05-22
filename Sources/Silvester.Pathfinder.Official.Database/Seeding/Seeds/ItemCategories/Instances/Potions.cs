using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.ItemCategories.Instances
{
    public class Potions : Template
    {
        public static readonly Guid ID = Guid.Parse("f18f1a5c-790a-42ce-b629-1db465289c25");

        protected override ItemCategory GetItemCategory()
        {
            return new ItemCategory 
            {
                Id = ID, 
                PageNumber = 562, 
                Name = "Potions", 
                Description = "Consumable magical liquids you drink to activate." 
            };
        }
    }
}
