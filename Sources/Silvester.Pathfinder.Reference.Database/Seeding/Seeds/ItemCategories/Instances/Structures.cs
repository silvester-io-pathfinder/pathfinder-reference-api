using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ItemCategories.Instances
{
    public class Structures : Template
    {
        public static readonly Guid ID = Guid.Parse("680c5c0f-dc56-4937-a179-b78c90a94164");

        protected override ItemCategory GetItemCategory()
        {
            return new ItemCategory 
            {
                Id = ID, 
                PageNumber = 596, 
                Name = "Structures", 
                Description = "Buildings, tents, and other larger items." 
            };
        }
    }
}
