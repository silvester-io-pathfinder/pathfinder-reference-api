using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ItemCategories.Instances
{
    public class Materials : Template
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
