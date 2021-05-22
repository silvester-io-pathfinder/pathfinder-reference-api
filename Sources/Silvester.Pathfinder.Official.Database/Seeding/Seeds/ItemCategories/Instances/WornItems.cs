using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.ItemCategories.Instances
{
    public class WornItems : Template
    {
        public static readonly Guid ID = Guid.Parse("d907ade1-335e-48cd-9e9f-d407d11fd82b");

        protected override ItemCategory GetItemCategory()
        {
            return new ItemCategory 
            {
                Id = ID, 
                PageNumber = 603, 
                Name = "Worn Items",
                Description = "Consist of a vast collection of clothing and other items you wear on your body." 
            };
        }
    }
}
