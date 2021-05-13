using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.ItemCategories.Instances
{
    public class Armor : Template
    {
        public static readonly Guid ID = Guid.Parse("5d8aa60d-58e9-425a-9c92-0cac9eb5202d");

        protected override ItemCategory GetItemCategory()
        {
            return new ItemCategory 
            {
                Id = ID, 
                PageNumber = 555, 
                Name = "Armor", 
                Description = "Includes the rules for basic magical armor as well as special suits of armor." 
            };
        }
    }
}
