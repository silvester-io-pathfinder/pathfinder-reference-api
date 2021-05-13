using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.ItemCategories.Instances
{
    public class HeldItems : Template
    {
        public static readonly Guid ID = Guid.Parse("4346421f-aa3b-46aa-8783-3bdb5095df43");

        protected override ItemCategory GetItemCategory()
        {
            return new ItemCategory 
            {
                Id = ID, 
                PageNumber = 572, 
                Name = "Held Items", 
                Description = "A wide variety of items you use with your hands. This doesn’t include more narrow categories of held items, such as weapons." 
            };
        }
    }
}
