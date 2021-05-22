using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.ItemCategories.Instances
{
    public class ApexItems : Template
    {
        public static readonly Guid ID = Guid.Parse("76b819ea-1c05-4a54-9b9a-3528535e8b68");

        protected override ItemCategory GetItemCategory()
        {
            return new ItemCategory 
            {
                Id = ID, 
                PageNumber = 603, 
                Name = "Apex Items",
                Description = "A subcategory of worn items of a high level that increase an ability score." 
            };
        }
    }
}
