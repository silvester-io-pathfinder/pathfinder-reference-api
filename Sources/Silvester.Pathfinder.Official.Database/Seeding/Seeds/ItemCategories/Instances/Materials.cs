using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.ItemCategories.Instances
{
    public class Materials : AbstractItemCategoryTemplate
    {
        public static readonly Guid ID = Guid.Parse("9229852f-02cb-43d5-ae10-c1ab7bc66cfa");

        protected override ItemCategory GetItemCategory()
        {
            return new ItemCategory 
            {
                Id = ID, 
                PageNumber = 577, 
                Name = "Materials", 
                Description = "Can be used to make items with unique properties and other advantages." 
            };
        }
    }
}
