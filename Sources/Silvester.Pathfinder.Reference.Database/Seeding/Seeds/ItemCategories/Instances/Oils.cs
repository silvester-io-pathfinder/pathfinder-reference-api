using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ItemCategories.Instances
{
    public class Oils : Template
    {
        public static readonly Guid ID = Guid.Parse("cea8ef00-93a9-4657-a712-c4904a79a6c7");

        protected override ItemCategory GetItemCategory()
        {
            return new ItemCategory 
            {
                Id = ID, 
                PageNumber = 561, 
                Name = "Oils", 
                Description = "Consumables applied to the surface of an object or person." 
            };
        }
    }
}
