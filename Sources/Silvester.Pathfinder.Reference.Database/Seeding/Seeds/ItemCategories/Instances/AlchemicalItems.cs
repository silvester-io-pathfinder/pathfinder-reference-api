using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ItemCategories.Instances
{
    public class AlchemicalItems : Template
    {
        public static readonly Guid ID = Guid.Parse("40c1e3c7-9870-4c2d-a45f-0f70f0d8139f");

        protected override ItemCategory GetItemCategory()
        {
            return new ItemCategory 
            {
                Id = ID, 
                PageNumber = 543, 
                Name = "Alchemical Items",
                Description = "Powered by the reactions of alchemical reagents. Almost all alchemical items are consumable items that are used up when you activate them. This category includes bombs, elixirs (including mutagens), poisons, and alchemical tools." 
            };
        }
    }
}
