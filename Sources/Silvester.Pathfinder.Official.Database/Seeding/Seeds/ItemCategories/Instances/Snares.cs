using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.ItemCategories.Instances
{
    public class Snares : Template
    {
        public static readonly Guid ID = Guid.Parse("4557c11d-e0fb-40ee-8b3c-b6c3340fc151");

        protected override ItemCategory GetItemCategory()
        {
            return new ItemCategory 
            {
                Id = ID, 
                PageNumber = 589, 
                Name = "Snares", 
                Description = "Single-use traps typically made by rangers." 
            };
        }
    }
}
