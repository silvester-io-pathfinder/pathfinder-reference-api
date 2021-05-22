using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.ItemCategories.Instances
{
    public class Wands : Template
    {
        public static readonly Guid ID = Guid.Parse("8f737ba1-e70a-4583-b55c-cc874f0f5660");

        protected override ItemCategory GetItemCategory()
        {
            return new ItemCategory 
            {
                Id = ID, 
                PageNumber = 597, 
                Name = "Wands", 
                Description = "Hold a spell of the crafter’s choice, and can be used to repeatedly cast that spell." 
            };
        }
    }
}
