using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ItemCategories.Instances
{
    public class Ammunition : Template
    {
        public static readonly Guid ID = Guid.Parse("a3d34e6e-4c6e-4351-8b66-3e9faf08ca8f");

        protected override ItemCategory GetItemCategory()
        {
            return new ItemCategory 
            {
                Id = ID, 
                PageNumber = 559, 
                Name = "Ammunition", 
                Description = "Includes different types of magical arrows, crossbow bolts, and other types of ammunition." 
            };
        }
    }
}
